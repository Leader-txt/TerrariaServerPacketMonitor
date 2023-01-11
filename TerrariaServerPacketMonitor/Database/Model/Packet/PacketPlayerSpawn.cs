using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 12)]
    [Table]
    internal class PacketPlayerSpawn : PacketModelBase
    {
        public static PacketPlayerSpawn Parse(byte[] data) => new();
    }
}
