using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using ComponentFactory.Krypton.Toolkit;
using LibrarySystem.Classes;

namespace LibrarySystem
{
    public partial class RegistrationForm : KryptonForm
    {
        public RegistrationForm()
        {
            InitializeComponent();
            LoadComboBox.LoadCountryCodes(cmbbxCountryCode);
            cmbbxGender.DataSource = LoadComboBox.Gender();
            cmbbxContactMethod.DataSource = LoadComboBox.ContactMethod();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            Functions.CenteredPanels(this, secondPanel, firstPanel);
        }

        private void exitbtnapp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Functions.CenteredPanels(this, firstPanel, secondPanel);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Functions.CenteredPanels(this, secondPanel, firstPanel);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Functions.Register(this, (new KryptonComboBox[] { cmbbxAge, cmbbxGender, cmbbxContactMethod },
                new KryptonTextBox[] { txtbxFname, txtbxLname, txtbxUsername, txtbxPassword, txtbxContactMethod, txtbxCode },
                new Label[] { errorFname, errorLname, errorCmbBxAge, errorCmbBxGender, errorTxtBxContactMethod, errorUsername, errorPassword }));
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Functions.SwitchForms(Forms.FrontPage(), this);
        }

        private void txtbxname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true; // Stop the character from being entered
        }

        private void txtbxContactMethod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbbxContactMethod.SelectedItem.ToString() == "Phone Number")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                    e.Handled = true;
                else if (char.IsDigit(e.KeyChar) && txtbxContactMethod.Text.Length >= 10)
                    e.Handled = true;
            }
        }

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            Functions.ShowControls(this, btnHidePassword);
            Functions.HideControls(this, btnShowPassword);
            txtbxPassword.PasswordChar = '\0';
        }

        private void btnHidePassword_Click(object sender, EventArgs e)
        {
            Functions.ShowControls(this, btnShowPassword);
            Functions.HideControls(this, btnHidePassword);
            txtbxPassword.PasswordChar = '●';
        }

        private void cmbbxCountryCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            Country code = cmbbxCountryCode.SelectedItem as Country;
            txtbxCode.Text = code.Code;
        }

        private void cmbbxContactMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            Functions.ContactMethod(cmbbxContactMethod, cmbbxCountryCode, lblEmailorPhone, txtbxContactMethod, txtbxCode);
            txtbxContactMethod.Clear();
        }

        private void txtbxPassword_TextChanged(object sender, EventArgs e)
        {
            Functions.PasswordRequirements(txtbxPassword, chckBxFirstRequirement, chckBxSecondRequirement, chckBxThirdRequirement);
        }

        private void checkBoxCheck_Click(object sender, EventArgs e)
        {
            KryptonCheckBox checkBox = sender as KryptonCheckBox;
            checkBox.Checked = !checkBox.Checked;
        }
    }
}
