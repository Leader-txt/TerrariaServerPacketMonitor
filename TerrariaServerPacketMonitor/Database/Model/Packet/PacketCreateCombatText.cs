using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 81)]
    [Table]
    internal class PacketCreateCombatText : PacketModelBase
    {
        public static PacketCreateCombatText Parse(byte[] data) => new();
    }
}
