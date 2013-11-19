using System.Collections.Generic;

namespace Spo12h.Progr2.Exercise15
{
    /// <summary>
    /// This class describes a personnel registry
    /// </summary>
    public class PersonnelRegistry
    {
        private Logger logger;
        private List<Employee> employees;

        /// <summary>
        /// Constructor - Used to initialize fields
        /// </summary>
        public PersonnelRegistry()
        {
            employees = new List<Employee>();
            logger = new Logger();
        }

        /// <summary>
        /// Add a new employee to the registry
        /// </summary>
        /// <param name="employee">The employee to add</param>
        public void AddEmployee(Employee employee)
        {
            // Add the employee to the list
            employees.Add(employee);

            // Log that this event happened:
            logger.Log(string.Format("Added employee: {0} {1}", 
                employee.FirstName, employee.LastName));
        }

        public List<Employee> GetAllEmployees()
        {
            return employees;
        }

        /// <summary>
        /// Remove an employee from the registry by using a social security number
        /// </summary>
        /// <param name="ssn">The SSN for the person to remove</param>
        /// <returns>True if removed, otherwise false</returns>
        public bool RemoveEmployee(string ssn)
        {
            // We loop through the entire employees list
            foreach (var employee in employees)
            {
                // We look at every employee until we find one with the matching number
                if (employee.SocialSecurityNumber == ssn)
                {
                    // Remove the employee
                    employees.Remove(employee);

                    // Log that this event happened:
                    logger.Log(string.Format("Removed employee: {0} {1}",
                        employee.FirstName, employee.LastName));

                    // We can return true prematurely - No need to loop further: We're done
                    return true;
                }
            }

            /* If we looped through the entire collection without returning, we didn't remove anything */

            // Log that this event happened:
            logger.Log(
                string.Format("Tried to remove employee with social security number {0}, but failed",
                              ssn));

            // Since it failed, return false
            return false;
        }

        public List<Employee> GetEmployeesBornAt(int year)
        {
            var filteredEmpList = new List<Employee>();

            foreach (var employee in employees)
            {
                if (employee.SocialSecurityNumber.StartsWith(year.ToString()))
                {
                    filteredEmpList.Add(employee);
                }
            }

            return filteredEmpList;
        }
    }
}