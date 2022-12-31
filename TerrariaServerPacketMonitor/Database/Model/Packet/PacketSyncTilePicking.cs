using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 125)]
    [Table]
    internal class PacketSyncTilePicking : PacketModelBase
    {
        public static PacketSyncTilePicking Parse(byte[] data) => new();
    }
}
