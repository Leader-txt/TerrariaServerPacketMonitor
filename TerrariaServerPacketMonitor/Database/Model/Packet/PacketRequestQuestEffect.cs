using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 144)]
    [Table]
    internal class PacketRequestQuestEffect : PacketModelBase
    {
        public static PacketRequestQuestEffect Parse(byte[] data) => new();
    }
}
