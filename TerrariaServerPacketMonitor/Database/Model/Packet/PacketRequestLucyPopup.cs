using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 141)]
    [Table]
    internal class PacketRequestLucyPopup : PacketModelBase
    {
        public static PacketRequestLucyPopup Parse(byte[] data) => new();
    }
}
