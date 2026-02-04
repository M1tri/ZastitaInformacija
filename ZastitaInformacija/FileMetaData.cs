using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZastitaInformacija
{
    public class FileMetaData
    {
        public string OriginalFileName { get; set; } = string.Empty;
        public long FileSize { get; set; }
        public DateTime CreationTime { get; set; }
        public string EncryptionAlgorithm { get; set; } = string.Empty;
        public string HashAlgorithm { get; set; } = string.Empty;

        public string ToJson()
        {
            return System.Text.Json.JsonSerializer.Serialize(this);
        }
    }
}
