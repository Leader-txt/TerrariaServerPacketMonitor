using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 84)]
    [Table]
    internal class PacketPlayerStealth : PacketModelBase
    {
        public static PacketPlayerStealth Parse(byte[] data) => new();
    }
}
