using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 93)]
    [Table]
    internal class PacketSocialHandshake : PacketModelBase
    {
        public static PacketSocialHandshake Parse(byte[] data) => new();
    }
}
