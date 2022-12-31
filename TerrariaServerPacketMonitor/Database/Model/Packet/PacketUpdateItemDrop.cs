using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 90)]
    [Table]
    internal class PacketUpdateItemDrop : PacketModelBase
    {
        public static PacketUpdateItemDrop Parse(byte[] data) => new();
    }
}
