using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 75)]
    [Table]
    internal class PacketCompleteAnglerQuest : PacketModelBase
    {
        public static PacketCompleteAnglerQuest Parse(byte[] data) => new();
    }
}
