using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 23)]
    [Table]
    internal class PacketNpcUpdate : PacketModelBase
    {
        public static PacketNpcUpdate Parse(byte[] data) => new();
    }
}
