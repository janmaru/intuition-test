using System;
using System.Collections.Generic;
using System.Linq;

namespace Intuition.Technical.Questions.Question1
{
    public class RepositoryEmployee : IRepositoryEmployee
    {
        private static SortedDictionary<int, Employee> employees =
            new SortedDictionary<int, Employee>();

        void IRepositoryEmployee.AddEmployee(Employee employee)
        {
            if (!(employees.TryAdd(employee.EmployeeID, employee)))
                throw new EmployeetAlreadyExistentException($"The employee with ID: {employee.EmployeeID} is already in the collection.");
        }

        Employee IRepositoryEmployee.GetEmployee(int employeeID)
        {
            Employee employee = null;
            if (!(employees.TryGetValue(employeeID, out employee)))
                throw new EmployeetNotFoundException($"The employee with ID: {employee.EmployeeID} is missing from the collection.");
            return employee;
        }

        Employee[] IRepositoryEmployee.GetOrderedEmployeeArray()
        {
            return employees.Values.ToArray();
        }
    }
}
