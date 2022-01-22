namespace sharpdhcp
{
    public class DhcpHeaderPacket
    {
        public byte Op { get; set; }
        public byte Htype { get; set; }
        public byte Hlen { get; set; }
        public byte Hops { get; set; }
        public byte[] Xid { get; set; } = new byte[4];
        public byte[] Secs { get; set; } = new byte[2];
        public byte[] Flags { get; set; } = new byte[2];
        public byte[] Ciaddr { get; set; } = new byte[4];
        public byte[] Yiaddr { get; set; } = new byte[4];
        public byte[] Siaddr { get; set; } = new byte[4];
        public byte[] Giaddr { get; set; } = new byte[4];
        public byte[] Chaddr { get; set; } = new byte[16];
        public byte[] Sname { get; set; } = new byte[64]; // Overflow
        public byte[] File { get; set; } = new byte[128]; // Overflow
        public byte[] MagicCookie { get; set; } = new byte[4];

        public enum DhcpOptionFlags : ushort
        {
            Pad = 0,
            End = 255,
            SubnetMask = 1,
            TimeOffset = 2,
            Router = 3,
            TimeServer = 4,
            NameServer = 5,
            DomainServer = 6,
            LogServer = 7,
            CookieServer = 8,
            LRPServer = 9,
            ImpressServer = 10,
            ResourceLocationServer = 11,
            HostName = 12,
            BootFileSize = 13,
            MeritDumpFile = 14,
            DomainName = 15,
            SwapServer = 16,
            RootPath = 17,
            ExtensionsPAth = 18,
            IPForwarding = 19,
            NonLocalSourceRouting = 20,
            PolicyFilter = 21,
            MaximumDatagramReassemblySize = 22,
            DefaultIPTTL = 23,
            PathMTUAgingTimeout = 24,
            PathMTUPlateauTable = 25,
            InterfaceMTU = 26,
            AllSubnetsLocal = 27,
            BroadcastAddress = 28,
            PerformMaskDiscovery = 29,
            MaskSupplier = 30,
            PerformRouterDiscovery = 31,
            RouterSolicitationAddress = 32,
            StaticRoute = 33,
            TrailerEncapsulation = 34,
            ARPChache = 35,
            EthernetEncapsulation = 36,
            TCPDefaultTTL = 37,
            TCPKeepAliveInterval = 38,
            TCPKeepAliveGarbage = 39,
            NetworkInformationServiceDomain = 40,
            NetworkInformationServers = 41,

        }
    }
}