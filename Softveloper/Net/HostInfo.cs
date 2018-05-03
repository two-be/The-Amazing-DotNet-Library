using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace Softveloper.Net
{
    public static class HostInfo
    {
        public static string GetIpv4()
        {
            var hostName = Dns.GetHostName();
            return GetIpv4(hostName);
        }

        public static string GetIpv4(string hostName)
        {
            var hostInfo = Dns.GetHostEntry(hostName);
            var ipAddress = hostInfo.AddressList.FirstOrDefault(x => x.AddressFamily == AddressFamily.InterNetwork);
            return ipAddress?.ToString() ?? string.Empty;
        }
    }
}
