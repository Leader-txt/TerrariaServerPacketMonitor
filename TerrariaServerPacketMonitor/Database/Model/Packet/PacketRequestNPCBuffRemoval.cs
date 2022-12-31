using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 137)]
    [Table]
    internal class PacketRequestNPCBuffRemoval : PacketModelBase
    {
        public static PacketRequestNPCBuffRemoval Parse(byte[] data) => new();
    }
}
