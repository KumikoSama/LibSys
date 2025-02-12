using ComponentFactory.Krypton.Toolkit;
using LibrarySystem.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibrarySystem
{
    public partial class BookDetails : KryptonForm
    {
        public static BookDetails Instance { get; private set; } = null;

        public BookDetails(string bookDescription, string bookTitle, string bookAuthor, Image image)
        {
            InitializeComponent();

            kryptonGroupBox1.CaptionVisible = false;
            Instance = this;

            picbxBookCover.Image = image;
            lblBookTitle.Text = bookTitle;
            lblBookAuthor.Text = bookAuthor;
            txtbxBookDesc.Text = bookDescription;
            txtbxBookDesc.SelectAll();
            txtbxBookDesc.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void BookDetails_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Instance = null;
        }
    }
}
