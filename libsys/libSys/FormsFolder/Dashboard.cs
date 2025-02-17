using ComponentFactory.Krypton.Toolkit;
using LibrarySystem.Classes;
using libSys.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;

namespace LibrarySystem
{
    public partial class Dashboard : KryptonForm
    {
        bool isBookmarks = false;
        LoadedData currentDataLoaded = LoadedData.AllBooks;

        enum LoadedData
        {
            AllBooks,
            BorrowedBooks,
            Transactions,
            OverdueBooks,
            PendingRequests,
            Bookmarks
        }

        public Dashboard()
        {
            InitializeComponent();

            Functions.ExecuteQuery("UpdateOverdue");
            Functions.ExecuteQuery("UpdatePenaltyFees");
            Functions.CheckOverdue(this, btnBorrow);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (CurrentUser.Role == "Member")
                lblGreeting.Text = $"Welcome to the Bookmark Library, {CurrentUser.Username}!";

            cmbbxGenre.DataSource = LoadComboBox.Genres();
            Functions.ControlAccess(this, btnManage, btnBookmarks, btnBorrow, btnReturn, btnAddBookmark, btnRemoveBookmark, btnMembers);
            Functions.GetPopularBooks(new PictureBox[] { bookCoverOne, bookCoverTwo, bookCoverThree }, new Label[] { lblBookOne, lblBookTwo, lblBookThree });
        }

        #region NonClickEvents

        private void cmbbxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        #region ButtonClickEvents

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Functions.Search("SearchBook", txtbxSearch.Text, datagridBooks);
        }

        private void btnViewBook_Click(object sender, EventArgs e)
        {
            if (BookDetails.Instance == null) 
                Functions.BookDetails(datagridBooks);
            else
                BookDetails.Instance.BringToFront();
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
            currentDataLoaded = LoadedData.BorrowedBooks;

            Functions.LoadBorrowedBooks(datagridBooks, lblFormChange);
            Functions.HideControls(this, btnAddBookmark, btnRemoveBookmark, btnConfirmPayment, btnBorrow, btnViewBook, cmbbxGenre, btnCancelRequest, grpBxPopularBooks, txtbxSearch, btnSearch);

            if (CurrentUser.Role == "Member")
                Functions.ShowControls(this, btnReturn);

            datagridBooks.Columns["BookID"].Visible = false;
            datagridBooks.Columns["BorrowID"].Visible = false;
            lblFormChange.Location = new Point(154, 97);
        }

        private void btnAllBooks_Click(object sender, EventArgs e)
        {
            Worker.RunWorkerAsync();
            currentDataLoaded = LoadedData.AllBooks;
            isBookmarks = false;

            if (CurrentUser.Role == "Member")
            {
                Functions.HideControls(this, btnRemoveBookmark, btnConfirmPayment, btnReturn, btnCancelRequest, grpBxPopularBooks);
                Functions.ShowControls(this, btnAddBookmark, btnBorrow, btnViewBook, cmbbxGenre, txtbxSearch, btnSearch);
            }
            else
            {
                Functions.HideControls(this, btnAddBookmark, btnReturn, btnConfirmPayment, btnRemoveBookmark, btnBorrow, btnCancelRequest, grpBxPopularBooks);
                Functions.ShowControls(this, btnViewBook, cmbbxGenre, txtbxSearch, btnSearch);
            }

            lblFormChange.Text = "All Available Books";
            lblFormChange.Location = new Point(154, 69);
        }

        private void btnOverdueBooks_Click(object sender, EventArgs e)
        {
            currentDataLoaded = LoadedData.OverdueBooks;
            Functions.LoadOverdueBooks(datagridBooks, lblFormChange);

            if (CurrentUser.Role == "Member")
            {
                Functions.HideControls(this, btnAddBookmark, btnReturn, btnConfirmPayment, btnRemoveBookmark, btnBorrow, btnViewBook, cmbbxGenre, btnCancelRequest, grpBxPopularBooks, txtbxSearch, btnSearch);
                datagridBooks.Columns["FullName"].Visible = false;
            }
            else
            {
                Functions.HideControls(this, btnRemoveBookmark, btnReturn, btnBorrow, btnAddBookmark, btnViewBook, cmbbxGenre, grpBxPopularBooks, txtbxSearch, btnSearch);
                Functions.ShowControls(this, btnConfirmPayment);
            }

            datagridBooks.Columns["BookID"].Visible = false;
            datagridBooks.Columns["MemberID"].Visible = false;

            lblFormChange.Location = new Point(154, 97);
        }

        private void btnBookmarks_Click(object sender, EventArgs e)
        {
            isBookmarks = true;
            currentDataLoaded = LoadedData.Bookmarks;
            Functions.LoadData("LoadUserBookmarks", datagridBooks, true);

            Functions.HideControls(this, btnAddBookmark, btnReturn, btnConfirmPayment, btnCancelRequest, grpBxPopularBooks, txtbxSearch, btnSearch);
            Functions.ShowControls(this, btnRemoveBookmark, btnBorrow, btnViewBook, cmbbxGenre);

            lblFormChange.Text = "Bookmarked Books";
            lblFormChange.Location = new Point(154, 97);
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
            currentDataLoaded = LoadedData.Transactions;

            Functions.LoadTransactions(datagridBooks, lblFormChange);
            Functions.HideControls(this, btnAddBookmark, btnReturn, btnConfirmPayment, btnRemoveBookmark, btnBorrow, btnViewBook, cmbbxGenre, btnCancelRequest, grpBxPopularBooks, txtbxSearch, btnSearch);
            
            datagridBooks.Columns["BookID"].Visible = false;
            lblFormChange.Location = new Point(154, 97);
        }

        private void btnRemoveBookmark_Click(object sender, EventArgs e)
        {
            Functions.RemoveFromBookmarks(datagridBooks);
            Functions.LoadData("LoadUserBookmarks", datagridBooks, true);
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
            picBxRefresh_Click(sender, e);
        }

        private void btnPendingRequests_Click(object sender, EventArgs e)
        {
            currentDataLoaded = LoadedData.PendingRequests;

            if (CurrentUser.Role == "Member")
            {
                Functions.LoadData("LoadUserPendingRequest", datagridBooks, true);
                Functions.ShowControls(this, btnCancelRequest);
                Functions.HideControls(this, btnBorrow, btnReturn, btnAddBookmark, btnRemoveBookmark, btnConfirmPayment, btnViewBook, cmbbxGenre, grpBxPopularBooks, txtbxSearch, btnSearch);
            }
            else
                Functions.SwitchForms(Forms.PendingRequests(), this);

            datagridBooks.Columns["BookID"].Visible = false;
            lblFormChange.Location = new Point(154, 97);
            lblFormChange.Text = "Pending Requests";
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            Functions.SwitchForms(Forms.MembersInfo(), this);
        }

        private void picBxRefresh_Click(object sender, EventArgs e)
        {
            switch (currentDataLoaded)
            {
                case LoadedData.AllBooks:
                    Worker.RunWorkerAsync();
                    break;
                case LoadedData.BorrowedBooks:
                    Functions.LoadBorrowedBooks(datagridBooks, lblFormChange);
                    break;
                case LoadedData.Transactions:
                    Functions.LoadTransactions(datagridBooks, lblFormChange);
                    break;
                case LoadedData.Bookmarks:
                    Functions.LoadData("LoadUserBookmarks", datagridBooks, true);
                    break;
                case LoadedData.PendingRequests:
                    Functions.LoadData("LoadUserPendingRequest", datagridBooks, true);
                    break;
                case LoadedData.OverdueBooks:
                    Functions.LoadOverdueBooks(datagridBooks, lblFormChange);
                    break;
                default:
                    Worker.RunWorkerAsync();
                    break;
            }
        }

        private void btnCancelRequest_Click(object sender, EventArgs e)
        {
            SideForms.CustomMessageBox.ShowYesNo("Are you sure you want to cancel this request?", "Borrow Request Cancellation",
                Resources.question, () => Functions.ExecuteQuery("CancelRequest", new SqlParameter("@MemberID", CurrentUser.UserID)));

            Functions.LoadData("LoadUserPendingRequest", datagridBooks, true);
        }

        private void pctrbxLogo_Click(object sender, EventArgs e)
        {
            grpBxPopularBooks.Visible = true;
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
