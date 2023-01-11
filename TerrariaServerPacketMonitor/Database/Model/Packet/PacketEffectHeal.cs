using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 35)]
    [Table]
    internal class PacketEffectHeal : PacketModelBase
    {
        public static PacketEffectHeal Parse(byte[] data) => new();
    }
}
