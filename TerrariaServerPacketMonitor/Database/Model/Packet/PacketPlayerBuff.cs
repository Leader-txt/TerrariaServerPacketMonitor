using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 50)]
    [Table]
    internal class PacketPlayerBuff : PacketModelBase
    {
        public static PacketPlayerBuff Parse(byte[] data) => new();
    }
}
