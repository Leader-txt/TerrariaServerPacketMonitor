using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 64)]
    [Table]
    internal class PacketPaintWall : PacketModelBase
    {
        public static PacketPaintWall Parse(byte[] data) => new();
    }
}
