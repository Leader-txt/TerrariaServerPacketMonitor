using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 116)]
    [Table]
    internal class PacketCrystalInvasionSendWaitTime : PacketModelBase
    {
        public static PacketCrystalInvasionSendWaitTime Parse(byte[] data) => new();
    }
}
