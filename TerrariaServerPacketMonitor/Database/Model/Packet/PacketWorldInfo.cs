using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 7)]
    [Table]
    internal class PacketWorldInfo : PacketModelBase
    {
        public static PacketWorldInfo Parse(byte[] data) => new();
    }
}
