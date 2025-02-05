using ComponentFactory.Krypton.Toolkit;
using LibrarySystem.Classes;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class ManageBooks : KryptonForm
    {
        public ManageBooks()
        {
            InitializeComponent();
            kryptonGroupBox1.CaptionVisible = false;
        }

        private void ManageBooks_Load(object sender, EventArgs e)
        {
            Worker.RunWorkerAsync();
            datagridBooks.DataSource = Functions.LoadAllAvailableBooks();
            if (bookCoverImage.Image != null)
                lnklblRemoveImage.Visible = true;
            else lnklblRemoveImage.Visible = false;
        }

        private void ManageBooks_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnUploadImage_LinkClicked(object sender, EventArgs e)
        {
            Functions.UploadImage(bookCoverImage);
        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            Functions.HideControls(this, btnAddNewBook, btnSaveChanges);
            Functions.ShowControls(this, btnEditBook, btnSaveNewBook);
            Functions.EmptyTextboxes(bookCoverImage, genreListBox, txtbxTitle, txtbxAuthor, txtbxCopies, txtbxDescription, txtbxYear);
            datagridBooks.Enabled = false;
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            Functions.HideControls(this, btnEditBook, btnSaveNewBook);
            Functions.ShowControls(this, btnAddNewBook, btnSaveChanges);
            datagridBooks.Enabled = true;
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Functions.SwitchForms(Forms.Dashboard(), this);
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            SideForms.CustomMessageBox.ShowYesNo("Are you sure you want to delete this book?", "Confirm Book Deletion",
                Properties.Resources.question, () => Functions.DeleteBook(datagridBooks));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Functions.Search("SearchBook", txtbxSearchBar.Text, datagridBooks);
        }

        private void datagridBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Functions.PopulateTextBoxes(txtbxTitle, txtbxAuthor, txtbxYear, txtbxCopies, txtbxDescription, bookCoverImage, datagridBooks, genreListBox);
            
            txtbxDescription.SelectAll();
            txtbxDescription.SelectionAlignment = HorizontalAlignment.Center;

            if (bookCoverImage.Image == null)
                lnklblRemoveImage.Visible = false;
            else lnklblRemoveImage.Visible = true;
        }

        private void genreListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Functions.AddGenre(genreListBox);
        }

        private void lnklblRemoveImage_LinkClicked(object sender, EventArgs e)
        {
            Functions.RemoveImage(bookCoverImage);
        }

        private void btnSaveNewBook_Click(object sender, EventArgs e)
        {
            Functions.AddNewBook(txtbxTitle, txtbxAuthor, txtbxYear, txtbxCopies, txtbxDescription);
            Worker.RunWorkerAsync();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = datagridBooks.SelectedRows[0];
            int bookID = int.Parse(selectedRow.Cells["BookID"].Value.ToString());

            Functions.SaveBook(txtbxTitle, txtbxAuthor, txtbxYear, txtbxCopies, txtbxDescription, bookID);

            Worker.RunWorkerAsync();
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
            }
            else
                MessageBox.Show("Error loading books: " + e.Error.Message);
        }

        #endregion

        #region PlaceholderText

        private void txtbxSearchBar_PlaceholderText(object sender, EventArgs e)
        {
            Functions.PlaceholderText(txtbxSearchBar, "Search for a book");
        }

        private void txtbxTitle_PlaceholderText(object sender, EventArgs e)
        {
            Functions.PlaceholderText(txtbxTitle, "Title");
        }

        private void txtbxAuthor_PlaceholderText(object sender, EventArgs e)
        {
            Functions.PlaceholderText(txtbxAuthor, "Author");
        }

        private void txtbxYear_PlaceholderText(object sender, EventArgs e)
        {
            Functions.PlaceholderText(txtbxYear, "Year of Publication");
        }

        private void txtbxCopies_PlaceholderText(object sender, EventArgs e)
        {
            Functions.PlaceholderText(txtbxCopies, "Copies");
        }

        private void txtbxDescription_PlaceholderText(object sender, EventArgs e)
        {
            Functions.PlaceholderText(txtbxDescription, "Description");
        }

        #endregion
    }
}