using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 82)]
    [Table]
    internal class PacketLoadNetModule : PacketModelBase
    {
        public static PacketLoadNetModule Parse(byte[] data) => new();
    }
}
