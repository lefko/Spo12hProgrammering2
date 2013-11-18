using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spo12h.Progr2.Exercise10
{
    class EmployeeCatalog

    {
        List<Employee> employees = new List<Employee>();
        private readonly ILog logger;

        public EmployeeCatalog(ILog log)
        {
            logger = log;
            logger.AddToLog("New log created");
        }
        
        

        public bool AddEmployee(Employee newEmployee)
        {
            Employee foundEmployee = FindEmployee(newEmployee.SocialSecurityNumber);

            if (foundEmployee == null)
            {
                Employee employeeToAdd = new Employee(newEmployee.FirstName, newEmployee.LastName, newEmployee.SocialSecurityNumber);
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
