using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 49)]
    [Table]
    internal class PacketPlayerSpawnSelf : PacketModelBase
    {
        public static PacketPlayerSpawnSelf Parse(byte[] data) => new();
    }
}
