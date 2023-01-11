using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 120)]
    [Table]
    internal class PacketEmoji : PacketModelBase
    {
        public static PacketEmoji Parse(byte[] data) => new();
    }
}
