namespace sharpdhcp
{
    public class DhcpPacket
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
        public byte[]? Options { get; set; }

        public enum DhcpOptionFlags : ushort
        {
           
        }
    }
}