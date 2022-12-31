using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 14)]
    [Table]
    internal class PacketPlayerActive : PacketModelBase
    {
        public static PacketPlayerActive Parse(byte[] data) => new();
    }
}
