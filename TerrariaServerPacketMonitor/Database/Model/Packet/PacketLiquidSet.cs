using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 48)]
    [Table]
    internal class PacketLiquidSet : PacketModelBase
    {
        public static PacketLiquidSet Parse(byte[] data) => new();
    }
}
