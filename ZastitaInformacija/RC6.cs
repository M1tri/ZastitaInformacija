using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ZastitaInformacija
{
    public class RC6 : Cypher
    {
        protected uint[] S;
        protected const int runde = 20;
        protected string extension = ".rc6";
        protected string algo_name = "RC6";

        public RC6(byte[] key) {
            KeySchedule(key);
        }

        public string EncryptFile(string filePath, bool hash = false, string? outDir = null)
        {
            byte[] data = File.ReadAllBytes(filePath);

            FileMetaData fileMetaData = new FileMetaData()
            {
                OriginalFileName = Path.GetFileName(filePath),
                FileSize = data.Length,
                CreationTime = DateTime.Now,
                EncryptionAlgorithm = algo_name,
                HashAlgorithm = hash ? "SHA-1" : ""
            };

            byte[] encrypted = Encrypt(data, fileMetaData);
            
            byte[] hashBytes = SHA1.Hash(encrypted);

            string dir = Path.GetDirectoryName(filePath)!;
            string outFileDir = outDir ?? dir;

            string fileName = Path.GetFileNameWithoutExtension(filePath);
            string outFile = Path.Combine(outFileDir, fileName + "_encrypted");

            string outFileFull = outFile + extension;

            string json = fileMetaData.ToJson();
            byte[] metaBytes = Encoding.UTF8.GetBytes(json);

            using (FileStream fs = new FileStream(outFileFull, FileMode.Create))
            using (BinaryWriter bw = new BinaryWriter(fs))
            {
                bw.Write(metaBytes.Length);
                bw.Write(metaBytes);
                if (hash)
                {
                    bw.Write(hashBytes);
                }
                bw.Write(encrypted);
            }

            return outFileFull;
         }
        public virtual byte[] Encrypt(byte[] data, FileMetaData fileMetaData)
        {
            string json = fileMetaData.ToJson();
            byte[] metaBytes = Encoding.UTF8.GetBytes(json);

            int padding = 16 - (data.Length % 16);
            Array.Resize(ref data, data.Length + padding);
            for (int i = data.Length - padding; i < data.Length; i++)
            {
                data[i] = (byte)padding;
            }

            byte[] encrypted = new byte[data.Length];

            for (int i = 0; i < data.Length; i += 16)
            {
                uint[] block = new uint[4];

                for (int j = 0; j < 4; j++)
                {
                    block[j] = BitConverter.ToUInt32(data, i + j * 4);
                }

                EncryptBlock(block);

                for (int j = 0; j < 4; j++)
                {
                    Array.Copy(BitConverter.GetBytes(block[j]),
                        0, encrypted, i + j * 4, 4);
                }
            }

            return encrypted;
        }

        public virtual string DecryptFile(string filePath, bool hash = false, string? outDir = null)
        {
            string ext = Path.GetExtension(filePath);
            if (ext != extension)
                throw new CypherException($"Neočekivana ekstenzija, očekivano .pfc a data ekstenzija je {ext}");

            byte[] data;
            byte[] hashBytes = null;
            bool hashed = false;
            FileMetaData fileMetaData;
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            using (BinaryReader br = new BinaryReader(fs))
            {
                int size = br.ReadInt32();
                byte[] metaData = br.ReadBytes(size);

                string json = Encoding.UTF8.GetString(metaData);
                fileMetaData = JsonSerializer.Deserialize<FileMetaData>(json)!;

                if (fileMetaData.HashAlgorithm == "SHA-1")
                {
                    int len = 20;
                    hashBytes = br.ReadBytes(len);
                    hashed = true;
                }

                int ostalo = (int)(br.BaseStream.Length - br.BaseStream.Position);
                data = br.ReadBytes(ostalo);
            }

            if (hashed)
            {
                byte[] newHash = SHA1.Hash(data);

                if (Encoding.UTF8.GetString(newHash) != Encoding.UTF8.GetString(hashBytes!))
                    throw new CypherException("Hash se ne poklapa");
            }

            byte[] decrypted = Decrypt(data, fileMetaData);

            string dir = Path.GetDirectoryName(filePath)!;
            string outFileDir = outDir ?? dir;

            string origExt = Path.GetExtension(fileMetaData.OriginalFileName);
            string newFile = Path.GetFileNameWithoutExtension(fileMetaData.OriginalFileName) + "decrypted" + origExt;
            string newFilePath = Path.Combine(outFileDir, newFile);

            File.WriteAllBytes(newFilePath, decrypted);

            return newFilePath;
        }
        public virtual byte[] Decrypt(byte[] data, FileMetaData fileMetaData)
        {
            byte[] decrypted = new byte[data.Length];
            for (int i = 0; i < data.Length; i += 16)
            {
                uint[] block = new uint[4];
                for (int j = 0; j < 4; j++)
                    block[j] = BitConverter.ToUInt32(data, i + j * 4);

                DecryptBlock(block);

                for (int j = 0; j < 4; j++)
                    Array.Copy(BitConverter.GetBytes(block[j]), 0, decrypted, i + j * 4, 4);
            }

            Array.Resize(ref decrypted, (int)fileMetaData.FileSize);

            return decrypted;
        }
        protected void KeySchedule(byte[] key)
        {
            const uint Pw = 0xB7E15163;
            const uint Qw = 0x9E3779B9;

            uint[] L = new uint[(key.Length + 3) / 4];
            for (int i = key.Length - 1; i >= 0; i--)
            {
                L[i / 4] = (L[i / 4] << 8) + key[i];
            }

            S = new uint[2 * runde + 4];
            S[0] = Pw;
            for (int i = 1; i < S.Length; i++)
            {
                S[i] = S[i - 1] + Qw;
            }

            uint A = 0, B = 0;
            int iS = 0, iL = 0;
            int v = 3 * Math.Max(L.Length, S.Length);

            for (int k = 0; k < v; k++)
            {
                S[iS] = RotLeft(S[iS] + A + B, 3);
                L[iL] = RotLeft(L[iL] + A + B, A + B);

                A = S[iS];
                B = L[iL];
                iS = (iS + 1) % S.Length;
                iL = (iL + 1) % L.Length;
            }
        }
        protected void KeySchedule2(byte[] key)
        {
            const uint Pw = 0xB7E15163;
            const uint Qw = 0x9E3779B9;

            int c = key.Length / 4;
            if (key.Length % 4 != 0) c++;

            uint[] L = new uint[c];
            for (int i = 0; i < c; i++)
            {
                int length = Math.Min(4, key.Length - i * 4);
                byte[] temp = new byte[4];
                Array.Copy(key, i * 4, temp, 0, length);
                L[i] = BitConverter.ToUInt32(temp, 0);
            }

            int t = 2 * runde + 4;
            S = new uint[t];
            S[0] = Pw;
            for (int i = 1; i < t; i++)
            {
                S[i] = S[i - 1] + Qw;
            }

            uint A = 0;
            uint B = 0;
            int i_idx = 0;
            int j_idx = 0;
            int v = 3 * Math.Max(c, t);

            for (int s = 1; s <= v; s++)
            {
                A = S[i_idx] = RotLeft(S[i_idx] + A + B, 3);
                B = L[j_idx] = RotLeft(L[j_idx] + A + B, A + B);
                i_idx = (i_idx + 1) % t;
                j_idx = (j_idx + 1) % c;
            }
        }

        protected uint RotLeft(uint x, uint y)
        {
            return (x << (int)(y & 31)) | (x >> (int)(32 - (y & 31)));
        }

        protected uint RotRight(uint x, uint y)
        {
            return (x >> (int)(y & 31)) | (x << (int)(32 - (y & 31)));
        }

        protected void EncryptBlock(uint[] block)
        {
            uint A=block[0], B=block[1], C=block[2], D=block[3];

            B += S[0];
            D += S[1];

            for (int i=1; i <= runde; i++)
            {
                uint t = RotLeft(B * (2 * B + 1), 5);
                uint u = RotLeft(D * (2 * D + 1), 5);

                A = RotLeft(A ^ t, u) + S[2 * i];
                C = RotLeft(C ^ u, t) + S[2 * i + 1];

                uint tmp = A;
                A = B;
                B = C;
                C = D;
                D = tmp;
            }

            A += S[2*runde+2];
            C += S[2*runde+3];

            block[0] = A;
            block[1] = B;
            block[2] = C;
            block[3] = D;
        }
        protected void DecryptBlock(uint[] block)
        {
            uint A = block[0], B = block[1], C = block[2], D = block[3];

            C -= S[2*runde+3];
            A -= S[2*runde+2];

            for (int i = runde; i >= 1; i--)
            {
                uint tmp = D;
                D = C;
                C = B;
                B = A;
                A = tmp;

                uint u = RotLeft(D * (2 * D + 1), 5);
                uint t = RotLeft(B * (2 * B + 1), 5);

                C = RotRight(C - S[2 * i + 1], t) ^ u;
                A = RotRight(A - S[2 * i],  u) ^ t;
            }

            D -= S[1];
            B -= S[0];

            block[0] = A;
            block[1] = B;
            block[2] = C;
            block[3] = D;
        }
    }
}
