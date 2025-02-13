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
using libSys.Properties;

namespace LibrarySystem.FormsFolder
{
    public partial class MembersInfo : KryptonForm
    {
        public MembersInfo()
        {
            InitializeComponent();
        }

        private void MembersInfo_Load(object sender, EventArgs e)
        {
            Functions.LoadData("LoadMemberInfo", datagridMembers, false);
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Functions.SwitchForms(Forms.Dashboard(), this);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Functions.Search("SearchMember", txtbxSearch.Text, datagridMembers);
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            SideForms.CustomMessageBox.ShowYesNo("Are you sure you want to delete this member?", "Member Deletion",
                Resources.question, () => Functions.DeleteMember(datagridMembers));
        }

        private void txtbxSearch_PlaceholderText(object sender, EventArgs e)
        {
            Functions.PlaceholderText(txtbxSearch, "Search for a member");
        }

        private void txtbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtbxSearch.Text != "Search for a member")
                Functions.Search("SearchMember", txtbxSearch.Text, datagridMembers); 
        }
    }
}
