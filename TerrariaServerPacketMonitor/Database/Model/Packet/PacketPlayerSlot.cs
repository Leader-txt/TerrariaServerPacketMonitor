using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 5)]
    [Table]
    internal class PacketPlayerSlot : PacketModelBase
    {
        public static PacketPlayerSlot Parse(byte[] data) => new();
    }
}
