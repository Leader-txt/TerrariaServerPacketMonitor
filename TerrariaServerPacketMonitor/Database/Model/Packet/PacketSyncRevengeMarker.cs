using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 126)]
    [Table]
    internal class PacketSyncRevengeMarker : PacketModelBase
    {
        public static PacketSyncRevengeMarker Parse(byte[] data) => new();
    }
}
