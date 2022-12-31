using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 147)]
    [Table]
    internal class PacketSyncLoadout : PacketModelBase
    {
        public static PacketSyncLoadout Parse(byte[] data) => new();
    }
}
