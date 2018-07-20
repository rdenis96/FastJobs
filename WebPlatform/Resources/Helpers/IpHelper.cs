using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace WebPlatform.Resources.Helpers
{
    public static class IpHelper
    {
        public static string GetIpAddress()  // Get IP Address
        {
            string strHostName = Dns.GetHostName();
            string clientIPAddress = Dns.GetHostAddresses(strHostName).GetValue(1).ToString();
            return clientIPAddress;
        }

        public static string GetCompCode()  // Get Computer Name
        {
            string strHostName = "";
            strHostName = Dns.GetHostName();
            return strHostName;
        }
    }
}