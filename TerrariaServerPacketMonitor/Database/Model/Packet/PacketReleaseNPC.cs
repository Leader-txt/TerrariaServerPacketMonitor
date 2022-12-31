using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 71)]
    [Table]
    internal class PacketReleaseNPC : PacketModelBase
    {
        public static PacketReleaseNPC Parse(byte[] data) => new();
    }
}
