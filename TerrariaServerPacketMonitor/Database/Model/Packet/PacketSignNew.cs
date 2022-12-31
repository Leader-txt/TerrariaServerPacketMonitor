using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 47)]
    [Table]
    internal class PacketSignNew : PacketModelBase
    {
        public static PacketSignNew Parse(byte[] data) => new();
    }
}
