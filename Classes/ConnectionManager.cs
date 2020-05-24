using SimpleWifi;

namespace WifiAutoConnector.Classes
{
    public static class ConnectionManager
    {
        public static Wifi WifiInstance = new Wifi();
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
