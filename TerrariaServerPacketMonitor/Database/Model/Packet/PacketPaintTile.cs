using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 63)]
    [Table]
    internal class PacketPaintTile : PacketModelBase
    {
        public static PacketPaintTile Parse(byte[] data) => new();
    }
}
