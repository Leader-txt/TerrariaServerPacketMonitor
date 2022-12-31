using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 38)]
    [Table]
    internal class PacketPasswordSend : PacketModelBase
    {
        public static PacketPasswordSend Parse(byte[] data) => new();
    }
}
