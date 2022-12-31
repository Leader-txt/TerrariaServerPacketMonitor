using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 138)]
    [Table]
    internal class PacketClientSyncedInventory : PacketModelBase
    {
        public static PacketClientSyncedInventory Parse(byte[] data) => new();
    }
}
