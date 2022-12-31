using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 72)]
    [Table]
    internal class PacketTravellingMerchantInventory : PacketModelBase
    {
        public static PacketTravellingMerchantInventory Parse(byte[] data) => new();
    }
}
