﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spo12h.Progr2.Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(firstName: "Andreas", lastName: "Lefkopoulos", department: "EC Faculty");

            Console.WriteLine( "Employee Info\n\n" +
                               "First Name: {0}\n" +
                               "Last Name: {1}\n"+
                               "Department: {2}\n", emp1.FirstName, emp1.LastName, emp1.Department);

            Console.ReadLine();

        }

        public class Employee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Department { get; set; }

            public Employee(string firstName, string lastName, string department)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Department = department;
            }
        }
    }
}
