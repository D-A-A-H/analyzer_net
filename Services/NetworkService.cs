using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using NetworkAnalyzer.Models;

namespace NetworkAnalyzer.Services
{
    public class NetworkService
    {
        public List<NetworkInterfaceInfo> GetAllNetworkInterfaces()
        {
            var interfaces = new List<NetworkInterfaceInfo>();

            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.OperationalStatus != OperationalStatus.Up)
                    continue;

                var info = new NetworkInterfaceInfo
                {
                    Name = ni.Name,
                    Description = ni.Description,
                    Status = ni.OperationalStatus,
                    Speed = ni.Speed,
                    Type = ni.NetworkInterfaceType,
                    MacAddress = GetMacAddress(ni),
                    IpAddress = GetIpAddress(ni),
                    SubnetMask = GetSubnetMask(ni),
                    AddressType = GetAddressType(GetIpAddress(ni))
                };

                interfaces.Add(info);
            }

            return interfaces;
        }

        private string GetMacAddress(NetworkInterface ni)
        {
            byte[] bytes = ni.GetPhysicalAddress().GetAddressBytes();
            return string.Join(":", bytes.Select(b => b.ToString("X2")));
        }

        private string GetIpAddress(NetworkInterface ni)
        {
            foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
            {
                if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                    return ip.Address.ToString();
            }
            return "N/A";
        }

        private string GetSubnetMask(NetworkInterface ni)
        {
            foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
            {
                if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                    return ip.IPv4Mask.ToString();
            }
            return "N/A";
        }

        public string GetAddressType(string? ipAddress)
        {
            if (string.IsNullOrEmpty(ipAddress) || ipAddress == "N/A")
                return "Неизвестно";

            if (IPAddress.TryParse(ipAddress, out IPAddress? ip))
            {
                if (IPAddress.IsLoopback(ip))
                    return "Loopback";
                if (IsPrivateIp(ip))
                    return "Локальный (Private)";
                return "Публичный (Public)";
            }

            return "Неизвестно";
        }

        private bool IsPrivateIp(IPAddress ip)
        {
            byte[] bytes = ip.GetAddressBytes();

            if (bytes[0] == 10)
                return true;
            if (bytes[0] == 172 && bytes[1] >= 16 && bytes[1] <= 31)
                return true;
            if (bytes[0] == 192 && bytes[1] == 168)
                return true;

            return false;
        }

        public async Task<bool> PingHostAsync(string host, int timeout = 3000)
        {
            try
            {
                using (Ping ping = new Ping())
                {
                    PingReply reply = await ping.SendPingAsync(host, timeout);
                    return reply.Status == IPStatus.Success;
                }
            }
            catch
            {
                return false;
            }
        }

        public async Task<string[]> GetDnsInfoAsync(string host)
        {
            try
            {
                IPHostEntry entry = await Dns.GetHostEntryAsync(host);
                return entry.AddressList.Select(a => a.ToString()).ToArray();
            }
            catch
            {
                return new string[] { "DNS не найден" };
            }
        }
    }
}
