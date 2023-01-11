using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 79)]
    [Table]
    internal class PacketPlaceObject : PacketModelBase
    {
        public static PacketPlaceObject Parse(byte[] data) => new();
    }
}
