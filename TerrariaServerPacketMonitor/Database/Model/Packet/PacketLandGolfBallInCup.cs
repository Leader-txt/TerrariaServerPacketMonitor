using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 128)]
    [Table]
    internal class PacketLandGolfBallInCup : PacketModelBase
    {
        public static PacketLandGolfBallInCup Parse(byte[] data) => new();
    }
}
