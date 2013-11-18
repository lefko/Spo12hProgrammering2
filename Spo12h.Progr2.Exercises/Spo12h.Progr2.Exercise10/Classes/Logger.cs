using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Spo12h.Progr2.Exercise10.Interfaces;

namespace Spo12h.Progr2.Exercise10
{
    class Logger : ILogger
    {
        
        public List<string> LogPosts { get; private set; }

        public Logger()
        {
            LogPosts = new List<string>();
        }

        

        public void Log(string msg)
        {
            LogPosts.Add(msg);
        }
    }
}
