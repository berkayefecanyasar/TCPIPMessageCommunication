using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BerkayTCPApp
{
    internal class M1Message : Message
    { 
        public static int Id { get; private set; } = 1;
        static Random random = new Random();
        public int ReferenceNo { get; set; }
        public string Name { get; set; } = string.Empty;
        public uint UnitNo { get; set; }
        public string Surname { get; set; } = string.Empty;
        public short Rank { get; set; }

        public override string ToString()
        {
            return $"{TimeStamp} {Info} Message1";
        }
        
        public override byte[] ToByteArray()
        {
            using (var memoryStream = new MemoryStream())
            {
                using (var binaryWriter = new BinaryWriter(memoryStream))
                {
                    string paddedName = Name.PadRight(25).Substring(0, 25);
                    string paddedSurname = Surname.PadRight(25).Substring(0, 25);
                    binaryWriter.Write(Id);

                    binaryWriter.Write(ReferenceNo);
                    binaryWriter.Write(Encoding.UTF8.GetBytes(paddedName));
                    binaryWriter.Write(UnitNo);
                    binaryWriter.Write(Encoding.UTF8.GetBytes(paddedSurname));
                    binaryWriter.Write(Rank);
                }
                return memoryStream.ToArray();
            }
        }

        public static M1Message? Parse(byte[] bytes)
        {
            if (bytes.Length != 64)
            {
                return null;
            }
            if (BitConverter.ToInt32(bytes, 0) != Id)
            {
                return null;
            }
            var referenceno = BitConverter.ToInt32(bytes, 4);
            if (referenceno < -1000 || referenceno > 9999)
            {
                return null;
            }
            var name = Encoding.UTF8.GetString(bytes, 8, 25).Trim();
            var unitNo = BitConverter.ToUInt32(bytes, 33);
            var surname = Encoding.UTF8.GetString(bytes, 37,25).Trim();
            var rank = BitConverter.ToInt16(bytes, 62);
            return new M1Message
            {
                ReferenceNo = referenceno,
                Name = name,
                UnitNo = unitNo,
                Surname = surname,
                Rank = rank
            };
        }
        public static M1Message CreateRandomMessage()
        {
            int randomid = random.Next(1, 1000);
            return new M1Message
            {
                ReferenceNo = random.Next(-1000, 9999),
                Name = "name" + randomid.ToString(),
                UnitNo = (uint)random.Next(0, 10000),
                Surname = "surname" + randomid.ToString(),
                Rank = (short)random.Next(-1, 3)
            };
        }
    }

    
}
