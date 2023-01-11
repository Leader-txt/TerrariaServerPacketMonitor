using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 16)]
    [Table]
    internal class PacketPlayerHp : PacketModelBase
    {
        public static PacketPlayerHp Parse(byte[] data) => new();
    }
}
