using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 17)]
    [Table]
    internal class PacketTile : PacketModelBase
    {
        public static PacketTile Parse(byte[] data) => new();
    }
}
