using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 85)]
    [Table]
    internal class PacketForceItemIntoNearestChest : PacketModelBase
    {
        public static PacketForceItemIntoNearestChest Parse(byte[] data) => new();
    }
}
