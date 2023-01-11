using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 109)]
    [Table]
    internal class PacketMassWireOperation : PacketModelBase
    {
        public static PacketMassWireOperation Parse(byte[] data) => new();
    }
}
