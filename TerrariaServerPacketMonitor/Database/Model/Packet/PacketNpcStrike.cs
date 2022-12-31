using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 28)]
    [Table]
    internal class PacketNpcStrike : PacketModelBase
    {
        public static PacketNpcStrike Parse(byte[] data) => new();
    }
}
