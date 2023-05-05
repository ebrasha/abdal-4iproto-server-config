using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Abdal_Proxy_Bridge
{
    internal class CheckForInternetConnection
    {
        public static bool InternetCheck()
        {
            try
            {
                Console.Write("-> Checking the Internet ");
                if (NetworkInterface.GetIsNetworkAvailable() &&
                    new Ping().Send(new IPAddress(new byte[] { 8, 8, 8, 8 }), 5000).Status == IPStatus.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}