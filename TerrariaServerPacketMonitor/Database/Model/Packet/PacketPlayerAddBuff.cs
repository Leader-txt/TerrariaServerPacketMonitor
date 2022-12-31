using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 55)]
    [Table]
    internal class PacketPlayerAddBuff : PacketModelBase
    {
        public static PacketPlayerAddBuff Parse(byte[] data) => new();
    }
}
