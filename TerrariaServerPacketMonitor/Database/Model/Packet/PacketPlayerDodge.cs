using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 62)]
    [Table]
    internal class PacketPlayerDodge : PacketModelBase
    {
        public static PacketPlayerDodge Parse(byte[] data) => new();
    }
}
