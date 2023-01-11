using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 59)]
    [Table]
    internal class PacketHitSwitch : PacketModelBase
    {
        public static PacketHitSwitch Parse(byte[] data) => new();
    }
}
