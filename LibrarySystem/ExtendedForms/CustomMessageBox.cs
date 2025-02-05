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

namespace LibrarySystem.SideForms
{
    public partial class CustomMessageBox : KryptonForm
    {
        Action _yesAction, _noAction, _okAction;       

        public CustomMessageBox(string messageText, string header, Image icon, Action yesAction = null,
            Action noAction = null, Action okAction = null, bool showYesNoButtons = true)
        {
            InitializeComponent();

            lblMessage.Text = messageText;
            lblHeader.Text = header;

            _yesAction = yesAction;
            _noAction = noAction;
            _okAction = okAction;

            btnYes.Visible = showYesNoButtons;
            btnNo.Visible = showYesNoButtons;
            btnOK.Visible = !showYesNoButtons;
            picbxIcon.Image = icon;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _okAction?.Invoke();
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            _yesAction?.Invoke();
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            _noAction?.Invoke();
            this.Close();
        }

        public static void ShowYesNo(string message, string header, Image icon, Action yesAction = null, Action noAction = null)
        {
            var messageBox = new CustomMessageBox(message, header, icon, yesAction: yesAction, noAction: noAction, showYesNoButtons: true);
            messageBox.ShowDialog();
        }

        public static void ShowOK(string message, string header, Image icon, Action okAction = null)
        {
            var messageBox = new CustomMessageBox(message, header, icon, okAction: okAction, showYesNoButtons: false);
            messageBox.ShowDialog();
        }
    }
}
