using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Spo12h.Progr2.Exercise7
{
    class Program
    {
        

        static void Main(string[] args)
        {
            var catalog = new EmployeeCatalog(new Logger());

            string choice = "0";

            while (choice != "4")
            {
                PrintMenu();
                choice = CollectUsersChoice(catalog);


            }




            string fNameOfEmployeeToAdd = Console.ReadLine();
            string lNameOfEmployeToAdd = Console.ReadLine();
            string socSecOfEmployeeToAdd = Console.ReadLine();
            
            





        }


        #region //Display Methods
        private static void ConsoleSettings()
        {
            Console.SetWindowSize(80, 30);
            Console.Title = " * * *  My ATM  * * * ";
        }
        private static void PrintMenu()
        {
            Console.WriteLine("\nSelect an option");
            Console.WriteLine("----------------\n");
            Console.WriteLine("1) Add employee");
            Console.WriteLine("2) Remove employee");
            Console.WriteLine("3) Print entire registry");
            Console.WriteLine("4) Exit\n");
        }
        #endregion

        #region //User Input Methods
        private static string CollectUsersChoice(EmployeeCatalog catalog)
        {
            Console.Write("Your choice: ");
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    AddEmployee(catalog); 
                    break;
                case "2": 
                    RemoveEmployee(catalog);
                    break;
                case "3": 
                    PrintEntireRegistry(catalog);
                    break;
                case "4": Console.WriteLine("Bye!");
                    break;
                default: Console.WriteLine("Bad choice, try again!");
                    break;
            }
            return input;
        }

        private static void AddEmployee(EmployeeCatalog catalog)
        {
             Employee newEmployee = GetInput();
             bool isSuccess = catalog.AddEmployee(newEmployee);
             DisplayAddEmployeeResultMessage(isSuccess);     
        }

        private static void RemoveEmployee(EmployeeCatalog catalog)
        {
            string socSecNrForRemove = GetInputForRemove();
            bool isSuccess = catalog.RemoveEmployee(socSecNrForRemove);
            DisplayRemoveEmployeeResultMessage(isSuccess);
        }

        private static void DisplayAddEmployeeResultMessage(bool isSuccess)
        {
            if (isSuccess)
                Console.WriteLine("\nEmployee successfully Added!");
            else
                Console.WriteLine("\nEmployee already exists!");
        }

        private static void DisplayRemoveEmployeeResultMessage(bool isSuccess)
        {
            if (isSuccess)
                Console.WriteLine("\nEmployee successfully Removed!");
            else
                Console.WriteLine("\nEmployee doesn't exist!");
        }

        private static void PrintEntireRegistry(EmployeeCatalog catalog)
        {
            List<Employee> allEmployees = catalog.GetAllEmployees();
            foreach (Employee Employee in allEmployees)
            {
                Console.WriteLine(Employee.ToString());
            }
        }

        private static Employee GetInput()
        {
            
            Console.Write("\nFirst Name: ");
            string firstName = GetFirstName();
            Console.Write("\nLast Name: ");
            string lastName = GetLastName();
            Console.Write("\nSocial Security Number: ");
            string socialSecurityNumber = GetSocialSecurityNumber();

            Employee newEmployee = new Employee(firstName, lastName, socialSecurityNumber);


            return newEmployee;
        }

        private static string GetInputForRemove()
        {
            Console.Write("\nSocial Security Number: ");
            string socialSecurityNumber = GetSocialSecurityNumber();
            return socialSecurityNumber;
        }

        private static string GetFirstName()
        {
            string fName;
            fName = Console.ReadLine();

            return fName;
        }

        private static string GetLastName()
        {
            string lName;
            lName = Console.ReadLine();

            return lName;
        }

        private static string GetSocialSecurityNumber()
        {
            string socSecNr = "";
            socSecNr = Console.ReadLine();

            return socSecNr;
        }

        #endregion




    }
}
