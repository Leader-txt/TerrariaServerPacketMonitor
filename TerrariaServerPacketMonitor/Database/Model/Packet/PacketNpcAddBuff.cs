using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 53)]
    [Table]
    internal class PacketNpcAddBuff : PacketModelBase
    {
        public static PacketNpcAddBuff Parse(byte[] data) => new();
    }
}
