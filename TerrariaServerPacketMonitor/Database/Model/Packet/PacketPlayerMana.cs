using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 42)]
    [Table]
    internal class PacketPlayerMana : PacketModelBase
    {
        public static PacketPlayerMana Parse(byte[] data) => new();
    }
}
