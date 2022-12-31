using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 135)]
    [Table]
    internal class PacketDeadPlayer : PacketModelBase
    {
        public static PacketDeadPlayer Parse(byte[] data) => new();
    }
}
