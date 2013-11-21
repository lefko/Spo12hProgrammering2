using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spo12h.Progr2_2.Exercise3.Classes
{
    class ListLoader
    {
        public List<string> languageList = new List<string>();
 
        public void Loader()
        {
            StreamReader fileReader = new StreamReader("languages.txt");

            string line;
            while (!fileReader.EndOfStream/*(line = fileReader.ReadLine()) != null // This also works. To use it remove the line decl from the foreach loop*/)
            {
                line = fileReader.ReadLine();
                languageList.Add(line); // Add to list.
                // Console.WriteLine(line); // Write to console.
            }

            fileReader.ReadLine();

        }
    }
}
