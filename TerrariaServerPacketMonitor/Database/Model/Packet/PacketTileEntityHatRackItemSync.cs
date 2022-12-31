using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 124)]
    [Table]
    internal class PacketTileEntityHatRackItemSync : PacketModelBase
    {
        public static PacketTileEntityHatRackItemSync Parse(byte[] data) => new();
    }
}
