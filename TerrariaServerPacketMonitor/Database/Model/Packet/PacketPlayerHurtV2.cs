using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 117)]
    [Table]
    internal class PacketPlayerHurtV2 : PacketModelBase
    {
        public static PacketPlayerHurtV2 Parse(byte[] data) => new();
    }
}
