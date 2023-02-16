using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KennisDatabaseV1
{
    public partial class ImageViewer : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public ImageViewer()
        {
            InitializeComponent();
        }
        private static int _imageIndex = 0;
        /// <summary>
        ///  
        /// </summary>
        private void ImageViewer_Load(object sender, EventArgs e)
        {
            if (Form1.links.Count > 0)
            {
                string image = Form1.links[0];
                byte[] imageData = new WebClient().DownloadData(image);
                MemoryStream imgStream = new MemoryStream(imageData);
                Image img = Image.FromStream(imgStream);
                int wSize = img.Width;
                int hSize = img.Height;
                pictureBox1.Image = img;
                
                Height = hSize;
                Width = wSize;
            }
        }

        private void ClsBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        void loadnewimage()
        {
            if (Form1.links.Count > 0)
            {
                string image = Form1.links[_imageIndex];
                byte[] imageData = new WebClient().DownloadData(image);
                MemoryStream imgStream = new MemoryStream(imageData);
                Image img = Image.FromStream(imgStream);
                int wSize = img.Width;
                int hSize = img.Height;
                pictureBox1.Image = img;
                Height = hSize;
                Width = wSize;
            }
        }
        private void btnImgRight_Click(object sender, EventArgs e)
        {
            _imageIndex++;
            if (_imageIndex >= Form1.links.Count - 1)
            {
                _imageIndex = 0;
            }
            loadnewimage();
        }

        private void btnImgLeft_Click(object sender, EventArgs e)
        {
            _imageIndex--;
            if (_imageIndex < 0)
            {
                _imageIndex = Form1.links.Count - 1;
            }
            loadnewimage();
        }
    }
}
