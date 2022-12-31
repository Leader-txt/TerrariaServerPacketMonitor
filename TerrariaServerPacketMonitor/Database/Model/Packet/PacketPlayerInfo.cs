using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 4)]
    [Table]
    internal class PacketPlayerInfo : PacketModelBase
    {
        public static PacketPlayerInfo Parse(byte[] data) => new();
    }
}
