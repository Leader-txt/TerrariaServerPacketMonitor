using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 112)]
    [Table]
    internal class PacketTreeGrowFX : PacketModelBase
    {
        public static PacketTreeGrowFX Parse(byte[] data) => new();
    }
}
