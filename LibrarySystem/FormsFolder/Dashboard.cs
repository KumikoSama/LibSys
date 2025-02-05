using ComponentFactory.Krypton.Toolkit;
using LibrarySystem.Classes;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class Dashboard : KryptonForm
    {
        bool isBookmarks = false;

        public Dashboard()
        {
            InitializeComponent();
            Functions.ControlAccess(this, btnManage, btnPendingRequests, btnBookmarks, btnBorrow,
                btnReturn, btnAddBookmark, btnRemoveBookmark, btnMembers);
            Functions.CheckOverdueBooks();
            Functions.UpdatePenaltyFees();
            Functions.GetNumberOfBooks(datagridBooks, lblTotal);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Worker.RunWorkerAsync();
            Functions.CheckUserOverdue(this, btnBorrow);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Functions.Search("SearchBook", txtbxSearch.Text, datagridBooks);
            Functions.GetNumberOfBooks(datagridBooks, lblTotal);
        }

        private void btnViewBook_Click(object sender, EventArgs e)
        {
            if (BookDetails.Instance == null)
                Functions.BookDetails(datagridBooks);
            else return;
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (datagridBooks.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = datagridBooks.SelectedRows[0];
                string title = selectedRow.Cells["Title"].Value.ToString();
                int bookID = int.Parse(selectedRow.Cells["BookID"].Value.ToString());

                BorrowBook borrowBook = new BorrowBook(title, bookID);
                Functions.SwitchForms(borrowBook, this);
            }
            else return;
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            Functions.SwitchForms(Forms.ManageBooks(), this);
        }

        private void btnBorrowedBooks_Click(object sender, EventArgs e)
        {
            Functions.LoadBorrowedBooks(Classes.CurrentUser.UserID, datagridBooks, lblFormChange);
            if (CurrentUser.Role == "Member")
            {
                Functions.HideControls(this, btnAddBookmark, btnRemoveBookmark, btnConfirmPayment, btnBorrow, btnViewBook, cmbbxGenre);
                Functions.ShowControls(this, btnReturn);
            }
            else Functions.HideControls(this, btnAddBookmark, btnReturn, btnConfirmPayment, btnRemoveBookmark, btnBorrow, btnViewBook, cmbbxGenre);

            Functions.GetNumberOfBooks(datagridBooks, lblTotal);
        }

        private void btnAllBooks_Click(object sender, EventArgs e)
        {
            Worker.RunWorkerAsync();
            isBookmarks = false;

            if (CurrentUser.Role == "Member")
            {
                Functions.HideControls(this, btnRemoveBookmark, btnConfirmPayment, btnReturn);
                Functions.ShowControls(this, btnAddBookmark, btnBorrow, btnViewBook, cmbbxGenre);
            }
            else
            {
                Functions.HideControls(this, btnAddBookmark, btnReturn, btnConfirmPayment, btnRemoveBookmark, btnBorrow);
                Functions.ShowControls(this, btnViewBook, cmbbxGenre);
            }

            lblFormChange.Text = "All Available Books";
            cmbbxGenre.Items.Add("All Books");
            Functions.GetNumberOfBooks(datagridBooks, lblTotal);
        }

        private void btnOverdueBooks_Click(object sender, EventArgs e)
        {
            Functions.LoadOverdueBooks(datagridBooks, lblFormChange);

            if (CurrentUser.Role == "Member")
                Functions.HideControls(this, btnAddBookmark, btnReturn, btnConfirmPayment, btnRemoveBookmark, btnBorrow, btnViewBook, cmbbxGenre);
            else
            {
                Functions.HideControls(this, btnRemoveBookmark, btnReturn, btnBorrow, btnAddBookmark, btnViewBook, cmbbxGenre);
                Functions.ShowControls(this, btnConfirmPayment);
            }

            Functions.GetNumberOfBooks(datagridBooks, lblTotal);
        }

        private void btnBookmarks_Click(object sender, EventArgs e)
        {
            isBookmarks = true;
            Functions.LoadBookmarks(datagridBooks, Classes.CurrentUser.UserID, lblFormChange);

            if (CurrentUser.Role == "Member")
            {
                Functions.HideControls(this, btnAddBookmark, btnReturn, btnConfirmPayment);
                Functions.ShowControls(this, btnRemoveBookmark, btnBorrow, btnViewBook, cmbbxGenre);
            }
            else Functions.HideControls(this, btnAddBookmark, btnReturn, btnConfirmPayment, btnRemoveBookmark, btnBorrow, btnViewBook, cmbbxGenre);

            lblFormChange.Text = "Bookmarked Books";
            datagridBooks.Columns["BookmarkID"].Visible = false;
            cmbbxGenre.Items.Remove(cmbbxGenre.Items[0]);
            Functions.GetNumberOfBooks(datagridBooks, lblTotal);
        }

        private void cmbbxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            Functions.SortGenre(datagridBooks, cmbbxGenre, isBookmarks);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SideForms.CustomMessageBox.ShowYesNo("Are you sure you will return the book?", "Returning Book",
                Properties.Resources.question, () => Functions.ReturnBook(datagridBooks, Classes.CurrentUser.UserID));
            Functions.LoadBorrowedBooks(Classes.CurrentUser.UserID, datagridBooks, lblFormChange);
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            Functions.LoadTransactions(datagridBooks, Classes.CurrentUser.UserID, lblFormChange);
            Functions.HideControls(this, btnAddBookmark, btnReturn, btnConfirmPayment, btnRemoveBookmark, btnBorrow, btnViewBook, cmbbxGenre);
            Functions.GetNumberOfBooks(datagridBooks, lblTotal);
        }

        private void btnRemoveBookmark_Click(object sender, EventArgs e)
        {
            Functions.RemoveFromBookmarks(datagridBooks, Classes.CurrentUser.UserID);
            Functions.LoadBookmarks(datagridBooks, Classes.CurrentUser.UserID, lblFormChange);
        }

        private void btnAddBookmark_Click(object sender, EventArgs e)
        {
            Functions.AddToBookmarks(datagridBooks, Classes.CurrentUser.UserID);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            SideForms.CustomMessageBox.ShowYesNo("Are you sure you want to log out?", "Logging Out",
                Properties.Resources.question, () => Application.Restart());
        }

        private void exitbtnapp_Click(object sender, EventArgs e)
        {
            SideForms.CustomMessageBox.ShowYesNo("Are you sure you want to exit", "Exiting Application",
                Properties.Resources.question, yesAction: () => Application.Exit());
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            SideForms.CustomMessageBox.ShowYesNo("Are you sure to clear all penalty fees?\nBy saying clicking yes means that the book has been returned today with the penalty fees settled.", "Confirmation",
                Properties.Resources.question, () => Functions.SettlePenaltyFees(datagridBooks));
        }

        private void btnPendingRequests_Click(object sender, EventArgs e)
        {
            Functions.SwitchForms(Forms.PendingRequests(), this);
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            Functions.SwitchForms(Forms.MembersInfo(), this);
        }

        #region BackgroundWorker
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = Functions.LoadAllAvailableBooks();
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                DataTable dataTable = (DataTable)e.Result;
                datagridBooks.DataSource = dataTable;
                datagridBooks.Columns["BookID"].Visible = false;
                datagridBooks.Columns["Description"].Visible = false;
                datagridBooks.Columns["BookCover"].Visible = false;
                Functions.GetNumberOfBooks(datagridBooks, lblTotal);
            }
            else
            {
                MessageBox.Show("Error loading books: " + e.Error.Message);
            }
        }
        #endregion

        private void txtbxSearch_PlaceholderText(object sender, EventArgs e)
        {
            Functions.PlaceholderText(txtbxSearch, "Search for a book");
        }
    }
}
