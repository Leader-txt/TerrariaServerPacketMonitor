using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 68)]
    [Table]
    internal class PacketClientUUID : PacketModelBase
    {
        public static PacketClientUUID Parse(byte[] data) => new();
    }
}
