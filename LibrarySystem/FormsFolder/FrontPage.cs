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
    public partial class FrontPage : KryptonForm
    {
        Validator validator;

        public FrontPage()
        {
            InitializeComponent();
        }

        private void exitbtnapp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkSignup_LinkClicked(object sender, EventArgs e)
        {
            Functions.SwitchForms(Forms.RegistrationForm(), this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Functions.Login(this, txtbxContactMethod, txtbxPassword, cmbbxStudentAdmin, errorTxtBxContactMethod, errorPassword);
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
    }
}
