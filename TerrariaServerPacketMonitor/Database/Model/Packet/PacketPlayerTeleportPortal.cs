using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 96)]
    [Table]
    internal class PacketPlayerTeleportPortal : PacketModelBase
    {
        public static PacketPlayerTeleportPortal Parse(byte[] data) => new();
    }
}
