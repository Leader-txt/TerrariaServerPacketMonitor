using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 136)]
    [Table]
    internal class PacketSyncCavernMonsterType : PacketModelBase
    {
        public static PacketSyncCavernMonsterType Parse(byte[] data) => new();
    }
}
