using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaServerPacketMonitor
{
    internal class Packet
    {
        public string Name { get; set; }
        public PacketTypes Type { get; set; }
        public long Count { get; set; }
        public long TotalBytes { get; set; }
    }
    internal class Analyze
    {
        public long TotalPackets { get; set; }
        public long TotalBytes { get; set; }
        public long ReceivePackets { get; set; }
        public long ReceiveBytes { get; set; }
        public long SendPackets { get; set; }
        public long SendBytes { get; set; }
        public Packet[] Send { get; set; }
        public Packet[] Receive { get; set; }
    }
}
