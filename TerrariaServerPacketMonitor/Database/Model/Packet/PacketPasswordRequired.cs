using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 37)]
    [Table]
    internal class PacketPasswordRequired : PacketModelBase
    {
        public static PacketPasswordRequired Parse(byte[] data) => new();
    }
}
