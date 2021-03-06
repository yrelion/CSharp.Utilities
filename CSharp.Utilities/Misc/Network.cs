using System.Linq;
using System.Net;

namespace CSharp.Utilities.Misc
{
    public static class Network
    {
        public static IPAddress GetIpv4Address()
        {
            var hostName = Dns.GetHostName();
            IPAddress[] addresses = Dns.GetHostEntry(hostName).AddressList;

            return addresses.FirstOrDefault(x => x.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
        }

        public static IPAddress GetIpv6Address()
        {
            var hostName = Dns.GetHostName();
            IPAddress[] addresses = Dns.GetHostEntry(hostName).AddressList;

            return addresses.FirstOrDefault(x => x.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6);
        }
    }
}
