using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 122)]
    [Table]
    internal class PacketRequestTileEntityInteraction : PacketModelBase
    {
        public static PacketRequestTileEntityInteraction Parse(byte[] data) => new();
    }
}
