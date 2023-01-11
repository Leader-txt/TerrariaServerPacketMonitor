using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 129)]
    [Table]
    internal class PacketFinishedConnectingToServer : PacketModelBase
    {
        public static PacketFinishedConnectingToServer Parse(byte[] data) => new();
    }
}
