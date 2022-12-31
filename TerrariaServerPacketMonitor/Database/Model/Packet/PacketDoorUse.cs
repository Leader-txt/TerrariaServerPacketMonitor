using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 19)]
    [Table]
    internal class PacketDoorUse : PacketModelBase
    {
        public static PacketDoorUse Parse(byte[] data) => new();
    }
}
