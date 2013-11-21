using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spo12h.Progr2_2.Exercise4.Classes
{
    class ListLoader
    {
        public List<LanguageData> list;

        public ListLoader()
        {
            list = new List<LanguageData>();
        }

        public void Load()
        {
            StreamReader fileReader = new StreamReader("languageData.txt");

            string line;
            while (!fileReader.EndOfStream)
            {
                line = fileReader.ReadLine();
                string[] strings = line.Split('\t');
                int releaseYear = int.Parse(strings[1]);
                list.Add(new LanguageData(strings[0], releaseYear, strings[2]));

                Console.WriteLine(line);
            }

        }
    }
}
