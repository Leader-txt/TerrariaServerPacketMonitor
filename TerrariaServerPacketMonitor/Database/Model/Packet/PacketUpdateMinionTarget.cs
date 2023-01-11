using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 99)]
    [Table]
    internal class PacketUpdateMinionTarget : PacketModelBase
    {
        public static PacketUpdateMinionTarget Parse(byte[] data) => new();
    }
}
