using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 95)]
    [Table]
    internal class PacketKillPortal : PacketModelBase
    {
        public static PacketKillPortal Parse(byte[] data) => new();
    }
}
