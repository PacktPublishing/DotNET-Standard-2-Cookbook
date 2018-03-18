using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;

namespace Chapter7.Networking.ReadIPLib
{
    public class IPReader
    {
        public List<string> GetMyIPAddress()
        {
            var hostName = Dns.GetHostName();
            var hostAddress = Dns.GetHostAddresses(hostName);

            var ipList = new List<string>();

            foreach (var ipaddres in hostAddress)
            {
                if (ipaddres.AddressFamily == AddressFamily.InterNetwork)
                {
                    ipList.Add(ipaddres.ToString());
                }
            }

            return ipList;
        }
    }
}
