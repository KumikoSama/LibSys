using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using LibrarySystem.Classes;

namespace LibrarySystem
{
    public partial class BorrowBook : KryptonForm
    {
        string title;
        int bookID;

        public BorrowBook(string title, int bookID)
        {
            InitializeComponent();
            this.title = title;
            this.bookID = bookID;
        }

        private void BorrowBook_Load(object sender, EventArgs e)
        {
            Worker.RunWorkerAsync();
            txtbxBookTitle.Text = title;
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            Functions.InsertToPendingRequests(bookID, cmbbxBorrowDuration.SelectedItem.ToString(), cmbbxCopies.SelectedItem.ToString());
            Functions.SwitchForms(Forms.Dashboard(), this);
        }

        private void datagridBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridBooks.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedrow = datagridBooks.SelectedRows[0];
                txtbxBookTitle.Text = selectedrow.Cells["Title"].Value.ToString();
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Functions.SwitchForms(Forms.Dashboard(), this);
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
            {
                MessageBox.Show("Error loading books: " + e.Error.Message);
            }
        }
        #endregion
    }
}
