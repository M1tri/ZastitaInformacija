using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZastitaInformacija
{
    interface Cypher
    {
        string EncryptFile(string filePath, string? outDir = null);
        string DecryptFile(string filePath, string? outDir = null);

        byte[] Encrypt(byte[] data, FileMetaData fileMetaData);
        byte[] Decrypt(byte[] data, FileMetaData fileMetaData);
    }
}
