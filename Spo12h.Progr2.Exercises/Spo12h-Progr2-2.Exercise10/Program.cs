using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise10;

namespace Spo12h_Progr2_2.Exercise10
{
    class Program
    {
        static List<ProgrammingLanguage> languages = ListLoader.LoadLanguages();

        static int itemsPersPage = 2;
        static int currentPageIndex = 0;

        static decimal maxPageIndex = Math.Ceiling((decimal)languages.Count / itemsPersPage) - 1;

        static void Main(string[] args)
        {

            bool isRunning = true;

            ChangePage(0);

            //ConsoleKeyInfo choice = Console.ReadKey();

            do
            {

                if (currentPageIndex == maxPageIndex)
                {
                    isRunning = false;
                }
                else
                {
                    Console.WriteLine("Press Right Arrow-Key to continue or Esc to Quit: ");
                }
                ConsoleKeyInfo choice = Console.ReadKey();
                
                switch (choice.Key)
                    {
                        case ConsoleKey.RightArrow:
                            Console.Clear();
                            ChangePage(1);
                            break;
                    case ConsoleKey.LeftArrow:
                        Console.Clear();
                        ChangePage(-1);
                            break;
                        case ConsoleKey.Escape:
                            isRunning = false;
                            break;
                    } 
                
            } while (isRunning);
            
            
            

            //foreach (ProgrammingLanguage programmingLanguage in pageData)
            //{
            //    Console.WriteLine(programmingLanguage.Name);
            //}


            ExitProgram();
        }

        static void ExitProgram()
        {
            Console.WriteLine("\nPress any key to continue . . .");
            Console.ReadLine();
        }

        static IEnumerable<ProgrammingLanguage> GetLanguagesToDisplay()
        {
            var pageData = languages
                                .OrderBy(n => n.Name)
                                .Skip(itemsPersPage * currentPageIndex)
                                .Take(itemsPersPage);

            return pageData;
        }

        static void ChangePage(int i)
        {
                var pageData = GetLanguagesToDisplay();

                Console.Clear();
            if (currentPageIndex == 0)
            {
                Console.WriteLine("Current Page is: " + (currentPageIndex + 1));
                if(i == 1)
                    currentPageIndex++;
            }
            else if (currentPageIndex > 0)
            {
                
                Console.WriteLine("Current Page is: " + (currentPageIndex + i));
                if (i == -1)
                    currentPageIndex--;
                else
                    currentPageIndex++;

            }
            else
                Console.WriteLine("Current Page is: " + currentPageIndex);


            foreach (ProgrammingLanguage programmingLanguage in pageData)
                {
                    Console.WriteLine(programmingLanguage);
                }

                //currentPageIndex++;
        }

       

       
    }



    
}
