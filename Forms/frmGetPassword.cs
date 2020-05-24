using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WifiAutoConnector
{
    public partial class frmGetPassword : Form
    {
        public static string Password { get; set; }
        public static bool Canceled { get; set; }
        public frmGetPassword()
        {
            InitializeComponent();
        }

        private void frmGetPassword_Load(object sender, EventArgs e)
        {
            Canceled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Canceled = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Canceled = false;
            Password = txtPassword.Text;
            Close();
        }
    }
}
