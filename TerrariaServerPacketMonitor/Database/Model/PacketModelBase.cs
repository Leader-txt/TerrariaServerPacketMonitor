using LinqToDB;
using LinqToDB.Mapping;

namespace TerrariaServerPacketMonitor.Database.Model
{
    [Table]
    internal abstract class PacketModelBase
    {
        [PrimaryKey]
        [Identity]
        [SkipValuesOnInsert]
        [Column(Order = 1)]
        public int ID { get; set; }

        [Column]
        public bool IsFromClient { get; set; }

        [Column]
        public int ClientIndex { get; set; }

        [Nullable]
        [Column(DataType = DataType.Blob, Order = -3)]
        public byte[] Data { get; set; } = default!;

        [Column(Order = -2)]
        public int Size { get; set; }

        [Column(Order = -1)]
        public DateTime TimeStamp { get; set; }
    }
}
