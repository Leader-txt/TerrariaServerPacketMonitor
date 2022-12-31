using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 132)]
    [Table]
    internal class PacketPlayLegacySound : PacketModelBase
    {
        public static PacketPlayLegacySound Parse(byte[] data) => new();
    }
}
