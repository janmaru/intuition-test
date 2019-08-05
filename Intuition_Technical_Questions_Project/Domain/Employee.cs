namespace Intuition.Technical.Questions.Question1
{
    public class Employee
    {
        public readonly int EmployeeID;
        public readonly string FirstName;
        public readonly string LastName;

        public Employee(int employeeID, string firstName, string lastName)
        {
            this.EmployeeID = employeeID;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
