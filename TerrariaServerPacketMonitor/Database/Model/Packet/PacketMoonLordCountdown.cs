using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 103)]
    [Table]
    internal class PacketMoonLordCountdown : PacketModelBase
    {
        public static PacketMoonLordCountdown Parse(byte[] data) => new();
    }
}
