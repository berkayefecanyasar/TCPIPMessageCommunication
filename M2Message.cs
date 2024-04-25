using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BerkayTCPApp
{
    internal class M2Message : Message
    {
        static Random random = new Random();
        public static int Id { get; private set; } = 2;
        public int ReferenceNo { get; set; }
        public byte Validity { get; set; }
        public long Lon { get; set; }
        public long Lan { get; set; }
        public int Alt { get; set; }

        public override string ToString()
        {
            return $"{TimeStamp} {Info} Message2";
        }

        public override byte[] ToByteArray()
        {
            using (var memoryStream = new MemoryStream())
            {
                using (var binaryWriter = new BinaryWriter(memoryStream))
                {
                    binaryWriter.Write(Id);

                    binaryWriter.Write(ReferenceNo);
                    binaryWriter.Write(Validity);
                    binaryWriter.Write(Lon);
                    binaryWriter.Write(Lan);
                    binaryWriter.Write(Alt);
                }
                return memoryStream.ToArray();
            }
        }
        public static M2Message? Parse(byte[] bytes)
        {
            if (bytes.Length != 29)
            {
                return null;
            }
            if (BitConverter.ToInt32(bytes, 0) != Id)
            {
                return null;
            }
            var referenceno = BitConverter.ToInt32(bytes, 4);
            if (referenceno < 1 || referenceno > 9999)
            {
                return null;
            }
            var validity = bytes[8];
            var lon = BitConverter.ToInt64(bytes, 9);
            var lan = BitConverter.ToInt64(bytes, 17);            
            var alt = BitConverter.ToInt16(bytes, 25);
            if (alt < 0 || alt > 10000)
            {
                return null;
            }
            return new M2Message
            {
                ReferenceNo = referenceno,
                Validity = validity,
                Lon = lon,
                Lan = lan,
                Alt = alt
            };
        }
        public static M2Message CreateRandomMessage()
        {
            int randomid = random.Next(1, 1000);           
            return new M2Message
            {
                ReferenceNo = random.Next(-1000, 9999),
                Validity = (byte)random.Next(-1, 2),
                Lon = random.NextInt64(),
                Lan = random.NextInt64(),
                Alt = random.Next(-1,10001),
            };
        }
    }
}
