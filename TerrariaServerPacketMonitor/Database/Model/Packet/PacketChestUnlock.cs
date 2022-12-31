using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 52)]
    [Table]
    internal class PacketChestUnlock : PacketModelBase
    {
        public static PacketChestUnlock Parse(byte[] data) => new();
    }
}
