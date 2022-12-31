using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 43)]
    [Table]
    internal class PacketEffectMana : PacketModelBase
    {
        public static PacketEffectMana Parse(byte[] data) => new();
    }
}
