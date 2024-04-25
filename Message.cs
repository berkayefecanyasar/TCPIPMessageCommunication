using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BerkayTCPApp
{
    internal abstract class Message
    {
        public string Info { get; set; } = string.Empty;

        public DateTime TimeStamp { get; set; } = DateTime.Now;
        public abstract byte[] ToByteArray();
    }
}
