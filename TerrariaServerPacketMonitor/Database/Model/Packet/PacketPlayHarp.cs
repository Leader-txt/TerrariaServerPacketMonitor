using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 58)]
    [Table]
    internal class PacketPlayHarp : PacketModelBase
    {
        public static PacketPlayHarp Parse(byte[] data) => new();
    }
}
