﻿using System;
using System.Windows.Forms;
using SimpleWifi;
using WifiAutoConnector.Classes;

namespace WifiAutoConnector
{
    public partial class frmNetowkrStatus : Form
    {
        private AuthRequest AuthRequest;
        private readonly AccessPoint AccessPoint;

        public frmNetowkrStatus(AccessPoint accessPoint)
        {
            InitializeComponent();
            AccessPoint = accessPoint;
            AuthRequest = new AuthRequest(AccessPoint);
            Text = $"{accessPoint.Name} Status";
        }

        private void frmNetowkrStatus_Load(object sender, EventArgs e)
        {
            btnConnect.Enabled = !AccessPoint.IsConnected;
            name.Text = AccessPoint.Name;
            signalstrength.Text = $"{AccessPoint.SignalStrength}";
            prgss.Value = (int)AccessPoint.SignalStrength;
            connected.Text = AccessPoint.IsConnected ? Messages.Connected : Messages.Disconnected;
            passwordr.Text = AuthRequest.IsPasswordRequired ? Messages.Required : Messages.NotRequired;
            password.Text = AuthRequest.Password;

            usernamer.Text = AuthRequest.IsUsernameRequired ? Messages.Required : Messages.NotRequired;
            username.Text = AuthRequest.Username;

            domainr.Text = AuthRequest.IsDomainSupported ? Messages.Supported : Messages.NotSupported;
            domain.Text = AuthRequest.Domain;

            try
            {
                ConnectionManager.WifiInstance.ConnectionStatusChanged += (s, ea) =>
                {
                    // TODO FIX the error when the network status change while opening the window
                    /*
                    System.InvalidOperationException: 
                    'Invoke or BeginInvoke cannot be called on a control until 
                    the window handle has been created.'*/
                    Invoke((MethodInvoker)delegate
                    {
                        btnConnect.Enabled = ea.NewStatus.Equals(WifiStatus.Disconnected);
                        connected.Text = ea.NewStatus.Equals(WifiStatus.Connected) ? Messages.Connected : Messages.Disconnected;
                    });
                };
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //Bad example
            new frmGetPassword(AccessPoint).ShowDialog();
            if (frmGetPassword.Canceled)
                return;

            AuthRequest = frmGetPassword.AuthRequest;
            ConnectionManager.Connect(AccessPoint, AuthRequest);
        }
    }
}
