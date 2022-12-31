using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 22)]
    [Table]
    internal class PacketItemOwner : PacketModelBase
    {
        public static PacketItemOwner Parse(byte[] data) => new();
    }
}
