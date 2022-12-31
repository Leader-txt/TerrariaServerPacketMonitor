using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 113)]
    [Table]
    internal class PacketCrystalInvasionStart : PacketModelBase
    {
        public static PacketCrystalInvasionStart Parse(byte[] data) => new();
    }
}
