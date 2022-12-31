using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 2)]
    [Table]
    internal class PacketDisconnect : PacketModelBase
    {
        public static PacketDisconnect Parse(byte[] data) => new();
    }
}
