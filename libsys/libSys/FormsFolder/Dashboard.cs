using ComponentFactory.Krypton.Toolkit;
using LibrarySystem.Classes;
using libSys.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace LibrarySystem
{
    public partial class Dashboard : KryptonForm
    {
        bool isBookmarks = false;

        public Dashboard()
        {
            InitializeComponent();
            Worker.RunWorkerAsync();
            Functions.ControlAccess(this, btnManage, btnBookmarks, btnBorrow,
                btnReturn, btnAddBookmark, btnRemoveBookmark, btnMembers);
            Functions.ExecuteQuery("CheckOverdueBooks");
            Functions.ExecuteQuery("UpdatePenaltyFees");
            LoadComboBox.Genres(cmbbxGenre);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Functions.CheckUserOverdue(this, btnBorrow);
        }

        #region ButtonClickEvents

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Functions.Search("SearchBook", txtbxSearch.Text, datagridBooks);
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
            Functions.LoadBorrowedBooks(datagridBooks, lblFormChange);

            if (CurrentUser.Role == "Member")
            {
                Functions.HideControls(this, btnAddBookmark, btnRemoveBookmark, btnConfirmPayment, btnBorrow, btnViewBook, cmbbxGenre, btnCancelRequest);
                Functions.ShowControls(this, btnReturn);
            }
            else Functions.HideControls(this, btnAddBookmark, btnReturn, btnConfirmPayment, btnRemoveBookmark, btnBorrow, btnViewBook, cmbbxGenre, btnCancelRequest);
        }

        private void btnAllBooks_Click(object sender, EventArgs e)
        {
            Worker.RunWorkerAsync();
            isBookmarks = false;

            if (CurrentUser.Role == "Member")
            {
                Functions.HideControls(this, btnRemoveBookmark, btnConfirmPayment, btnReturn, btnCancelRequest);
                Functions.ShowControls(this, btnAddBookmark, btnBorrow, btnViewBook, cmbbxGenre);
            }
            else
            {
                Functions.HideControls(this, btnAddBookmark, btnReturn, btnConfirmPayment, btnRemoveBookmark, btnBorrow, btnCancelRequest);
                Functions.ShowControls(this, btnViewBook, cmbbxGenre);
            }

            lblFormChange.Text = "All Available Books";
        }

        private void btnOverdueBooks_Click(object sender, EventArgs e)
        {
            Functions.LoadOverdueBooks(datagridBooks, lblFormChange);

            if (CurrentUser.Role == "Member")
                Functions.HideControls(this, btnAddBookmark, btnReturn, btnConfirmPayment, btnRemoveBookmark, btnBorrow, btnViewBook, cmbbxGenre, btnCancelRequest);
            else
            {
                Functions.HideControls(this, btnRemoveBookmark, btnReturn, btnBorrow, btnAddBookmark, btnViewBook, cmbbxGenre);
                Functions.ShowControls(this, btnConfirmPayment);
            }
        }

        private void btnBookmarks_Click(object sender, EventArgs e)
        {
            isBookmarks = true;
            Functions.LoadData("LoadUserBookmarks", datagridBooks, true);

            Functions.HideControls(this, btnAddBookmark, btnReturn, btnConfirmPayment, btnCancelRequest);
            Functions.ShowControls(this, btnRemoveBookmark, btnBorrow, btnViewBook, cmbbxGenre);

            lblFormChange.Text = "Bookmarked Books";
            datagridBooks.Columns["BookmarkID"].Visible = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SideForms.CustomMessageBox.ShowYesNo("Are you sure you will return the book?", "Returning Book",
                Resources.question, () => Functions.ReturnBook(datagridBooks));
            Functions.LoadBorrowedBooks(datagridBooks, lblFormChange);
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            Functions.LoadTransactions(datagridBooks, lblFormChange);
            Functions.HideControls(this, btnAddBookmark, btnReturn, btnConfirmPayment, btnRemoveBookmark, btnBorrow, btnViewBook, cmbbxGenre, btnCancelRequest);
        }

        private void btnRemoveBookmark_Click(object sender, EventArgs e)
        {
            Functions.RemoveFromBookmarks(datagridBooks);
            Functions.LoadUser("LoadUserBookmarks", datagridBooks);
        }

        private void btnAddBookmark_Click(object sender, EventArgs e)
        {
            Functions.AddToBookmarks(datagridBooks);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            SideForms.CustomMessageBox.ShowYesNo("Are you sure you want to log out?", "Logging Out",
                Resources.question, () => Application.Restart());
        }

        private void exitbtnapp_Click(object sender, EventArgs e)
        {
            SideForms.CustomMessageBox.ShowYesNo("Are you sure you want to exit", "Exiting Application",
                Resources.question, yesAction: () => Application.Exit());
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            SideForms.CustomMessageBox.ShowYesNo("Are you sure to clear all penalty fees?\nBy clicking yes means that the book has been returned today with the penalty fees settled.", "Confirmation",
                Resources.question, () => Functions.SettlePenaltyFees(datagridBooks));
        }

        private void btnPendingRequests_Click(object sender, EventArgs e)
        {
            if (Classes.CurrentUser.Role == "Librarian")
                Functions.SwitchForms(Forms.PendingRequests(), this);
            else
            {
                Functions.LoadData("LoadUserPendingRequest", datagridBooks, true);
                Functions.ShowControls(this, btnCancelRequest);
                Functions.HideControls(this, btnBorrow, btnReturn, btnAddBookmark, btnRemoveBookmark, btnConfirmPayment, btnViewBook, cmbbxGenre);
            }
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            Functions.SwitchForms(Forms.MembersInfo(), this);
        }

        private void picBxRefresh_Click(object sender, EventArgs e)
        {
            Worker.RunWorkerAsync();
        }

        private void btnCancelRequest_Click(object sender, EventArgs e)
        {
            SideForms.CustomMessageBox.ShowYesNo("Are you sure you want to cancel this request?", "Borrow Request Cancellation",
                Resources.question, () => Functions.ExecuteQuery("CancelRequest", new SqlParameter("@MemberID", Classes.CurrentUser.UserID)));
            Functions.LoadUser("LoadUserPendingRequest", datagridBooks);
        }

        #endregion

        #region NonClickEvents

        private void cmbbxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbxGenre.SelectedItem.ToString() == "All Books")
                Worker.RunWorkerAsync();
            else
                Functions.SortGenre(datagridBooks, cmbbxGenre, isBookmarks);
        }

        private void txtbxSearch_PlaceholderText(object sender, EventArgs e)
        {
            Functions.PlaceholderText(txtbxSearch, "Search for a book");
        }

        private void datagridBooks_BooksCount(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Functions.GetNumberOfBooks(datagridBooks, lblTotal);
        }

        private void datagridBooks_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Functions.GetNumberOfBooks(datagridBooks, lblTotal);
        }


        private void cmbbxGenre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion

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

    }
}
