using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 123)]
    [Table]
    internal class PacketWeaponsRackTryPlacing : PacketModelBase
    {
        public static PacketWeaponsRackTryPlacing Parse(byte[] data) => new();
    }
}
