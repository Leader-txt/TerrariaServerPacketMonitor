using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 119)]
    [Table]
    internal class PacketCreateCombatTextExtended : PacketModelBase
    {
        public static PacketCreateCombatTextExtended Parse(byte[] data) => new();
    }
}
