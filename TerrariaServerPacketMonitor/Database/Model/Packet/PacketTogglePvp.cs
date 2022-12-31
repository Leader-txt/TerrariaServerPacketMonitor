using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 30)]
    [Table]
    internal class PacketTogglePvp : PacketModelBase
    {
        public static PacketTogglePvp Parse(byte[] data) => new();
    }
}
