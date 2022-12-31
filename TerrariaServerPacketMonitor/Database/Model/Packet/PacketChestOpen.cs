using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 33)]
    [Table]
    internal class PacketChestOpen : PacketModelBase
    {
        public static PacketChestOpen Parse(byte[] data) => new();
    }
}
