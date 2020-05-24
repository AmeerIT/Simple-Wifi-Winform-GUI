using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SimpleWifi;

namespace WifiAutoConnector.Classes
{
    public static class ConnectionManager
    {
        public static Wifi WifiInstance;
        public static void Connect(AccessPoint accessPoint)
        {
            //Bad example
            var t = new frmGetPassword().ShowDialog();
            if (frmGetPassword.Canceled)
                return;

            var AuthRequest = new AuthRequest(accessPoint);
            AuthRequest.Password = frmGetPassword.Password;
            accessPoint.ConnectAsync(AuthRequest);
        }
    }
}
