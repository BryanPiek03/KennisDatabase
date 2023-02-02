﻿using System;
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


        private static int NavWidth = 60;
        private static bool expand = true;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        public Form1()
        {
            InitializeComponent();
            NavMenuPnl.Size = new Size(NavWidth, NavMenuPnl.Height);
            SearchbarTxt.Hide();
            NavMenuLBox.Hide();
        }

        private void ClsBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void HamburgerBtn_Click(object sender, EventArgs e)
        {

            NavMoveTimer.Enabled = true;
            NavMoveTimer.Start();

            if (NavMenuPnl.Size.Width == NavWidth)
            {
                SearchbarTxt.Show();
                NavMenuLBox.Show();
            }

        }

        private void ReloadBtn_Click(object sender, EventArgs e)
        {

            Application.Restart();

        }

        private void NavMoveTimer_Tick(object sender, EventArgs e)
        {

            

            if (expand)
            {
                // expand the panel
                if (NavMenuPnl.Width < 480)
                {
                    NavMenuPnl.Width += 2;
                }
                else
                {
                    expand = false;
                    NavMoveTimer.Stop();
                }
            }
            else
            {
                // shrink the panel
                if (NavMenuPnl.Width > 60)
                {
                    NavMenuPnl.Width -= 2;
                }
                else
                {
                    expand = true;
                    NavMoveTimer.Stop();
                    SearchbarTxt.Hide();
                    NavMenuLBox.Hide();
                }
            }

        }
    }
}