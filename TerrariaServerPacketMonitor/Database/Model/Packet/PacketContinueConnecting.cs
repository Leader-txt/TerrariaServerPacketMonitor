using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 3)]
    [Table]
    internal class PacketContinueConnecting : PacketModelBase
    {
        public static PacketContinueConnecting Parse(byte[] data) => new();
    }
}
