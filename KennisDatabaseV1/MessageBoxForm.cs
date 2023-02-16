using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KennisDatabaseV1
{
    public partial class MessageBoxForm : Form
    {

        public string messageText { get; set; }


        public MessageBoxForm()
        {
            InitializeComponent();
        }

        private void MessageBoxForm_Load(object sender, EventArgs e)
        {
            MessageBoxTxt.Text = messageText;
            MessageBoxTxt.ForeColor = Color.Black;

            MessageBoxTxt.SelectionLength = 0;
        }

    }
}
