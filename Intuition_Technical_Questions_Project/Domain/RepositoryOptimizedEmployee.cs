using System;
using System.Collections.Generic;
using System.Linq;

namespace Intuition.Technical.Questions.Question1
{
    public class RepositoryOptimizedEmployee : IRepositoryEmployee
    {
        private static SortedDictionary<int, Employee> employees =
            new SortedDictionary<int, Employee>();
        private static Employee[] arrayOfEmployees;

        void IRepositoryEmployee.AddEmployee(Employee employee)
        {
            if (!(employees.TryAdd(employee.EmployeeID, employee)))
                throw new EmployeetAlreadyExistentException($"The employee with ID: {employee.EmployeeID} is already in the collection.");
            else
                arrayOfEmployees = employees.Values.ToArray();
        }

        Employee IRepositoryEmployee.GetEmployee(int employeeID)
        {
            Employee employee = Array.Find(arrayOfEmployees,
                       e => e.EmployeeID == employeeID);
            if (employee == null)
                throw new EmployeetNotFoundException($"The employee with ID: {employee.EmployeeID} is missing from the collection.");

            return employee;
        }

        Employee[] IRepositoryEmployee.GetOrderedEmployeeArray()
        {
            return arrayOfEmployees;
        }
    }
}
