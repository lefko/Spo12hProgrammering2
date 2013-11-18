using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spo12h.Progr2.Exercise10.Classes;

namespace Spo12h.Progr2.Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new DateTimeLogger();
            var application = new LoggApplication(logger);
            application.Run();
        }
    }
}
