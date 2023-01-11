using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 134)]
    [Table]
    internal class PacketUpdatePlayerLuckFactors : PacketModelBase
    {
        public static PacketUpdatePlayerLuckFactors Parse(byte[] data) => new();
    }
}
