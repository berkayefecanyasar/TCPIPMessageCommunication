using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerkayTCPApp
{
    internal class UnknownMessage : Message
    {
        public  string Data { get; set; }
        public override byte[] ToByteArray()
        {
            throw new NotImplementedException();
        }

        public static UnknownMessage? Parse(byte[] bytes)
        {
            return new UnknownMessage()
            {
                Data = BitConverter.ToString(bytes).Replace("-", " ")
            };
        }
        public override string ToString() { return $"{TimeStamp} Unknown Message."; }
    }
}
