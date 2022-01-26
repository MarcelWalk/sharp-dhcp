namespace sharpdhcp
{
    public class Program
    {
        static void Main(string[] args)
        {
            MainAsync().GetAwaiter().GetResult();
        }

        static async Task MainAsync()
        {
            Server s = new Server();
            s.MessageReceived += MessageReceived;
            await s.StartListener();
            await Task.Delay(-1);
        }

        static string ToIp(byte[] data)
        {
            return $"{data[0]}.{data[1]}.{data[2]}.{data[3]}";
        }

        static void MessageReceived(object sender, MessageReceivedArgs args)
        {
            Console.WriteLine(args.Endpoint.Address.ToString());
            var dhcpHeaderPacket = PacketParser.ParsePackage(args.Data);
            System.Console.WriteLine($"OP: {dhcpHeaderPacket.Op}");
            System.Console.WriteLine($"HTYPE: {dhcpHeaderPacket.Htype}");
            System.Console.WriteLine($"HLEN: {dhcpHeaderPacket.Hlen}");
            System.Console.WriteLine($"HOPS: {dhcpHeaderPacket.Hops}");
            System.Console.WriteLine($"XID: {BitConverter.ToUInt32(dhcpHeaderPacket.Xid, 0)}");
            System.Console.WriteLine($"SECS: {BitConverter.ToUInt16(dhcpHeaderPacket.Secs, 0)}");
            System.Console.WriteLine($"FLAGS: {BitConverter.ToUInt16(dhcpHeaderPacket.Flags, 0)}");
            System.Console.WriteLine($"CIADDR: {ToIp(dhcpHeaderPacket.Ciaddr)}");
            System.Console.WriteLine($"YIADDR: {ToIp(dhcpHeaderPacket.Yiaddr)}");
            System.Console.WriteLine($"SIADDR: {ToIp(dhcpHeaderPacket.Siaddr)}");
            System.Console.WriteLine($"GIADDR: {ToIp(dhcpHeaderPacket.Giaddr)}");
            System.Console.WriteLine($"CHADDR: {BitConverter.ToString(dhcpHeaderPacket.Chaddr.Where(x=>x != 0).ToArray()).Replace('-',':')}");
            System.Console.WriteLine($"SNAME: {System.Text.Encoding.Default.GetString(dhcpHeaderPacket.Sname)}");
            System.Console.WriteLine($"FILE: {System.Text.Encoding.Default.GetString(dhcpHeaderPacket.File)}");
            System.Console.WriteLine($"COOKIE: {BitConverter.ToUInt32(dhcpHeaderPacket.MagicCookie)}");
            System.Console.WriteLine($"OPT: {args.Data[240..].Select(x => x.ToString()).Aggregate((a, b) => a + " " + b)}");
        }
    }
}