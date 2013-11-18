using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spo12h.Progr2.Exercise10.Interfaces;

namespace Spo12h.Progr2.Exercise10.Classes
{
    class DateTimeLogger : ILogger
    {
        private List<string> log;
        public List<string> LogPosts {
            get { return log; }
            set { log = value; }
        }

        public DateTimeLogger()
        {
           this.log = new List<string>();
        }
        
        public void Log(string msg)
        {
            string logPost = string.Format("{0} {1}", DateTime.UtcNow, msg);
            log.Add(logPost);
        }
    }
}
