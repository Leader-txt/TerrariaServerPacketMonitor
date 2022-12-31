using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 115)]
    [Table]
    internal class PacketMinionAttackTargetUpdate : PacketModelBase
    {
        public static PacketMinionAttackTargetUpdate Parse(byte[] data) => new();
    }
}
