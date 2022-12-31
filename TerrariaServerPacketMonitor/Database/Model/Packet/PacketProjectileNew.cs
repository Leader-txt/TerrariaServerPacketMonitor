using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 27)]
    [Table]
    internal class PacketProjectileNew : PacketModelBase
    {
        public static PacketProjectileNew Parse(byte[] data) => new();
    }
}
