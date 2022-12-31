using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 40)]
    [Table]
    internal class PacketNpcTalk : PacketModelBase
    {
        public static PacketNpcTalk Parse(byte[] data) => new();
    }
}
