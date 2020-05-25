using System;
using System.Windows.Forms;
using SimpleWifi;

namespace WifiAutoConnector
{
    public partial class frmGetPassword : Form
    {
        public static AuthRequest AuthRequest { get; private set; }

        public static bool Canceled { get; set; } = true;
        public frmGetPassword(AccessPoint accessPoint)
        {
            InitializeComponent();
            AuthRequest = new AuthRequest(accessPoint);
            txtusername.Enabled = AuthRequest.IsUsernameRequired;
            txtPassword.Enabled = AuthRequest.IsPasswordRequired;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Canceled = false;
            if (AuthRequest.IsUsernameRequired)
                AuthRequest.Username = txtusername.Text;

            AuthRequest.Password = txtPassword.Text;
            Close();
        }
    }
}
