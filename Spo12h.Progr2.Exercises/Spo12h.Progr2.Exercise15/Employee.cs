using System;

namespace Spo12h.Progr2.Exercise15
{
    /// <summary>
    /// This class describes an employee
    /// </summary>
    public class Employee
    {
        //fields

        
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SocialSecurityNumber { get; set; }
        private int hourlyWage;

        public int HourlyWage

        {
            get { return hourlyWage; }
            set
            {
                if (value >= 0)
                    hourlyWage = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
            
        }

        

        public string FullName
        {
            get { return string.Format("{0} {1}", FirstName, LastName); }
        }

        // Constructor #1
        public Employee(string firstName, string lastName, string socialSecurityNumber, int hourlyWage)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
            try
            {
                HourlyWage = hourlyWage;
            }
            catch (ArgumentOutOfRangeException exc)
            {
                Console.WriteLine("You entered a wage bellow zero. Not OK dude!!");
                throw;
            }
        }

        // Constructor #2
        public Employee(string socialSecurityNumber)
        {
            SocialSecurityNumber = socialSecurityNumber;
        }
    }
}