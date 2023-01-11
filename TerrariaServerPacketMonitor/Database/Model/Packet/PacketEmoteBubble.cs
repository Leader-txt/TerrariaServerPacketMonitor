using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 91)]
    [Table]
    internal class PacketEmoteBubble : PacketModelBase
    {
        public static PacketEmoteBubble Parse(byte[] data) => new();
    }
}
