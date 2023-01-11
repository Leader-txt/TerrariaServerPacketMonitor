using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 94)]
    [Table]
    internal class PacketDeprecated : PacketModelBase
    {
        public static PacketDeprecated Parse(byte[] data) => new();
    }
}
