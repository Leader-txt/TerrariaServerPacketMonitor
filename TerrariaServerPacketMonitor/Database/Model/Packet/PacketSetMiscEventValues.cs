using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 140)]
    [Table]
    internal class PacketSetMiscEventValues : PacketModelBase
    {
        public static PacketSetMiscEventValues Parse(byte[] data) => new();
    }
}
