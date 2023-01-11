using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 89)]
    [Table]
    internal class PacketPlaceItemFrame : PacketModelBase
    {
        public static PacketPlaceItemFrame Parse(byte[] data) => new();
    }
}
