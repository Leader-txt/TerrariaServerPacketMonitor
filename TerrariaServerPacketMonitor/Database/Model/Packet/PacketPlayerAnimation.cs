using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 41)]
    [Table]
    internal class PacketPlayerAnimation : PacketModelBase
    {
        public static PacketPlayerAnimation Parse(byte[] data) => new();
    }
}
