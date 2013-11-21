using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Spo12g.Progr2_2.Exercise.Dictionaries
{
    class Program
    {
        static Dictionary<char, string> letterOccurence = new Dictionary<char, string>();
  
        static void Main(string[] args)
        {
            Application(letterOccurence);

            Console.ReadLine();

        }


        private static void Application(Dictionary<char, string> letterOccurence)
        {
            // var letterOccurrence = new Dictionary<char, string>();
            DrawApplication();

            string input = getInput();
            input.ToLower();

            // Add all the string characters to Dictionary
            AddInputCahrsToDictionary(input, letterOccurence);
            
            // Add only the swedish alfabet to dictionary
            // AddSwedishAlfabetToDictionary(letterOccurence);

            
           

            foreach (var pair in letterOccurence)
            {
                if (pair.Value != "")
                {
                        string characterToDisplay = pair.Key.ToString();
                        if(char.IsWhiteSpace(pair.Key))
                            characterToDisplay = "[Space]";

                        string output = string.Format("{0} = {1}", characterToDisplay, pair.Value);
                        Console.WriteLine(output);

                        //if(letterOccurrence.ContainsKey(char.IsWhiteSpace(pair.Key))
                }
            }
        }
    
        private static void DrawApplication()
        {
            Console.WriteLine();
            Console.WriteLine("Letter Count Application");
            Console.WriteLine("------------------------");
            Console.WriteLine();
            
        }

        static string getInput()
        {
            Console.Write("Enter the text for count: ");
            string input = Console.ReadLine();

            return input;
        }

        //public void CountLetter(char c, ref Dictionary<TKey, TValue> dic)
        //{
        //    if(dic.ContainsKey(char))
        //        dic.
        //}

        static void AddInputCahrsToDictionary(string input, Dictionary<char, string> letterOccurence )
        {
            foreach (char c in input)
            {
                if (!letterOccurence.ContainsKey(c))
                    letterOccurence.Add(c, "");

            }

            foreach (char c in input)
            {
                if (letterOccurence.ContainsKey(c))
                {
                    //string value = "";
                    string value = letterOccurence[c];
                    value = value + "*";

                    letterOccurence[c] = value;
                }
            }  
        }

        static void AddSwedishAlfabetToDictionary(Dictionary<char, string> letterOccurence)
        {
            // Adds the swedish alfabet to the Dictionary
            letterOccurence.Add('a', "");
            letterOccurence.Add('b', "");
            letterOccurence.Add('c', "");
            letterOccurence.Add('d', "");
            letterOccurence.Add('e', "");
            letterOccurence.Add('f', "");
            letterOccurence.Add('g', "");
            letterOccurence.Add('h', "");
            letterOccurence.Add('i', "");
            letterOccurence.Add('j', "");
            letterOccurence.Add('k', "");
            letterOccurence.Add('l', "");
            letterOccurence.Add('m', "");
            letterOccurence.Add('n', "");
            letterOccurence.Add('o', "");
            letterOccurence.Add('p', "");
            letterOccurence.Add('q', "");
            letterOccurence.Add('r', "");
            letterOccurence.Add('s', "");
            letterOccurence.Add('t', "");
            letterOccurence.Add('u', "");
            letterOccurence.Add('v', "");
            letterOccurence.Add('x', "");
            letterOccurence.Add('y', "");
            letterOccurence.Add('z', "");
            letterOccurence.Add('å', "");
            letterOccurence.Add('ä', "");
            letterOccurence.Add('ö', "");   
        }

        

        //static void CountLetters(<Dictionary<char, string> letterOccurence)
    }


}
