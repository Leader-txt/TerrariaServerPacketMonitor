using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 73)]
    [Table]
    internal class PacketTeleportationPotion : PacketModelBase
    {
        public static PacketTeleportationPotion Parse(byte[] data) => new();
    }
}
