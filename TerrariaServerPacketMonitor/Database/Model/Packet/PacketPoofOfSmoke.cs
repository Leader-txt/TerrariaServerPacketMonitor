using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 106)]
    [Table]
    internal class PacketPoofOfSmoke : PacketModelBase
    {
        public static PacketPoofOfSmoke Parse(byte[] data) => new();
    }
}
