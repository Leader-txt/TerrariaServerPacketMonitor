using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 86)]
    [Table]
    internal class PacketUpdateTileEntity : PacketModelBase
    {
        public static PacketUpdateTileEntity Parse(byte[] data) => new();
    }
}
