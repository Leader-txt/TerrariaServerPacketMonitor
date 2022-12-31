using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 21)]
    [Table]
    internal class PacketItemDrop : PacketModelBase
    {
        public static PacketItemDrop Parse(byte[] data) => new();
    }
}
