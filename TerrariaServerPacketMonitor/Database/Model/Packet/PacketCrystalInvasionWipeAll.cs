using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 114)]
    [Table]
    internal class PacketCrystalInvasionWipeAll : PacketModelBase
    {
        public static PacketCrystalInvasionWipeAll Parse(byte[] data) => new();
    }
}
