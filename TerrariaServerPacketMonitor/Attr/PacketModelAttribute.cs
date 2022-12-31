using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaServerPacketMonitor.Attr
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class PacketModelAttribute : Attribute
    {
        public int PacketID { get; set; } = -1;

        public PacketModelAttribute()
        {
        }
    }
}
