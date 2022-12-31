using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 32)]
    [Table]
    internal class PacketChestItem : PacketModelBase
    {
        public static PacketChestItem Parse(byte[] data) => new();
    }
}
