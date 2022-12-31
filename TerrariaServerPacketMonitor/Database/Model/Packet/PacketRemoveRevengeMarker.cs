using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 127)]
    [Table]
    internal class PacketRemoveRevengeMarker : PacketModelBase
    {
        public static PacketRemoveRevengeMarker Parse(byte[] data) => new();
    }
}
