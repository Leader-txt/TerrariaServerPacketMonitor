using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 111)]
    [Table]
    internal class PacketToggleParty : PacketModelBase
    {
        public static PacketToggleParty Parse(byte[] data) => new();
    }
}
