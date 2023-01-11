using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 61)]
    [Table]
    internal class PacketSpawnBossorInvasion : PacketModelBase
    {
        public static PacketSpawnBossorInvasion Parse(byte[] data) => new();
    }
}
