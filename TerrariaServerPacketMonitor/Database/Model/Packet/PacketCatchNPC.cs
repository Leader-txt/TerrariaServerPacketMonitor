using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 70)]
    [Table]
    internal class PacketCatchNPC : PacketModelBase
    {
        public static PacketCatchNPC Parse(byte[] data) => new();
    }
}
