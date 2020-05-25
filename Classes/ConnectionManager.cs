using SimpleWifi;

namespace WifiAutoConnector.Classes
{
    public static class ConnectionManager
    {
        public static Wifi WifiInstance = new Wifi();
        public static void Connect(AccessPoint accessPoint, AuthRequest authRequest)
        {
            accessPoint.ConnectAsync(authRequest);
        }
    }
}
