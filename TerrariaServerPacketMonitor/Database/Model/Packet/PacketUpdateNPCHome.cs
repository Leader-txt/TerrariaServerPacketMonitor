using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 60)]
    [Table]
    internal class PacketUpdateNPCHome : PacketModelBase
    {
        public static PacketUpdateNPCHome Parse(byte[] data) => new();
    }
}
