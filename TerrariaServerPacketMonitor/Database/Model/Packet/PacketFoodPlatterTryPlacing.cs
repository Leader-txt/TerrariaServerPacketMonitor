using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 133)]
    [Table]
    internal class PacketFoodPlatterTryPlacing : PacketModelBase
    {
        public static PacketFoodPlatterTryPlacing Parse(byte[] data) => new();
    }
}
