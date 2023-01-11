using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 107)]
    [Table]
    internal class PacketSmartTextMessage : PacketModelBase
    {
        public static PacketSmartTextMessage Parse(byte[] data) => new();
    }
}
