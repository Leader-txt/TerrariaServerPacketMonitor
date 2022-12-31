using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 34)]
    [Table]
    internal class PacketPlaceChest : PacketModelBase
    {
        public static PacketPlaceChest Parse(byte[] data) => new();
    }
}
