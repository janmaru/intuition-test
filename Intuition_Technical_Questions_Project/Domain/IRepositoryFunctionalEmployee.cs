using Intuition.Technical.Questions.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Intuition.Technical.Questions.Question1
{
    public interface IRepositoryFunctionalEmployee
    {
        Result<bool, IErrorMessage> AddEmployee(Employee employee);

        Result<Employee, IErrorMessage> GetEmployee(int employeeID);

        Result<Employee[], IErrorMessage> GetOrderedEmployeeArray();
    }
}
