using System;

namespace Spo12h.Progr2.Exercise15
{
    /// <summary>
    /// This class contains ALL presentational logic
    /// </summary>
    public class MainMenuSystem
    {
        // Field
        private PersonnelRegistry registry;

        public MainMenuSystem()
        {
            registry = new PersonnelRegistry();
        }

        /// <summary>
        /// Call this to start the application
        /// </summary>
        public void Start()
        {
            bool running = true;

            while (running)
            {
                ShowMainMenu();
                var choice = Console.ReadLine();

                if (choice != "5")
                {
                    TakeAction(choice);
                }
                else
                    running = false;
            }
        }

        /// <summary>
        /// Take a certain action from the main menu
        /// </summary>
        /// <param name="choice"></param>
        private void TakeAction(string choice)
        {
            switch (choice)
            {
                case "1":
                    AddEmployeeDialog();
                    break;

                case "2":
                    DeleteEmployeeDialog();
                    break;

                case "3":
                    PrintAllEmployeesDialog();
                    break;

                case "4":
                    FilteredSearchDialog();
                    break;

                default:
                    Console.WriteLine("Invalid choice! Press enter...");
                    Console.ReadLine();
                    break;
            }
        }

        private void FilteredSearchDialog()
        {
            Console.Clear();
            Console.Write("Enter year of birth [YY]: ");

            try
            {
                var yearOfBirth = int.Parse(Console.ReadLine());
                Console.WriteLine();

                var filtered = registry.GetEmployeesBornAt(yearOfBirth);

                foreach (var employee in filtered)
                {
                    PrintEmployee(employee);
                }
            }
            catch (FormatException exc)
            {
                Console.WriteLine("Not a valid search term.");
            }

            Console.ReadLine();
        }

        private void PrintEmployee(Employee employee)
        {
            Console.WriteLine("Social security number : " + employee.SocialSecurityNumber);
            Console.WriteLine("Name                   : " + employee.FullName);
            Console.WriteLine("Hourly wage            : " + employee.HourlyWage);
            Console.WriteLine();
        }

        /// <summary>
        /// Loop through all employees and print
        /// </summary>
        private void PrintAllEmployeesDialog()
        {
            var allEmployees = registry.GetAllEmployees();

            Console.Clear();
            Console.WriteLine("EMPLOYEES");
            Console.WriteLine("---------");
            Console.WriteLine();

            foreach (var employee in allEmployees)
            {
                PrintEmployee(employee);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Ask the user for employee details
        /// </summary>
        private void AddEmployeeDialog()
        {
            Console.Clear();

            Console.Write("First name: ");
            var fName = Console.ReadLine();

            Console.Write("Last name: ");
            var lName = Console.ReadLine();

            Console.Write("Social security number: ");
            var ssn = Console.ReadLine();

            Console.Write("Hourly wage: ");
            var wage = 0;
            try
            {
                wage = int.Parse(Console.ReadLine());
            }
            catch (FormatException exc)
            {
                Console.WriteLine("Wage was incorrect. Employee will be added without wage!!! ");
            }

            //Employee employee;
            try
            {
                 var employee = new Employee(fName, lName, ssn, wage);
                 registry.AddEmployee(employee);
                 Console.WriteLine("Added employee!");
            }
            catch (ArgumentOutOfRangeException exc)
            {
                Console.WriteLine(exc.Message);
            }

            
            
            Console.ReadLine();
        }

        /// <summary>
        /// Ask the user for a social security number and remove that user
        /// </summary>
        private void DeleteEmployeeDialog()
        {
            Console.Clear();
            
            Console.Write("Social security number: ");
            var ssnToRemove = Console.ReadLine();

            bool removed = registry.RemoveEmployee(ssnToRemove);

            if (removed)
                Console.WriteLine("Removed user with number {0}", ssnToRemove);
            else
                Console.WriteLine("Could not find employee with number {0}!", ssnToRemove);

            Console.ReadLine();
        }

        /// <summary>
        /// Print the main menu
        /// </summary>
        private void ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Add employee");
            Console.WriteLine("2. Remove employee");
            Console.WriteLine("3. Print entire registry");
            Console.WriteLine("4. Show filtered search");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
            Console.Write("Enter choice: ");
        }
    }
}