using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 92)]
    [Table]
    internal class PacketSyncExtraValue : PacketModelBase
    {
        public static PacketSyncExtraValue Parse(byte[] data) => new();
    }
}
