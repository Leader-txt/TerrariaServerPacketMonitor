using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 77)]
    [Table]
    internal class PacketCreateTemporaryAnimation : PacketModelBase
    {
        public static PacketCreateTemporaryAnimation Parse(byte[] data) => new();
    }
}
