using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 54)]
    [Table]
    internal class PacketNpcUpdateBuff : PacketModelBase
    {
        public static PacketNpcUpdateBuff Parse(byte[] data) => new();
    }
}
