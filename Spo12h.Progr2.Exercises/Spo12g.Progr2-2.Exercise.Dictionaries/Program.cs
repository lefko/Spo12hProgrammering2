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
        static void Main(string[] args)
        {
            Application();

            Console.ReadLine();

        }


        private static void Application()
        {
            var letterOccurrence = new Dictionary<char, string>();

            

            // Adds the swedish alfabet to the Dictionary
            //letterOccurrence.Add('a', "");
            //letterOccurrence.Add('b', "");
            //letterOccurrence.Add('c', "");
            //letterOccurrence.Add('d', "");
            //letterOccurrence.Add('e', "");
            //letterOccurrence.Add('f', "");
            //letterOccurrence.Add('g', "");
            //letterOccurrence.Add('h', "");
            //letterOccurrence.Add('i', "");
            //letterOccurrence.Add('j', "");
            //letterOccurrence.Add('k', "");
            //letterOccurrence.Add('l', "");
            //letterOccurrence.Add('m', "");
            //letterOccurrence.Add('n', "");
            //letterOccurrence.Add('o', "");
            //letterOccurrence.Add('p', "");
            //letterOccurrence.Add('q', "");
            //letterOccurrence.Add('r', "");
            //letterOccurrence.Add('s', "");
            //letterOccurrence.Add('t', "");
            //letterOccurrence.Add('u', "");
            //letterOccurrence.Add('v', "");
            //letterOccurrence.Add('x', "");
            //letterOccurrence.Add('y', "");
            //letterOccurrence.Add('z', "");
            //letterOccurrence.Add('å', "");
            //letterOccurrence.Add('ä', "");
            //letterOccurrence.Add('ö', "");
            
            string input = getInput();
            input = input.ToLower();

            foreach (char c in input)
            {
                if (!letterOccurrence.ContainsKey(c))
                    letterOccurrence.Add(c, "");
       
            }

            foreach (char c in input)
            {
                if (letterOccurrence.ContainsKey(c))
                {
                    string value = "";
                    value = letterOccurrence[c];
                    value = value + "*";
     
                    letterOccurrence[c] = value;
                }
            }

            foreach (var pair in letterOccurrence)
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
    }


}
