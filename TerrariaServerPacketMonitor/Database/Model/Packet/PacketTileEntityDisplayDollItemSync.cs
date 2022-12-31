using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 121)]
    [Table]
    internal class PacketTileEntityDisplayDollItemSync : PacketModelBase
    {
        public static PacketTileEntityDisplayDollItemSync Parse(byte[] data) => new();
    }
}
