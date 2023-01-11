using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 98)]
    [Table]
    internal class PacketNotifyPlayerOfEvent : PacketModelBase
    {
        public static PacketNotifyPlayerOfEvent Parse(byte[] data) => new();
    }
}
