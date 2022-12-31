using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 66)]
    [Table]
    internal class PacketPlayerHealOther : PacketModelBase
    {
        public static PacketPlayerHealOther Parse(byte[] data) => new();
    }
}
