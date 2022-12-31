using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 36)]
    [Table]
    internal class PacketZones : PacketModelBase
    {
        public static PacketZones Parse(byte[] data) => new();
    }
}
