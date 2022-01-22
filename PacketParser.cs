namespace sharpdhcp
{
    public static class PacketParser
    {
        public static DhcpHeaderPacket ParseHeader(byte[] data)
        {
            return new DhcpHeaderPacket()
            {
                Op = data[0],
                Htype = data[1],
                Hlen = data[2],
                Hops = data[3],
                Xid = data[4..8],
                Secs = data[8..10],
                Flags = data[10..12],
                Ciaddr = data[12..16],
                Yiaddr = data[16..20],
                Siaddr = data[20..24],
                Giaddr = data[24..28],
                Chaddr = data[28..44],
                Sname = data[44..108],
                File = data[108..236],
                MagicCookie = data[236..240]
            };
        }
    }
}