using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 80)]
    [Table]
    internal class PacketSyncPlayerChestIndex : PacketModelBase
    {
        public static PacketSyncPlayerChestIndex Parse(byte[] data) => new();
    }
}
