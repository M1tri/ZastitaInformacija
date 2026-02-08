using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZastitaInformacija
{
    interface Cypher
    {
        string EncryptFile(string filePath, bool hash = false, string? outDir = null);
        string DecryptFile(string filePath, bool hash = false, string? outDir = null);

        byte[] Encrypt(byte[] data, FileMetaData fileMetaData);
        byte[] Decrypt(byte[] data, FileMetaData fileMetaData);
    }
}
