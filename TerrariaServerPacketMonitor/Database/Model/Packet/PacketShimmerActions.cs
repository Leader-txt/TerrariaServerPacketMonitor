using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 146)]
    [Table]
    internal class PacketShimmerActions : PacketModelBase
    {
        public static PacketShimmerActions Parse(byte[] data) => new();
    }
}
