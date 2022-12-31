using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 83)]
    [Table]
    internal class PacketNpcKillCount : PacketModelBase
    {
        public static PacketNpcKillCount Parse(byte[] data) => new();
    }
}
