using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 20)]
    [Table]
    internal class PacketTileSendSquare : PacketModelBase
    {
        public static PacketTileSendSquare Parse(byte[] data) => new();
    }
}
