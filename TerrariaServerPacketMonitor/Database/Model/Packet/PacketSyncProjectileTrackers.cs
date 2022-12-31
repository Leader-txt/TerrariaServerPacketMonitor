using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 142)]
    [Table]
    internal class PacketSyncProjectileTrackers : PacketModelBase
    {
        public static PacketSyncProjectileTrackers Parse(byte[] data) => new();
    }
}
