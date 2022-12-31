using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 76)]
    [Table]
    internal class PacketNumberOfAnglerQuestsCompleted : PacketModelBase
    {
        public static PacketNumberOfAnglerQuestsCompleted Parse(byte[] data) => new();
    }
}
