namespace TerrariaServerPacketMonitor.Attr
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class PacketModelAttribute : Attribute
    {
        public int PacketID { get; set; } = -1;
    }
}
