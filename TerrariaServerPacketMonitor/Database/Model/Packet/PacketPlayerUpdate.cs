using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 13)]
    [Table]
    internal class PacketPlayerUpdate : PacketModelBase
    {
        public static PacketPlayerUpdate Parse(byte[] data) => new();
    }
}
