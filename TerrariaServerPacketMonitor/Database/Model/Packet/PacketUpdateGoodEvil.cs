using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 57)]
    [Table]
    internal class PacketUpdateGoodEvil : PacketModelBase
    {
        public static PacketUpdateGoodEvil Parse(byte[] data) => new();
    }
}
