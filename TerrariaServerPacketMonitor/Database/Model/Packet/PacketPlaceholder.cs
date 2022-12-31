using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 67)]
    [Table]
    internal class PacketPlaceholder : PacketModelBase
    {
        public static PacketPlaceholder Parse(byte[] data) => new();
    }
}
