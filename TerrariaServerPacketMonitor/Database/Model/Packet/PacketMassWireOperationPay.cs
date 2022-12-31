using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 110)]
    [Table]
    internal class PacketMassWireOperationPay : PacketModelBase
    {
        public static PacketMassWireOperationPay Parse(byte[] data) => new();
    }
}
