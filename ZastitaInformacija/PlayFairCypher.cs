using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ZastitaInformacija
{
    public class PlayFairCypher : Cypher
    {
        private string m_key;
        private char[,] m_matrica;

        public string Key { 
            get { 
                return m_key; 
            }
            set { 
                m_key = value;
                UpdateMatricu(); 
            }
        }

        public PlayFairCypher(string key)
        {
            m_key = key.ToUpper();
            m_matrica = new char[5, 5];

            UpdateMatricu();
        }

        private void UpdateMatricu()
        {
            HashSet<char> used = new HashSet<char>();
            List<char> alphabet = new List<char>("ABCDEFGHIKLMNOPQRSTUVWXYZ");
            
            int i = 0, j = 0;
            foreach (char c in m_key)
            {
                if (!used.Contains(c))
                {
                    used.Add(c);
                    m_matrica[i,j] = c;
                    j++;
                    if (j >= 5)
                    {
                        j = 0;
                        i++;
                    }
                }
            }

            foreach (char c in alphabet)
            {
                if (!used.Contains(c))
                {
                    used.Add(c);
                    m_matrica[i, j] = c;
                    j++;
                    if (j >= 5)
                    {
                        j = 0;
                        i++;
                    }
                }
            }
        }

        private List<Tuple<char, char>> GetPairs(string text)
        {
            StringBuilder letters = new StringBuilder("");
            foreach (char c in text.ToUpper())
            {
                if (char.IsLetter(c))
                {
                    letters.Append(c == 'J' ? 'I' : c);
                }
            }

            List<Tuple<char, char>> output = new List<Tuple<char, char>>();

            int i = 0;
            
            while (i < letters.Length)
            {
                char a = letters[i];
                char b;

                if (i+1 < letters.Length)
                {
                    b = letters[i+1];

                    if (a==b)
                    {
                        b = 'X';
                        i++;
                    }
                    else
                    {
                        i += 2;
                    }
                }
                else
                {
                    b = 'X';
                    i++;
                }

                output.Add(new Tuple<char, char>(a, b));
            }

            return output;
        }

        private Tuple<int, int> GetPos(char c)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (m_matrica[i, j] == c)
                        return new Tuple<int, int>(i, j);
                }
            }

            return new Tuple<int, int>(-1, -1);
        }

        private string EncryptText(string text)
        {
            List<Tuple<char, char>> pairs = GetPairs(text);
            StringBuilder output = new StringBuilder();

            foreach (var pair in pairs)
            {
                char a = pair.Item1;
                char b = pair.Item2;

                Tuple<int, int> posA = GetPos(a);
                Tuple<int, int> posB = GetPos(b);

                int row1, col1, row2, col2;
                if (posA.Item1 == posB.Item1)
                {
                    row1 = posA.Item1;
                    row2 = posB.Item1;

                    col1 = (posA.Item2 + 1) % 5;
                    col2 = (posB.Item2 + 1) % 5;
                }
                else if (posA.Item2 == posB.Item2)
                {
                    col1 = posA.Item2;
                    col2 = posB.Item2;

                    row1 = (posA.Item1 + 1) % 5;
                    row2 = (posB.Item1 + 1) % 5;
                }
                else
                {
                    row1 = posA.Item1;
                    row2 = posB.Item1;

                    col1 = posB.Item2;
                    col2 = posA.Item2;
                }

                output.Append(m_matrica[row1, col1]);
                output.Append(m_matrica[row2, col2]);
            }


            return output.ToString();
        }

        private string DecryptText(string text)
        {
            List<Tuple<char, char>> pairs = GetPairs(text);
            StringBuilder output = new StringBuilder();

            foreach(var pair in pairs)
            {
                char a = pair.Item1;
                char b = pair.Item2;

                Tuple<int, int> posA = GetPos(a);
                Tuple<int, int> posB = GetPos(b);

                int row1, col1, row2, col2;
                if (posA.Item1 == posB.Item1)
                {
                    row1 = posA.Item1;
                    row2 = posB.Item1;

                    col1 = (posA.Item2 + 4) % 5;
                    col2 = (posB.Item2 + 4) % 5;
                }
                else if (posA.Item2 == posB.Item2)
                {
                    col1 = posA.Item2;
                    col2 = posB.Item2;

                    row1 = (posA.Item1 + 4) % 5;
                    row2 = (posB.Item1 + 4) % 5;
                }
                else
                {
                    row1 = posA.Item1;
                    row2 = posB.Item1;

                    col1 = posB.Item2;
                    col2 = posA.Item2;
                }

                output.Append(m_matrica[row1, col1]);
                output.Append(m_matrica[row2, col2]);
            }

            return output.ToString();
        }

        public string EncryptFile(string filePath, bool hash = false, string? outDir = null)
        {
            string ext = Path.GetExtension(filePath);

            if (ext != ".txt")
                throw new CypherException($"Neočekivana ekstenzija, očekivano .txt a data ekstenzija je {ext}");

            byte[] data = File.ReadAllBytes(filePath);

            FileMetaData fileMetaData = new FileMetaData()
            {
                OriginalFileName = Path.GetFileName(filePath),
                FileSize = data.Length,
                CreationTime = DateTime.Now,
                EncryptionAlgorithm = "RC6",
                HashAlgorithm = hash ? "SHA1" : ""
            };

            byte[] encrypted = Encrypt(data, fileMetaData);
            byte[]? hashBytes = hash ? SHA1.Hash(encrypted) : null;

            string dir = Path.GetDirectoryName(filePath)!;

            string outFileDir = outDir ?? dir;

            string fileName = Path.GetFileNameWithoutExtension(filePath);
            string outFile = Path.Combine(outFileDir, fileName + "_encrypted");
            string outFileFull = outFile + ".pfc";
            
            string json = fileMetaData.ToJson();
            byte[] metaBytes = Encoding.UTF8.GetBytes(json);

            using (FileStream fs = new FileStream(outFileFull, FileMode.Create))
            using (BinaryWriter bw = new BinaryWriter(fs))
            {
                bw.Write(metaBytes.Length);
                bw.Write(metaBytes);
                if (hash)
                {
                    bw.Write(hashBytes!.Length);
                    bw.Write(hashBytes!);
                }
                bw.Write(encrypted);
            }

            return outFileFull;
        }

        public string DecryptFile(string filePath, bool hash = false, string? outDir = null)
        {
            string ext = Path.GetExtension(filePath);
            if (ext != ".pfc")
                throw new CypherException($"Neočekivana ekstenzija, očekivano .pfc a data ekstenzija je {ext}");

            byte[] data;
            byte[]? hashBytes = null;
            bool hashed = false;
            FileMetaData fileMetaData;
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            using (BinaryReader br = new BinaryReader(fs)) 
            {
                int size = br.ReadInt32();
                byte[] metaData = br.ReadBytes(size);

                string json = Encoding.UTF8.GetString(metaData);
                fileMetaData = JsonSerializer.Deserialize<FileMetaData>(json)!;

                if (fileMetaData.HashAlgorithm == "SHA1")
                {
                    int len = br.ReadInt32();
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

        public byte[] Encrypt(byte[] data, FileMetaData fileMetaData)
        {
            string tekst = Encoding.UTF8.GetString(data);

            string encrypted = EncryptText(tekst);
            
            return Encoding.UTF8.GetBytes(encrypted);
        }

        public byte[] Decrypt(byte[] data, FileMetaData fileMetaData)
        {
            string tekst = Encoding.UTF8.GetString(data);

            string decrypted = DecryptText(tekst);

            return Encoding.UTF8.GetBytes(decrypted);
        }
    }
}
