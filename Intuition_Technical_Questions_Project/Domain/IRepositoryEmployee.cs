namespace Intuition.Technical.Questions.Question1
{
    public interface IRepositoryEmployee
    {
        void AddEmployee(Employee employee);

        //changed EmployeeID in employeeID
        Employee GetEmployee(int employeeID);

        //I would suggest changing name to the method
        //without naming after the return type and
        //adding some order parameter

        Employee[] GetOrderedEmployeeArray();
    }
}
