using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KennisDatabaseV1
{
    public partial class Form1 : Form
    {

        //Set the width as an int for the the collapsed nav panel
        private static int NavWidthSmall = 60;
        //Set the width as an int for the the uncollapsed nav panel
        private static int NavWidthBig = 60;

        // Importing the ReleaseCapture method from the user32.dll library
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        // Importing the SendMessage method from the user32.dll library
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        //Als muis ingedrukt is op label1 (de titel)
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            // Calls the ReleaseCapture method from the user32.dll library
            ReleaseCapture();

            // Sends a message to the window handle specified in the Handle property
            // with the message 0x112, wParam 0xf012, and lParam 0
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //When Form1 loads.
        public Form1()
        {
            InitializeComponent();
            //Set the Size of the NavMenuPnl to the collapsed size.
            NavMenuPnl.Size = new Size(NavWidthSmall, NavMenuPnl.Height);
            //Hide the searchbar.
            SearchbarTxt.Hide();
            //Hide the ListBox.
            NavMenuLBox.Hide();
        }

        //When ClsBtn is clicked.
        private void ClsBtn_Click(object sender, EventArgs e)
        {
            //Close application.
            Application.Exit();
        }

        //When MinBtn is clicked.
        private void MinBtn_Click(object sender, EventArgs e)
        {
            //Set the window state to minimized.
            this.WindowState = FormWindowState.Minimized;
        }

        //When the HamburgerBtn (Nav Menu btn) is clicked.
        private void HamburgerBtn_Click(object sender, EventArgs e)
        {
            //Check current with of the NavMenuPnl.
            //If it has the small panel size
            if (NavMenuPnl.Size.Width == NavWidthSmall)
            {
                //Show the SearchBar
                SearchbarTxt.Show();
                //Show the ListBox.
                NavMenuLBox.Show();
                //Set the panel size to the uncollapsed version.
                NavMenuPnl.Size = new Size(NavWidthBig, NavMenuPnl.Height);
            }
            //If the size is bigger than the small panel size
            else
            {
                //Hide the searchbar.
                SearchbarTxt.Hide();
                //Hide the ListBox.
                NavMenuLBox.Hide();
                //Sets the panel size to the uncollapsed version/
                NavMenuPnl.Size = new Size(NavWidthSmall, NavMenuPnl.Height);
            }

        }

        //When reloadBtn is clicked.
        private void ReloadBtn_Click(object sender, EventArgs e)
        {
            //Restart application.
            Application.Restart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }
    }
}
