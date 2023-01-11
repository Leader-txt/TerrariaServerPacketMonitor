using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 145)]
    [Table]
    internal class PacketSyncItemsWithShimmer : PacketModelBase
    {
        public static PacketSyncItemsWithShimmer Parse(byte[] data) => new();
    }
}
