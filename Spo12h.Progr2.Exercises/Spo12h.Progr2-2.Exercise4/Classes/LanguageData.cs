using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spo12h.Progr2_2.Exercise4.Classes
{
    class LanguageData
    {
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public string Description { get; set; }

        public LanguageData(string name, int releaseYear, string description)
        {
            this.Name = name;
            this.ReleaseYear = releaseYear;
            this.Description = description;
        }
    }
}
