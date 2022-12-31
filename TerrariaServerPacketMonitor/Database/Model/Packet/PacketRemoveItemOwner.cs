using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 39)]
    [Table]
    internal class PacketRemoveItemOwner : PacketModelBase
    {
        public static PacketRemoveItemOwner Parse(byte[] data) => new();
    }
}
