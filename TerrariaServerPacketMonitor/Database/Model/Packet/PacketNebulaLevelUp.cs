using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 102)]
    [Table]
    internal class PacketNebulaLevelUp : PacketModelBase
    {
        public static PacketNebulaLevelUp Parse(byte[] data) => new();
    }
}
