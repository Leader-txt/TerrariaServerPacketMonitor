using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 8)]
    [Table]
    internal class PacketTileGetSection : PacketModelBase
    {
        public static PacketTileGetSection Parse(byte[] data) => new();
    }
}
