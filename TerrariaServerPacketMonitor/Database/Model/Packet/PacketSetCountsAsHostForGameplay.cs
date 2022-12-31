using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 139)]
    [Table]
    internal class PacketSetCountsAsHostForGameplay : PacketModelBase
    {
        public static PacketSetCountsAsHostForGameplay Parse(byte[] data) => new();
    }
}
