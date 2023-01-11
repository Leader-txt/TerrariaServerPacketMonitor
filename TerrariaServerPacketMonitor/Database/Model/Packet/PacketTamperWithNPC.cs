using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 131)]
    [Table]
    internal class PacketTamperWithNPC : PacketModelBase
    {
        public static PacketTamperWithNPC Parse(byte[] data) => new();
    }
}
