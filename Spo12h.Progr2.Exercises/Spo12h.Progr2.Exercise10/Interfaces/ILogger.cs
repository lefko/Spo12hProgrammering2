using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Spo12h.Progr2.Exercise10.Interfaces
{
    interface ILogger
    {
        List<string> LogPosts { get;} 

        void Log(string msg);
    }
}
