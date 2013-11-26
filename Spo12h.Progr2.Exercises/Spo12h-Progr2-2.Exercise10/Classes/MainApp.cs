using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Exercise10;

namespace Spo12h_Progr2_2.Exercise10
{
    public class MainApp
    {
        List<ProgrammingLanguage> languages = ListLoader.LoadLanguages();

        int itemsPersPage = 5;
        int currentPageIndex = 0;

        public decimal GetMaxPageIndex()
        {
            decimal maxPageIndex = Math.Ceiling((decimal) languages.Count/itemsPersPage) - 1;

            return maxPageIndex;
        }
        



    }
}
