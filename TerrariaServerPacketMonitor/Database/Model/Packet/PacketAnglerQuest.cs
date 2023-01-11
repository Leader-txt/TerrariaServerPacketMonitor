using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 74)]
    [Table]
    internal class PacketAnglerQuest : PacketModelBase
    {
        public static PacketAnglerQuest Parse(byte[] data) => new();
    }
}
