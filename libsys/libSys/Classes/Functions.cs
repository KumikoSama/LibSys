using ComponentFactory.Krypton.Toolkit;
using LibrarySystem.Classes;
using libSys.Properties;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LibrarySystem
{
    public class Functions
    {
        static byte[] imageBytes = null;

        #region FrontPage
        public static void Login(KryptonForm form, KryptonTextBox txtbxContactMethod, KryptonTextBox txtbxpass, KryptonComboBox cmbbxcurrentuser, Label errorContactMethod, Label errorPassword)
        {
            Classes.CurrentUser.Role = Functions.GetCurrentUser(cmbbxcurrentuser);

            if (Validator.ValidateCredentials(txtbxContactMethod, txtbxpass, errorContactMethod, errorPassword))
            {
                Classes.CurrentUser.ContactMethod = txtbxContactMethod.Text;
                Classes.CurrentUser.Password = txtbxpass.Text;
                Classes.CurrentUser.Username = Functions.GetUsername(Classes.CurrentUser.ContactMethod, Classes.CurrentUser.Password);
                Classes.CurrentUser.UserID = Functions.GetMemberID(Classes.CurrentUser.ContactMethod, Classes.CurrentUser.Password);

                SwitchForms(Forms.Dashboard(), form);
            }

        }

        #endregion

        #region RegistrationForm

        public static void Register(KryptonForm form, KryptonComboBox[] comboBoxes, KryptonTextBox[] textBoxes, Label[] errorLabels)
        {
            try
            {
                User user = new User();

                var validations = new List<bool>
                {
                    Validator.ValidateName(textBoxes[0], errorLabels[0]),
                    Validator.ValidateName(textBoxes[1], errorLabels[1]),
                    Validator.ValidateAge(comboBoxes[0], errorLabels[2]),
                    Validator.ValidateGender(comboBoxes[1], errorLabels[3]),
                    Validator.ValidatePassword(textBoxes[3], errorLabels[6]),
                    Validator.ValidateUsername(textBoxes[2], errorLabels[5])
                };

                if (comboBoxes[2].SelectedItem.ToString() == "Email" && Validator.ValidateEmail(textBoxes[4], errorLabels[4]))
                    user.ContactMethod = textBoxes[4].Text;
                else if (comboBoxes[2].SelectedItem.ToString() == "Phone Number" && Validator.ValidatePhoneNum(textBoxes[4], errorLabels[4]))
                    user.ContactMethod = textBoxes[5].Text + textBoxes[4].Text;

                if (validations.Any(result => !result))
                    throw new FormatException();

                user.FirstName = Validator.CapitalizeFirstLetter(textBoxes[0].Text);
                user.LastName = Validator.CapitalizeFirstLetter(textBoxes[1].Text);
                user.Age = comboBoxes[0].SelectedItem.ToString();
                user.Gender = comboBoxes[1].SelectedItem.ToString();
                user.Username = textBoxes[2].Text;
                user.Password = textBoxes[3].Text;

                ExecuteQuery("InsertMemberInfo", new SqlParameter("@FirstName", user.FirstName), new SqlParameter("@LastName", user.LastName), new SqlParameter("@Age", user.Age), new SqlParameter("@Gender", user.Gender),
                    new SqlParameter("@Username", user.Username), new SqlParameter("ContactMethod", user.ContactMethod), new SqlParameter("@Password", user.Password));

                SideForms.CustomMessageBox.ShowOK("Registration complete!", "Account Created", Resources.success);
                SwitchForms(Forms.FrontPage(), form);
            }
            catch (FormatException)
            {
                SideForms.CustomMessageBox.ShowOK("Please correct the errors on the form", "Something went wrong", Resources.error);
            }
            catch (Exception ex)
            {
                SideForms.CustomMessageBox.ShowOK(ex.Message, "Something went wrong", Resources.error);
            }
        }

        public static void PasswordRequirements(KryptonTextBox password, params KryptonCheckBox[] checkBoxes)
        {
            var conditions = new Func<string, bool>[]
            {
                text => text.Any(char.IsUpper),
                text => text.Length >= 8,
                text => text.Any(char.IsDigit)
            };

            for (int i = 0; i < conditions.Length; i++)
                checkBoxes[i].CheckState = conditions[i](password.Text) ? CheckState.Checked : CheckState.Unchecked;

        }

        public static void ContactMethod(KryptonComboBox comboBox, KryptonComboBox cmbbxCountryCode, KryptonLabel lblContactMethod,
            KryptonTextBox txtbxContactMethod, KryptonTextBox txtbxCode)
        {
            string selectedItem = comboBox.SelectedItem.ToString();

            if (selectedItem == "Email")
            {
                cmbbxCountryCode.Visible = false;
                txtbxCode.Visible = false;
                lblContactMethod.Text = "Enter your email:";
                txtbxContactMethod.Size = new Size(249, 27);
                txtbxContactMethod.Location = new Point(135, 151);
            }
            else
            {
                cmbbxCountryCode.Visible = true;
                txtbxCode.Visible = true;
                lblContactMethod.Text = "Enter your phone number:";
                txtbxContactMethod.Size = new Size(185, 27);
                txtbxContactMethod.Location = new Point(199, 151);
            }
        }

        #endregion

        #region Dashboard

        public static void LoadBorrowedBooks(KryptonDataGridView datagridBooks, KryptonLabel lblFormChange)
        {
            if (Classes.CurrentUser.Role == "Member") LoadData("LoadBorrowedBooks", datagridBooks, true);
            else LoadData("LoadBorrowedBooks", datagridBooks, false);
            lblFormChange.Text = "Borrowed Books";
        }

        public static void LoadOverdueBooks(KryptonDataGridView datagridBooks, KryptonLabel lblFormChange)
        {
            try
            {
                if (Classes.CurrentUser.Role == "Member") LoadData("LoadOverdueBooks", datagridBooks, true);
                else LoadData("LoadOverdueBooks", datagridBooks, false);

                lblFormChange.Text = "Overdue Books";
                datagridBooks.Columns["BorrowID"].Visible = false;
            }
            catch (Exception ex)
            {
                SideForms.CustomMessageBox.ShowOK("Error while loading overdue books:\n" + ex.Message, "Error", Resources.error);
            }
        }

        public static void CheckOverdue(Form form, KryptonButton btnBorrow)
        {
            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("CheckOverdue", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MemberID", Classes.CurrentUser.UserID);

                object result = cmd.ExecuteScalar();
                int rowsAffected = result as int? ?? 0; // If null, default to 0

                if (rowsAffected > 0)
                {
                    SideForms.CustomMessageBox.ShowOK($"You have {rowsAffected} overdue books\nSettle it first before you can borrow again", "Overdue books", Resources.information);
                    form.Controls.Remove(btnBorrow);
                }
            }
        }

        public static void GetPopularBooks(PictureBox[] pictureBoxes, Label[] labels)
        {
            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                conn.Open();
                
                SqlCommand cmd = new SqlCommand("GetPopularBooks", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    for (int i = 0; i < pictureBoxes.Length && reader.Read(); i++)
                    {
                        if (reader["BookCover"] != DBNull.Value)
                        {
                            byte[] data = (byte[])reader["BookCover"];
                            MemoryStream ms = new MemoryStream(data);
                            pictureBoxes[i].Image = Image.FromStream(ms);
                        }

                        labels[i].Text = $"{reader.GetString(1)}\n{reader.GetString(2)}\n{reader.GetInt16(3)}";
                    }
                }
            }
        }

        public static bool BookDetails(KryptonDataGridView dtBooks)
        {
            bool isButtonClicked = true;

            if (dtBooks.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dtBooks.SelectedRows[0];

                string title = selectedRow.Cells["Title"].Value.ToString();
                string description = selectedRow.Cells["Description"].Value.ToString();
                string author = selectedRow.Cells["Author"].Value.ToString();

                if (selectedRow.Cells["BookCover"].Value != DBNull.Value)
                {
                    byte[] bookCover = (byte[])selectedRow.Cells["BookCover"].Value;
                    MemoryStream ms = new MemoryStream(bookCover);
                    Image image = Image.FromStream(ms);

                    BookDetails bookDetails = new BookDetails(description, title, author, image);
                    bookDetails.Show();
                }
            }
            return isButtonClicked;
        }

        public static void SortGenre(KryptonDataGridView dtBooks, KryptonComboBox cmbbxgenre, bool isBookmarks)
        {
            string genre = cmbbxgenre.SelectedItem.ToString();

            if (cmbbxgenre.Items.Contains(cmbbxgenre.SelectedItem.ToString()))
            {
                using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("SortBooksByGenre", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Genre", genre);
                    cmd.Parameters.AddWithValue("@IsBookmarks", isBookmarks);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dtBooks.DataSource = dt;
                }
            }
        }

        public static void ReturnBook(KryptonDataGridView datagridBooks)
        {
            if (datagridBooks.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = datagridBooks.SelectedRows[0];
                int bookID = int.Parse(selectedRow.Cells["BookID"].Value.ToString());

                using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("ReturnBook", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@BookID", bookID);
                        cmd.Parameters.AddWithValue("@MemberID", Classes.CurrentUser.UserID);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0) SideForms.CustomMessageBox.ShowOK("Book returned successfully", "Successful", Resources.success);
                        else SideForms.CustomMessageBox.ShowOK("No matching record found or the book has already been returned.", "Error", Resources.error);
                    }
                }
            }
            else
                SideForms.CustomMessageBox.ShowOK("You can only return one book at a time.", "Selection", Resources.information);
        }

        public static void GetNumberOfBooks(KryptonDataGridView datagridbooks, KryptonLabel lblTotalCount)
        {
            int total = datagridbooks.Rows.Count;
            lblTotalCount.Text = "Total: " + total;
        }

        public static void LoadTransactions(KryptonDataGridView datagridBooks, KryptonLabel lblFormChange)
        {
            if (Classes.CurrentUser.Role == "Member") LoadData("LoadTransactions", datagridBooks, true);
            else LoadData("LoadTransactions", datagridBooks, false);

            lblFormChange.Text = "Transactions";
        }

        public static void AddToBookmarks(KryptonDataGridView datagridBooks)
        {
            if (datagridBooks.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = datagridBooks.SelectedRows[0];
                    int bookID = int.Parse(selectedRow.Cells["BookID"].Value.ToString());

                    ExecuteQuery("InsertBookmark", new SqlParameter("@MemberID", Classes.CurrentUser.UserID), new SqlParameter("@BookID", bookID));
                    SideForms.CustomMessageBox.ShowOK("Successfully bookmarked!", "Success", Resources.success);
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                        SideForms.CustomMessageBox.ShowOK("This book already exists in your bookmarks", "Information", Resources.information);
                    else
                        SideForms.CustomMessageBox.ShowOK("Something went wrong:\n" + ex.Message, "Error", Resources.error);
                }
            }
            else
                SideForms.CustomMessageBox.ShowOK("Please choose exactly one book to bookmark.", "Selection", Resources.information);
        }

        public static void RemoveFromBookmarks(KryptonDataGridView datagridBooks)
        {
            if (datagridBooks.SelectedRows.Count > 0)
            {
                using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("RemoveBookmark", conn))
                    {
                        DataGridViewRow selectedRow = datagridBooks.SelectedRows[0];
                        int bookmarkID = int.Parse(selectedRow.Cells["BookmarkID"].Value.ToString());

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MemberID", Classes.CurrentUser.UserID);
                        cmd.Parameters.AddWithValue("@BookmarkID", bookmarkID);

                        cmd.ExecuteNonQuery();
                        SideForms.CustomMessageBox.ShowOK("Removed from bookmarks", "Bookmark removed", Resources.information);
                    }
                }
            }
            else
                SideForms.CustomMessageBox.ShowOK("Please choose exactly one book to bookmark.", "Selection", Resources.information);
        }

        #endregion

        #region AdminAccess

        static readonly List<string> listOfGenres = new List<string>();
        static List<string> previousSelectedGenres = new List<string>();

        public static void SettlePenaltyFees(KryptonDataGridView dataGridOverdue)
        {
            DataGridViewRow selectedRow = dataGridOverdue.SelectedRows[0];
            int memberID = int.Parse(selectedRow.Cells["MemberID"].Value.ToString());
            int borrowID = int.Parse(selectedRow.Cells["BorrowID"].Value.ToString());

            ExecuteQuery("ClearPenaltyFees", new SqlParameter("@MemberID", memberID), new SqlParameter("@BorrowID", borrowID));

            SideForms.CustomMessageBox.ShowOK("Penalty fees cleared.", "Payments Settled", Resources.success);
        }

        public static void DeleteMember(KryptonDataGridView dataGridMembers)
        {
            DataGridViewRow selectedRow = dataGridMembers.SelectedRows[0];
            int memberID = int.Parse(selectedRow.Cells["MemberID"].Value.ToString());

            ExecuteQuery("DeleteMember", new SqlParameter("@MemberID", memberID));

            SideForms.CustomMessageBox.ShowOK("Member successfully removed.", "Member Removed", Resources.success);

            Functions.LoadData("LoadMemberInfo", dataGridMembers, false);
            dataGridMembers.Columns["MemberID"].Visible = false;
        }

        #region BorrowBook

        public static void InsertToPendingRequests(int bookID, string days, string copies)
        {
            try
            {
                DateTime dateRequested = DateTime.Now;
                int borrowDuration = Convert.ToInt32(days);
                int copiesToBorrow = Convert.ToInt32(copies);

                using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("InsertPendingRequest", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@BookID", bookID);
                    cmd.Parameters.AddWithValue("@MemberID", Classes.CurrentUser.UserID);
                    cmd.Parameters.AddWithValue("@DateRequested", dateRequested);
                    cmd.Parameters.AddWithValue("@BorrowDuration", borrowDuration);
                    cmd.Parameters.AddWithValue("@CopiesToBorrow", copiesToBorrow);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                SideForms.CustomMessageBox.ShowOK("Request sent\nPlease wait for confirmation", "Borrow Request Sent", Resources.success);
            }
            catch (Exception ex)
            {
                SideForms.CustomMessageBox.ShowOK("Something went wrong:\n" + ex.Message, "Error", Resources.error);
            }
        }

        #endregion

        #region PendingRequests

        public static void LoadPendingRequests(KryptonDataGridView dataGridPendingRequests)
        {
            LoadData("LoadPendingRequests", dataGridPendingRequests, false);
            dataGridPendingRequests.Columns["MemberID"].Visible = false;
            dataGridPendingRequests.Columns["BookID"].Visible = false;
        }

        public static void PopulateRequestForm(KryptonDataGridView dataGridPendingRequests, KryptonTextBox txtbxMemberName, KryptonTextBox txtbxBookName, KryptonTextBox txtbxCopies,
            KryptonTextBox txtbxBorrowDuration, KryptonDateTimePicker dateRequested)
        {
            DataGridViewRow selectedRow = dataGridPendingRequests.SelectedRows[0];
            txtbxMemberName.Text = selectedRow.Cells["FirstName"].Value.ToString() + " " + selectedRow.Cells["LastName"].Value.ToString();
            txtbxBookName.Text = selectedRow.Cells["Title"].Value.ToString();
            txtbxCopies.Text = selectedRow.Cells["CopiesToBorrow"].Value.ToString();
            txtbxBorrowDuration.Text = selectedRow.Cells["BorrowDuration"].Value.ToString();
            dateRequested.Value = Convert.ToDateTime(selectedRow.Cells["DateRequested"].Value);
        }

        public static void DeclineRequest(KryptonDataGridView dataGridPendingRequests)
        {
            DataGridViewRow selectedRow = dataGridPendingRequests.SelectedRows[0];
            int memberID = int.Parse(selectedRow.Cells["MemberID"].Value.ToString());

            ExecuteQuery("DeclineRequest", new SqlParameter("@MemberID", memberID));

            SideForms.CustomMessageBox.ShowOK("Request declined.", "Borrow Request Declined", Resources.question);
            LoadPendingRequests(dataGridPendingRequests);
        }

        public static void ApproveRequest(KryptonDateTimePicker dueDate, KryptonDataGridView dataGridPendingRequests)
        {
            DataGridViewRow selectedRow = dataGridPendingRequests.SelectedRows[0];
            int bookID = int.Parse(selectedRow.Cells["BookID"].Value.ToString());
            int memberID = int.Parse(selectedRow.Cells["MemberID"].Value.ToString());
            int numberOfCopies = int.Parse(selectedRow.Cells["CopiesToBorrow"].Value.ToString());
            DateTime borrowdate = DateTime.Now;
            DateTime duedate = dueDate.Value;

            ExecuteQuery("InsertBorrowedBook", new SqlParameter("MemberID", memberID), new SqlParameter("@BookID", bookID), new SqlParameter("@BorrowDate", borrowdate),
                new SqlParameter("@DueDate", duedate), new SqlParameter("@Copies", numberOfCopies));

            SideForms.CustomMessageBox.ShowOK("Request approved!", "Request Approval", Resources.success);
            LoadPendingRequests(dataGridPendingRequests);
        }

        #endregion

        #region ManageBooks

        public static void RefreshTextBoxes(Dictionary<Control, string> txtBxInitialValues)
        {
            foreach (var entry in txtBxInitialValues)
            {
                entry.Key.Text = entry.Value;
            }
        }

        public static void AddGenre(KryptonListBox genreListBx)
        {
            // Get the currently selected items
            List<string> currentSelectedGenres = genreListBx.SelectedItems.Cast<string>().ToList();

            // Find genres that were deselected
            List<string> deselectedGenres = previousSelectedGenres.Except(currentSelectedGenres).ToList();

            // Remove deselected genres from the selected list
            foreach (string genre in deselectedGenres)
                listOfGenres.Remove(genre);

            // Update the list of previous selected items
            previousSelectedGenres = currentSelectedGenres;
        }

        public static List<string> GetBookGenres(int bookID)
        {
            List<string> genres = new List<string>();

            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("GetBookGenres", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BookID", bookID);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                        genres.Add(reader["Genre"].ToString());
                }
            }
            return genres;
        }

        public static void AddToBookGenre(int bookID = 0)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("InsertToBookGenre", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    foreach (string genre in previousSelectedGenres)
                    {
                        cmd.Parameters.AddWithValue("@Genre", genre);
                        cmd.Parameters.AddWithValue("@BookID", bookID);

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    conn.Close();
                }
            }
            catch (SqlException e)
            {
                if (e.Number == 2627)
                    return;
            }
        }

        public static void AddNewBook(KryptonTextBox txtbxTitle, KryptonTextBox txtbxAuthor, KryptonTextBox txtbxPublishedYear, KryptonTextBox txtbxCopies, KryptonRichTextBox txtbxDesc)
        {
            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("AddNewBook", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddRange(new SqlParameter[]
                {
                    new SqlParameter("@BookCover", imageBytes),
                    new SqlParameter("@Title", txtbxTitle.Text),
                    new SqlParameter("@Author", txtbxAuthor.Text),
                    new SqlParameter("@YearOfPublication", txtbxPublishedYear.Text),
                    new SqlParameter("@Description", txtbxDesc.Text),
                    new SqlParameter("@Copies", txtbxCopies.Text)
                });

                conn.Open();
                object bookID = cmd.ExecuteScalar();

                if (bookID != null)
                    AddToBookGenre(Convert.ToInt32(bookID));
            }
            SideForms.CustomMessageBox.ShowOK("Book added successfully!", "New Book Added", Resources.success);
        }

        public static void DeleteBook(KryptonDataGridView datagridBooks)
        {
            DataGridViewRow selectedRow = datagridBooks.SelectedRows[0];
            int bookID = Convert.ToInt32(selectedRow.Cells["BookID"].Value);

            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DeleteBook", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BookID", bookID);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                    SideForms.CustomMessageBox.ShowOK("Book successfully deleted", "Book Deleted", Resources.success);
                conn.Close();
            }
        }


        public static void PopulateTextBoxes(KryptonTextBox txtbxTitle, KryptonTextBox txtbxAuthor, KryptonTextBox txtbxPublishedYear, KryptonTextBox txtbxCopies,
            KryptonRichTextBox txtbxDesc, PictureBox bookCoverImage, KryptonDataGridView datagridBooks, KryptonListBox genreListBox)
        {
            try
            {
                DataGridViewRow selectedRow = datagridBooks.SelectedRows[0];
                int bookID = Convert.ToInt32(selectedRow.Cells["BookID"].Value);

                List<string> selectedGenres = GetBookGenres(bookID);

                genreListBox.ClearSelected();

                for (int i = 0; i < genreListBox.Items.Count; i++)
                {
                    if (selectedGenres.Contains(genreListBox.Items[i].ToString()))
                        genreListBox.SetSelected(i, true);
                }

                if (datagridBooks.SelectedRows.Count == 1)
                {
                    if (selectedRow.Cells["BookCover"].Value != DBNull.Value)
                    {
                        byte[] bookCover = (byte[])selectedRow.Cells["BookCover"].Value;
                        MemoryStream ms = new MemoryStream(bookCover);
                        Image image = Image.FromStream(ms);
                        bookCoverImage.Image = image;
                        imageBytes = ms.ToArray();
                    }
                    else
                    {
                        bookCoverImage.Image = null;
                        bookCoverImage.BackColor = Color.WhiteSmoke;
                    }

                    txtbxTitle.Text = selectedRow.Cells["Title"].Value.ToString();
                    txtbxAuthor.Text = selectedRow.Cells["Author"].Value.ToString();
                    txtbxPublishedYear.Text = selectedRow.Cells["YearOfPublication"].Value.ToString();
                    txtbxDesc.Text = selectedRow.Cells["Description"].Value.ToString();
                    txtbxCopies.Text = selectedRow.Cells["Copies"].Value.ToString();
                }
                else
                    SideForms.CustomMessageBox.ShowOK("Please select exactly one row", "Selection", Resources.information);
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
            catch (Exception ex)
            {
                SideForms.CustomMessageBox.ShowOK(ex.Message, "Something went wrong", Resources.information);
            }
        }

        public static void UploadImage(PictureBox bookCoverImage)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Select an Image"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Display the image in the PictureBox
                bookCoverImage.Image = new Bitmap(openFileDialog.FileName);
                // Convert the image to a byte array
                using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        imageBytes = br.ReadBytes((int)fs.Length);
                    }
                }
            }
        }

        public static void SaveBook(KryptonTextBox txtbxTitle, KryptonTextBox txtbxAuthor, KryptonTextBox txtbxPublishedYear,
            KryptonTextBox txtbxCopies, KryptonRichTextBox txtbxDesc, int bookId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("SaveEditedBook", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@BookID", bookId);
                    cmd.Parameters.AddWithValue("@BookCover", imageBytes);
                    cmd.Parameters.AddWithValue("@Title", txtbxTitle.Text);
                    cmd.Parameters.AddWithValue("@Author", txtbxAuthor.Text);
                    cmd.Parameters.AddWithValue("@YearOfPublication", txtbxPublishedYear.Text);
                    cmd.Parameters.AddWithValue("@Description", txtbxDesc.Text);
                    cmd.Parameters.AddWithValue("@Copies", txtbxCopies.Text);

                    AddToBookGenre(bookId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                SideForms.CustomMessageBox.ShowOK("Book saved successfully", "Book Changes Saved", Resources.success);
            }
            catch (Exception ex)
            {
                SideForms.CustomMessageBox.ShowOK("Something went wrong:\n" + ex.Message, "Error", Resources.error);
            }
        }

        #endregion

        #endregion

        #region GeneralFunctions

        public static void PlaceholderText(KryptonTextBox textBox, string placeholderText)
        {
            if (textBox.Text == placeholderText)
            {
                textBox.Text = "";
                textBox.StateCommon.Content.Font = new Font(textBox.StateCommon.Content.Font.FontFamily, textBox.StateCommon.Content.Font.Size, FontStyle.Regular);
            }
            else if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholderText;
                textBox.StateCommon.Content.Font = new Font(textBox.StateCommon.Content.Font.FontFamily, textBox.StateCommon.Content.Font.Size, FontStyle.Italic);
            }
        }

        public static void ControlAccess(KryptonForm form, params KryptonButton[] buttons)
        {
            if (Classes.CurrentUser.Role == "Member") HideControls(form, buttons[0], buttons[6]);
            else HideControls(form, buttons[1], buttons[2], buttons[3], buttons[4], buttons[5]);
        }

        public static string GetCurrentUser(KryptonComboBox cmbbxcurrentUser)
        {
            string currentUser;

            if (cmbbxcurrentUser.SelectedItem.ToString() == "Member")
            {
                currentUser = "Member";
                return currentUser;
            }
            else
            {
                currentUser = "Librarian";
                return currentUser;
            }
        }

        public static string GetUsername(string contactMethod, string password)
        {
            string username = "";

            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                string query = "SELECT Username FROM dbo.MemberInfo WHERE @ContactMethod = ContactMethod AND @Password = Password;";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ContactMethod", contactMethod);
                    cmd.Parameters.AddWithValue("@Password", password);

                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null) username = result.ToString();
                }
            }
            return username;
        }

        public static void Search(string query, string searchInput, KryptonDataGridView dataTable)
        {
            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SearchInput", searchInput);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataTable.DataSource = dt;
                }
            }
        }

        public static void ExecuteQuery(string query, params SqlParameter[] parameterSets)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (parameterSets != null)
                        cmd.Parameters.AddRange(parameterSets);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                SideForms.CustomMessageBox.ShowOK(ex.Message, "Something went wrong", Resources.error);
            }
        }

        public static DataTable LoadAllAvailableBooks()
        {
            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("LoadAllAvailableBooks", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    conn.Open();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
            }
        }

        public static int GetMemberID(string contactMethod, string password)
        {
            int memberID = 0;

            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                string query = "SELECT MemberID FROM dbo.MemberInfo WHERE @ContactMethod = ContactMethod AND @Password = Password;";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ContactMethod", contactMethod);
                    cmd.Parameters.AddWithValue("@Password", password);

                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                        memberID = int.Parse(result.ToString());
                }
            }
            return memberID;
        }

        public static void DateChange(KryptonTextBox txtBxBorrowDuration, KryptonDateTimePicker dueDate)
        {
            if (int.TryParse(txtBxBorrowDuration.Text, out int days))
            {
                dueDate.Value = DateTime.Now.AddDays(days);
            }
        }

        public static void LoadData(string query, KryptonDataGridView dataTable, bool isMember)
        {
            using (SqlConnection conn = new SqlConnection(GlobalConfig.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                if (isMember)
                    cmd.Parameters.AddWithValue("@MemberID", Classes.CurrentUser.UserID);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataTable.DataSource = dt;
            }
        }

        public static void ClearTextBoxes(Control container, params KryptonTextBox[] textBoxes)
        {
            foreach (KryptonTextBox textBox in textBoxes)
                textBox.Clear();
        }

        public static void EmptyTextboxes(PictureBox bookCover, KryptonListBox genreListBox, params Control[] controls)
        {
            bookCover.Image = null;
            bookCover.BackColor = Color.WhiteSmoke;
            listOfGenres.Clear();
            genreListBox.SelectedItems.Clear();

            foreach (Control control in controls)
                control.Text = string.Empty;
        }

        public static void HideControls(Control container, params Control[] controls)
        {
            foreach (Control control in controls)
                control.Visible = false;
        }

        public static void ShowControls(Control container, params Control[] controls)
        {
            foreach (Control control in controls)
                control.Visible = true;
        }

        public static void EnableDisableControls(bool isEnabled, params Control[] controls)
        {
            foreach (Control control in controls)
            {
                if (isEnabled)
                    control.Enabled = false;
                else
                    control.Enabled = true;
            }
        }

        public static void SwitchForms(KryptonForm showForm, KryptonForm hideForm)
        {
            hideForm.Hide();
            showForm.Show();
        }

        public static void CenteredPanels(KryptonForm form, Panel panel, Panel panel2)
        {
            int x = (form.ClientSize.Width - panel2.Width) / 2;
            int y = (form.ClientSize.Height - panel2.Height) / 2;
            panel.Hide();
            panel2.Show();
            panel2.Location = new Point(x, y);
        }
        #endregion
    }
}