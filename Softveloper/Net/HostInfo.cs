using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Softveloper.Net
{
    public class HostInfo
    {
        public static string GetIpAddressV4()
        {
            var hostName = Dns.GetHostName();
            return GetIpAddressV4(hostName);
        }

        public static string GetIpAddressV4(string hostName)
        {
            var hostInfo = Dns.GetHostEntry(hostName);
            var ipAddress = hostInfo.AddressList.FirstOrDefault(x => x.AddressFamily == AddressFamily.InterNetwork);
            return ipAddress?.ToString() ?? string.Empty;
        }
    }
}
