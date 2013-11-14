using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spo12h.Progr2.Exercise7
{
    class Logger
    {
        private List<string> loggEntries = new List<string>();

        public List<String> GetLogg()
        {
            return loggEntries;
        }

        public void AddLoggEntry(string loggDetails)
        {
            string loggToAdd = string.Format("{0} {1}", DateTime.Now, loggDetails);
            loggEntries.Add(loggToAdd);
        }
    }
}
