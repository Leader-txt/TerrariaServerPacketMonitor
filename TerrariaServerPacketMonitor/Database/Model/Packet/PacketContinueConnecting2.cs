using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 6)]
    [Table]
    internal class PacketContinueConnecting2 : PacketModelBase
    {
        public static PacketContinueConnecting2 Parse(byte[] data) => new();
    }
}
