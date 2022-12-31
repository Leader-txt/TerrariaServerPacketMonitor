using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 56)]
    [Table]
    internal class PacketUpdateNPCName : PacketModelBase
    {
        public static PacketUpdateNPCName Parse(byte[] data) => new();
    }
}
