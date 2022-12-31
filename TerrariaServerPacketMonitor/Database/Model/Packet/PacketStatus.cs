using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 9)]
    [Table]
    internal class PacketStatus : PacketModelBase
    {
        public static PacketStatus Parse(byte[] data) => new();
    }
}
