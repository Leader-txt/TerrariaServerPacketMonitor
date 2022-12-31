using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 100)]
    [Table]
    internal class PacketNpcTeleportPortal : PacketModelBase
    {
        public static PacketNpcTeleportPortal Parse(byte[] data) => new();
    }
}
