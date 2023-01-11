using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 148)]
    [Table]
    internal class PacketSyncItemCannotBeTakenByEnemies : PacketModelBase
    {
        public static PacketSyncItemCannotBeTakenByEnemies Parse(byte[] data) => new();
    }
}
