using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 46)]
    [Table]
    internal class PacketSignRead : PacketModelBase
    {
        public static PacketSignRead Parse(byte[] data) => new();
    }
}
