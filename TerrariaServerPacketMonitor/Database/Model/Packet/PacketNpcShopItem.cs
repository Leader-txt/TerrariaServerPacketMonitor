using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 104)]
    [Table]
    internal class PacketNpcShopItem : PacketModelBase
    {
        public static PacketNpcShopItem Parse(byte[] data) => new();
    }
}
