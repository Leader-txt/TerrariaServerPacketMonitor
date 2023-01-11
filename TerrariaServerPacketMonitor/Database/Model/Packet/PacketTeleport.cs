using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 65)]
    [Table]
    internal class PacketTeleport : PacketModelBase
    {
        public static PacketTeleport Parse(byte[] data) => new();
    }
}
