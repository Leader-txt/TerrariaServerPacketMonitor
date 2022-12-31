using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 1)]
    [Table]
    internal class PacketConnectRequest : PacketModelBase
    {
        public static PacketConnectRequest Parse(byte[] data) => new();
    }
}
