using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 78)]
    [Table]
    internal class PacketReportInvasionProgress : PacketModelBase
    {
        public static PacketReportInvasionProgress Parse(byte[] data) => new();
    }
}
