using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 88)]
    [Table]
    internal class PacketTweakItem : PacketModelBase
    {
        public static PacketTweakItem Parse(byte[] data) => new();
    }
}
