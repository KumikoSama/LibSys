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
        string bookDescription, bookTitle, bookAuthor;
        Image image;

        public BookDetails(string bookDescription, string bookTitle, string bookAuthor, Image image)
        {
            InitializeComponent();
            this.bookDescription = bookDescription;
            this.bookTitle = bookTitle;
            this.bookAuthor = bookAuthor;
            this.image = image;
            Instance = this;
        }

        private void BookDetails_Load(object sender, EventArgs e)
        {
            Functions.DisplayBookDetails(picbxBookCover, lblBookTitle, lblBookAuthor, txtbxBookDesc, image,
                bookTitle, bookAuthor, bookDescription);
            kryptonGroupBox1.CaptionVisible = false;
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
