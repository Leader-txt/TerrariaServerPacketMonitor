using LinqToDB.Mapping;
using TerrariaServerPacketMonitor.Attr;

namespace TerrariaServerPacketMonitor.Database.Model.Packet
{
    [PacketModel(PacketID = 31)]
    [Table]
    internal class PacketChestGetContents : PacketModelBase
    {
        public static PacketChestGetContents Parse(byte[] data) => new();
    }
}
