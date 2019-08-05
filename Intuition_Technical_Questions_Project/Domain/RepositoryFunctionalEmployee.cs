using System;
using System.Collections.Generic;
using System.Linq;
using Intuition.Technical.Questions.Core;

namespace Intuition.Technical.Questions.Question1
{
    public class RepositoryFunctionalEmployee : IRepositoryFunctionalEmployee
    {
        private static SortedDictionary<int, Employee> employees =
            new SortedDictionary<int, Employee>();
        private static Employee[] arrayOfEmployees;

        Result<bool, IErrorMessage> IRepositoryFunctionalEmployee.AddEmployee(Employee employee)
        {
            if (!(employees.TryAdd(employee.EmployeeID, employee)))
                return new Result<bool, IErrorMessage>()
                {
                    Success = false,
                    Data = false,
                    Errors = new List<IErrorMessage>() { (IErrorMessage)new EmployeetAlreadyExistentError($"The employee with ID: {employee.EmployeeID} is already in the collection.") },
                };
            else
            {
                arrayOfEmployees = employees.Values.ToArray();
                return new Result<bool, IErrorMessage>()
                { Success = true, Data = true };
            }
        }

        Result<Employee, IErrorMessage> IRepositoryFunctionalEmployee.GetEmployee(int employeeID)
        {
            Employee employee = Array.Find(arrayOfEmployees,
                    e => e.EmployeeID == employeeID);
            if (employee == null)
                return new Result<Employee, IErrorMessage>()
                {
                    Success = false,
                    Errors = new List<IErrorMessage>() { (IErrorMessage)new EmployeeNotFoundError($"The employee with ID: {employee.EmployeeID} is missing from the collection.") },
                };

            return new Result<Employee, IErrorMessage>()
            { Success = true, Data = employee };
        }

        Result<Employee[], IErrorMessage> IRepositoryFunctionalEmployee.GetOrderedEmployeeArray()
        {

            return new Result<Employee[], IErrorMessage>()
            { Success = true, Data = arrayOfEmployees };
        }
    }
}
