using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace LibrarySystem.SideForms
{
    public partial class LoadingScreen : KryptonForm
    {
        readonly Image loadingGif;

        public LoadingScreen()
        {
            InitializeComponent();

            loadingGif = Image.FromFile(@"C:\Users\DELL\Downloads\Cats Memes GIF - Cats Cat Memes - Descubrir y compartir GIFs(2).gif");
            pictureBox1.Image = loadingGif;
        }
    }
}
