using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 143)]
    [Table]
    internal class PacketCrystalInvasionRequestedToSkipWaitTime : PacketModelBase
    {
        public static PacketCrystalInvasionRequestedToSkipWaitTime Parse(byte[] data) => new();
    }
}
