using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZastitaInformacija
{
    class CypherException : Exception
    {
        public CypherException(string message) 
        : base(message)
        {
            
        }
    }
}
