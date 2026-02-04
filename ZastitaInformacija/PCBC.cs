using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZastitaInformacija
{
    public class PCBC : RC6
    {
        byte[] IV;
        public PCBC(byte[] key, byte[] IV) : base(key)
        {
            this.IV = new byte[16];
            Array.Copy(IV, this.IV, 16);
            extension = ".pcbc";
        }

        public override byte[] Encrypt(byte[] data, FileMetaData fileMetaData)
        {
            int padding = 16 - (data.Length % 16);
            Array.Resize(ref data, data.Length + padding);
            for (int i = data.Length - padding; i < data.Length; i++)
            {
                data[i] = (byte)padding;
            }

            byte[] encrypted = new byte[data.Length];
            byte[] prevPlain = new byte[16];
            byte[] prevCipher = new byte[16];
            Array.Copy(IV, prevCipher, 16);

            for (int i = 0; i < data.Length; i+=16)
            {
                byte[] block = new byte[16];
                Array.Copy(data, i, block, 0, 16);

                for (int j = 0; j < 16; j++)
                {
                    block[j] ^= (byte)(prevPlain[j] ^ prevCipher[j]);
                }

                uint[] uBlock = new uint[4];
                for (int j = 0; j < 4; j++)
                {
                    uBlock[j] = BitConverter.ToUInt32(block, j * 4);
                }

                EncryptBlock(uBlock);

                for (int j = 0; j < 4; j++)
                {
                    Array.Copy(BitConverter.GetBytes(uBlock[j]),
                        0, encrypted, i + j * 4, 4);
                }

                Array.Copy(block, prevPlain, 16);
                Array.Copy(encrypted, i, prevCipher, 0, 16);
            }

            return encrypted;
        }

        public override byte[] Decrypt(byte[] data, FileMetaData fileMetaData)
        {
            byte[] decrypted = new byte[data.Length];
            byte[] prevPlain = new byte[16];
            byte[] prevCipher = new byte[16];
            Array.Copy(IV, prevCipher, 16);

            for (int i = 0; i < data.Length; i+= 16)
            {
                byte[] block = new byte[16];
                Array.Copy(data, i, block, 0, 16);

                uint[] uBlock = new uint[4];
                for (int j = 0; j < 4; j++)
                {
                    uBlock[j] = BitConverter.ToUInt32(block, j * 4);
                }

                DecryptBlock(uBlock);

                for (int j = 0; j < 4; j++)
                {
                    Array.Copy(BitConverter.GetBytes(uBlock[j]),
                        0, block, j * 4, 4);
                }

                for (int j = 0; j < 16; j++)
                {
                    block[j] ^= (byte)(prevPlain[j] ^ prevCipher[j]);
                }

                Array.Copy(block, 0, decrypted, i, 16);

                Array.Copy(block, prevPlain, 16);
                Array.Copy(data, i, prevCipher, 0, 16);
            }

            Array.Resize(ref decrypted, (int)fileMetaData.FileSize);

            return decrypted;
        }
    }
}
