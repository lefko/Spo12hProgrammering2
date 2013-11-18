using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spo12h.Progr2.Exercise10
{
    class Logger : ILog
    {
        private List<string> loggEntries = new List<string>();

        public List<String> GetLogg()
        {
            return loggEntries;
        }



        public void AddToLog(string msg)
        {
            string loggToAdd = string.Format("{0} {1}", DateTime.Now, msg);
            loggEntries.Add(loggToAdd);
        }

    }
}
