using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 24)]
    [Table]
    internal class PacketNpcItemStrike : PacketModelBase
    {
        public static PacketNpcItemStrike Parse(byte[] data) => new();
    }
}
