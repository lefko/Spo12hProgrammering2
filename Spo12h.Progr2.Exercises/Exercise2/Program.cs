using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
       

        static void Main(string[] args)
        {
            
            Person person1 = new Person();

            GenerateInitialView();

            person1.Name = AskForUserInputName();
            person1.Workplace = AskForUserInputWorkplace();
            person1.CurrentAge = AskForUserInputAge();
            person1.JobTitle = AskForUserInputJobTitle();
            Console.WriteLine();

            DisplayPersonInfo(person1);

            Console.ReadLine();
        }

        #region -------- METHODS --------

        public static void GenerateInitialView()
        {
            Console.WriteLine("#############################################");
            Console.WriteLine("############### Exercise 2 ##################");
            Console.WriteLine("#############################################");
            Console.WriteLine();

        }

       
        public static string AskForUserInputName()
        {
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();

            return name;
        }

        public static string AskForUserInputWorkplace()
        {
            Console.Write("Enter name of Worplace: ");
            string workplace = Console.ReadLine();

            return workplace;
        }

        public static Age AskForUserInputAge()
        {
            Console.Write("Enter your Age: ");
            int age;
            

            bool success = int.TryParse(Console.ReadLine(), out age);
            

            // TODO: Try parsing to a number and return it. else return message

            return new Age(age);
        }

        public static string AskForUserInputJobTitle()
        {
            Console.Write("Enter your Job Title: ");
            string jobTitle = Console.ReadLine();

            return jobTitle;
        }

        public static int CalculateYearOfBirth(int age)
        {

            int YearOfBirthearOfBirth = DateTime.Now.Year - age;

            return YearOfBirthearOfBirth;
        }

        public static void DisplayPersonInfo(Person person)
        {
            int yearOfBirth = CalculateYearOfBirth(person.CurrentAge.GetAge());


            Console.WriteLine("Hello {0},", person.Name);

            Console.WriteLine("You are {0} years old which means that you were born in {1}.", person.CurrentAge.GetAge(), yearOfBirth);
            Console.WriteLine("You work at {0}, where \"{1}\" is your title.", person.Workplace, person.JobTitle);
        }

        #endregion
    }
}
