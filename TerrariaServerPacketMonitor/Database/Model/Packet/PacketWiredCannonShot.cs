using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 108)]
    [Table]
    internal class PacketWiredCannonShot : PacketModelBase
    {
        public static PacketWiredCannonShot Parse(byte[] data) => new();
    }
}
