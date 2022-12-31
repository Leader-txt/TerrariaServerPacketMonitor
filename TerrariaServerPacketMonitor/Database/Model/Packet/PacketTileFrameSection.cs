using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 11)]
    [Table]
    internal class PacketTileFrameSection : PacketModelBase
    {
        public static PacketTileFrameSection Parse(byte[] data) => new();
    }
}
