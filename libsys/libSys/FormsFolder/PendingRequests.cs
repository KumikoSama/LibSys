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
    public partial class PendingRequests : KryptonForm
    {
        public PendingRequests()
        {
            InitializeComponent();
        }

        private void PendingRequests_Load(object sender, EventArgs e)
        {
            Functions.LoadPendingRequests(dataGridPendingRequests);
        }

        private void MembersInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Functions.SwitchForms(Forms.Dashboard(), this);
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            Functions.ApproveRequest(dueDateEstimation, dataGridPendingRequests);
        }

        private void txtBxBorrowDuration_TextChanged(object sender, EventArgs e)
        {
            Functions.DateChange(txtBxBorrowDuration, dueDateEstimation);
        }

        private void dataGridPendingRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Functions.PopulateRequestForm(dataGridPendingRequests, txtBxMemberName, txtBxBookName, txtbxCopies, txtBxBorrowDuration, dateRequested, lblRequestNum);
        }

        private void btnDeclinedRequests_Click(object sender, EventArgs e)
        {
            Functions.ClearTextBoxes(0, txtBxBookName, txtBxBorrowDuration, txtbxCopies, txtBxMemberName);
            Functions.LoadData("LoadDeclinedRequests", dataGridPendingRequests, false);
            Functions.ShowControls(this, btnAllPendingRequests);
            Functions.HideControls(this, btnDecline, btnApprove, btnDecline, dueDateEstimation, lblEstimatedDueDate, btnDeclinedRequests);

            lblPendingRequests.Text = "Declined Requests";
            dataGridPendingRequests.Columns["MemberID"].Visible = false;
            dataGridPendingRequests.Columns["BookID"].Visible = false;
            dataGridPendingRequests.Columns["RequestID"].Visible = false;
        }

        private void btnAllPendingRequests_Click(object sender, EventArgs e)
        {
            Functions.ClearTextBoxes(0, txtBxBookName, txtBxBorrowDuration, txtbxCopies, txtBxMemberName);
            Functions.LoadPendingRequests(dataGridPendingRequests);
            Functions.HideControls(this, btnAllPendingRequests);
            Functions.ShowControls(this, btnDecline, btnApprove, btnDecline, dueDateEstimation, lblEstimatedDueDate, btnDeclinedRequests);
            lblPendingRequests.Text = "Pending Requests";
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            Functions.DeclineRequest(dataGridPendingRequests);
        }
    }
}
