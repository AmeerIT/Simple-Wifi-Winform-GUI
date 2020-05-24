using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleWifi;
using WifiAutoConnector.Classes;

namespace WifiAutoConnector
{
    public partial class frmMain : Form
    {
        private const string idleStatus = "Idle";
        private AccessPoint SelectedAccessPoint;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ConnectionManager.WifiInstance = new Wifi();

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
            ConnectionManager.Connect((AccessPoint)WifiList.SelectedItem);
        }

        private void WifiList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedAccessPoint = (AccessPoint)WifiList.SelectedItem;
        }

        private void networkStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ap = (AccessPoint)WifiList.SelectedItem;

            frmNetowkrStatus v = new frmNetowkrStatus(ap);
            v.ShowDialog();
        }
    }
}
