using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 51)]
    [Table]
    internal class PacketNpcSpecial : PacketModelBase
    {
        public static PacketNpcSpecial Parse(byte[] data) => new();
    }
}
