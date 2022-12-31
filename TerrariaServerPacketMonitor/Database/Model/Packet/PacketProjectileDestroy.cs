using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 29)]
    [Table]
    internal class PacketProjectileDestroy : PacketModelBase
    {
        public static PacketProjectileDestroy Parse(byte[] data) => new();
    }
}
