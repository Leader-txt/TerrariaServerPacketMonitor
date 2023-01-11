using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 105)]
    [Table]
    internal class PacketGemLockToggle : PacketModelBase
    {
        public static PacketGemLockToggle Parse(byte[] data) => new();
    }
}
