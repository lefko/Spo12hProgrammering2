using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spo12h.Progr2.Exercise7
{
    class EmployeeCatalog
    {
        List<Employee> employees = new List<Employee>();

        public bool AddEmployee(string fName, string lName, string socSecNr)
        {
            // TODO: implement method
            Employee foundEmployee = FindEmployee(socSecNr);

            if (foundEmployee == null)
            {
                Employee employeeToAdd = new Employee(fName, lName, socSecNr);
                employees.Add(employeeToAdd);
                return true;
            }
            
            return false;
        }

        public bool RemoveEmployee(string socSecNr)
        {
            Employee foundEmployee = FindEmployee(socSecNr);

            if (foundEmployee != null)
            {
                    employees.Remove(foundEmployee);
                return true;
            }

            return false;
        }

        public List<Employee> GetAllEmployees()
        {
            // TODO: Is this what is to be returned?

            return employees;
        }

        public Employee FindEmployee(string socSecNr)
        {
            Employee foundEmployee = null;

            foreach (Employee employee in employees)
            {
                if (employee.SocialSecurityNumber == socSecNr)
                    foundEmployee = employee;
                break;
            }

            return foundEmployee;
        }
    }
}
