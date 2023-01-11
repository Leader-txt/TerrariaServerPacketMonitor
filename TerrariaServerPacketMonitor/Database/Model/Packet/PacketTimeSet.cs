using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 18)]
    [Table]
    internal class PacketTimeSet : PacketModelBase
    {
        public static PacketTimeSet Parse(byte[] data) => new();
    }
}
