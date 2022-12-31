using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 101)]
    [Table]
    internal class PacketUpdateShieldStrengths : PacketModelBase
    {
        public static PacketUpdateShieldStrengths Parse(byte[] data) => new();
    }
}
