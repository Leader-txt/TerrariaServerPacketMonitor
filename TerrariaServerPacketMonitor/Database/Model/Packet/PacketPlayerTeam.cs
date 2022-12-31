using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 45)]
    [Table]
    internal class PacketPlayerTeam : PacketModelBase
    {
        public static PacketPlayerTeam Parse(byte[] data) => new();
    }
}
