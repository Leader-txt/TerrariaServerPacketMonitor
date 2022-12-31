using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 118)]
    [Table]
    internal class PacketPlayerDeathV2 : PacketModelBase
    {
        public static PacketPlayerDeathV2 Parse(byte[] data) => new();
    }
}
