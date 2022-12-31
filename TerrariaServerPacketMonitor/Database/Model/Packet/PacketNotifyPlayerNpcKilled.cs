using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 97)]
    [Table]
    internal class PacketNotifyPlayerNpcKilled : PacketModelBase
    {
        public static PacketNotifyPlayerNpcKilled Parse(byte[] data) => new();
    }
}
