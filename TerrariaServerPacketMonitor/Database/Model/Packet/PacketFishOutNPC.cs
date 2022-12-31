using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 130)]
    [Table]
    internal class PacketFishOutNPC : PacketModelBase
    {
        public static PacketFishOutNPC Parse(byte[] data) => new();
    }
}
