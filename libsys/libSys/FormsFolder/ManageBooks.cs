using ComponentFactory.Krypton.Toolkit;
using LibrarySystem.Classes;
using libSys.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Microsoft.Data.SqlClient;
using System.Net;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class ManageBooks : KryptonForm
    {
        readonly Dictionary<Control, string> txtBxInitialValues = new Dictionary<Control, string>();

        public ManageBooks()
        {
            InitializeComponent();
            Worker.RunWorkerAsync();

            foreach (Control control in kryptonGroupBox1.Panel.Controls)
            {
                if (control is KryptonTextBox textBox)
                    txtBxInitialValues[textBox] = textBox.Text;
            }
        }

        private void ManageBooks_Load(object sender, EventArgs e)
        {
            genreListBox.DataSource = LoadComboBox.Genres();

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
            Functions.RefreshTextBoxes(txtBxInitialValues);
            Functions.EnableDisableControls(false, txtbxAuthor, txtbxCopies, txtbxDescription, txtbxTitle, txtbxDescription, txtbxYear, lnklblUploadImage, genreListBox);

            datagridBooks.Enabled = false;
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            Functions.HideControls(this, btnEditBook, btnSaveNewBook);
            Functions.ShowControls(this, btnAddNewBook, btnSaveChanges);
            Functions.RefreshTextBoxes(txtBxInitialValues);
            Functions.EnableDisableControls(true, txtbxAuthor, txtbxCopies, txtbxDescription, txtbxTitle, txtbxDescription, txtbxYear, lnklblUploadImage, genreListBox, btnSaveChanges);

            datagridBooks.Enabled = true;
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Functions.SwitchForms(Forms.Dashboard(), this);
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            SideForms.CustomMessageBox.ShowYesNo("Are you sure you want to delete this book?", "Confirm Book Deletion",
                Resources.question, () => Functions.DeleteBook(datagridBooks));
            Worker.RunWorkerAsync();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Functions.Search("SearchBook", txtbxSearchBar.Text, datagridBooks);
        }

        private void datagridBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Functions.PopulateTextBoxes(txtbxTitle, txtbxAuthor, txtbxYear, txtbxCopies, txtbxDescription, bookCoverImage, datagridBooks, genreListBox);
            Functions.EnableDisableControls(false, txtbxAuthor, txtbxCopies, txtbxDescription, txtbxTitle, txtbxDescription, txtbxYear, lnklblUploadImage, genreListBox, btnSaveChanges);

            txtbxDescription.SelectAll();
            txtbxDescription.SelectionAlignment = HorizontalAlignment.Center;

            if (bookCoverImage.Image == null) lnklblRemoveImage.Visible = false;
            else lnklblRemoveImage.Visible = true;
        }

        private void genreListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Functions.AddGenre(genreListBox);
        }

        private void lnklblRemoveImage_LinkClicked(object sender, EventArgs e)
        {
            bookCoverImage.Image = null;
            bookCoverImage.BackColor = Color.Silver;
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

            Functions.ExecuteQuery("SaveEditedBook", new SqlParameter("@BookID", bookID),
                new SqlParameter("@BookCover", Functions.ImageBytes),
                new SqlParameter("@Title", txtbxTitle.Text),
                new SqlParameter("@Author", txtbxAuthor.Text),
                new SqlParameter("@YearOfPublication", txtbxYear.Text),
                new SqlParameter("@Description", txtbxDescription.Text),
                new SqlParameter("@Copies", txtbxCopies.Text));

            Functions.AddToBookGenre(bookID);

            SideForms.CustomMessageBox.ShowOK("Book saved successfully", "Book Changes Saved", Resources.success);

            Worker.RunWorkerAsync();
        }

        private void picBxRefresh_Click(object sender, EventArgs e)
        {
            Worker.RunWorkerAsync();
        }

        private void txtbxNumberOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            KryptonTextBox txtbx = sender as KryptonTextBox;

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            else if (char.IsDigit(e.KeyChar) && txtbx.Text.Length >= 10)
                e.Handled = true;
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

        #endregion

        private void txtbxSearchBar_TextChanged(object sender, EventArgs e)
        {
            if (txtbxSearchBar.Text != "Search for a book")
                Functions.Search("SearchBook", txtbxSearchBar.Text, datagridBooks);
        }
    }
}