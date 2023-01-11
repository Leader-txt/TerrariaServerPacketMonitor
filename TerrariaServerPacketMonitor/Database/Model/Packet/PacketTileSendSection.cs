using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 10)]
    [Table]
    internal class PacketTileSendSection : PacketModelBase
    {
        public static PacketTileSendSection Parse(byte[] data) => new();
    }
}
