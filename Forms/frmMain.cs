using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleWifi;
using WifiAutoConnector.Classes;

namespace WifiAutoConnector
{
    public partial class frmMain : Form
    {
        private AccessPoint SelectedAccessPoint;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Simple one liner Enable/Disable btnConnect
            ConnectionManager.WifiInstance.ConnectionStatusChanged += (s, ea) =>
            {
                Invoke((MethodInvoker)delegate
                {
                    btnConnect.Enabled = ea.NewStatus == WifiStatus.Disconnected;
                });
            };
        }

        private async Task ListAccessPoints()
        {
            lblstatus.Text = "Scanning for wifi networks, please wait...";
            WifiList.DataSource = await Task.Factory.StartNew(() =>
            {
                return ConnectionManager.WifiInstance.GetAccessPoints().ToList();
            });
            WifiList.DisplayMember = nameof(AccessPoint.Name);
            lblstatus.Text = "Enumeration finsihed";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            btnRefresh.Enabled = false;
            await ListAccessPoints();
            btnRefresh.Enabled = true;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //Bad example
            new frmGetPassword(SelectedAccessPoint).ShowDialog();
            if (frmGetPassword.Canceled)
                return;

            var authReq = frmGetPassword.AuthRequest;
            ConnectionManager.Connect(SelectedAccessPoint, authReq);
        }

        private void WifiList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedAccessPoint = (AccessPoint)WifiList.SelectedItem;
        }

        private void networkStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmNetowkrStatus(SelectedAccessPoint).ShowDialog();
        }
    }
}
