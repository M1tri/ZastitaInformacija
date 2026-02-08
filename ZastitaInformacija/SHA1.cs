using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZastitaInformacija
{
    public class SHA1
    {
        public static byte[] Hash(byte[] data)
        {
            byte[] paddedData = AddPadding(data);

            uint h0 = 0x67452301;
            uint h1 = 0xEFCDAB89;
            uint h2 = 0x98BADCFE;
            uint h3 = 0x10325476;
            uint h4 = 0xC3D2E1F0;

            for (int i = 0; i < paddedData.Length; i+=64)
            {
                uint[] w = new uint[80];

                for (int j =0; j < 16;j++)
                {
                    w[j] = (uint)(
                        paddedData[i + 4 * j]   << 24 |
                        paddedData[i + 4 * j+1] << 16 |
                        paddedData[i + 4 * j+2] << 8  |
                        paddedData[i + 4 * j+3]
                        );
                }

                for (int j = 16; j < 80; j++)
                    w[j] = RotLeft(w[j-3] ^ w[j-8] ^ w[j-14] ^ w[j-16], 1);
            
                uint a=h0, b=h1, c=h2, d=h3, e=h4;

                for (int j = 0; j < 80; j++)
                {
                    uint f, k;

                    if (j < 20)
                    {
                        f = (b & c) | (~b & d);
                        k = 0x5A827999;
                    }
                    else if (j < 40)
                    {
                        f = b ^ c ^ d;
                        k = 0x6ED9EBA1;
                    }
                    else if (j < 60)
                    {
                        f = (b & c) | (b & d) | (c & d);
                        k = 0x8F1BBCDC;
                    }
                    else
                    {
                        f = b ^ c ^ d;
                        k = 0xCA62C1D6;
                    }

                    uint tmp = RotLeft(a, 5) + f + e + k + w[j];
                    e = d;
                    d = c;
                    c = RotLeft(b, 30);
                    b = a;
                    a = tmp;
                }

                h0 += a;
                h1 += b;
                h2 += c;
                h3 += d;
                h4 += e;
            }

            return Encoding.UTF8.GetBytes($"{h0:x8}{h1:x8}{h2:x8}{h3:x8}{h4:x8}");
        }

        private static byte[] AddPadding(byte[] data)
        {
            ulong len = (ulong)(data.Length * 8);

            List<byte> bytes = new List<byte>(data);

            bytes.Add(0x80);

            while ((bytes.Count % 64) != 56)
                bytes.Add(0x00);

            for (int i = 7; i >= 0; i--)
                bytes.Add((byte)(len >> (8*i)));
            
            return bytes.ToArray();
        }
        private static uint RotLeft(uint x, uint y)
        {
            return (x << (int)(y & 31)) | (x >> (int)(32 - (y & 31)));
        }

        private static uint RotRight(uint x, uint y)
        {
            return (x >> (int)(y & 31)) | (x << (int)(32 - (y & 31)));
        }
    }
}
