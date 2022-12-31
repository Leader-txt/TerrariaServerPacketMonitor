using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 87)]
    [Table]
    internal class PacketPlaceTileEntity : PacketModelBase
    {
        public static PacketPlaceTileEntity Parse(byte[] data) => new();
    }
}
