using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 69)]
    [Table]
    internal class PacketChestName : PacketModelBase
    {
        public static PacketChestName Parse(byte[] data) => new();
    }
}
