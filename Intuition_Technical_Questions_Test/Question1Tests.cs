using Intuition.Technical.Questions.Question1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FluentAssertions;

namespace Intuition.Technical.Questions.Test
{
    [TestClass]
    public class Question1RepositoryEmployeeTests
    {
        private IRepositoryEmployee repoEmployee = new RepositoryOptimizedEmployee();
        [TestInitialize]
        public void TestInitialize()
        {
            repoEmployee.AddEmployee(new Employee(employeeID: 1, firstName: "John", lastName: "Doe"));
            repoEmployee.AddEmployee(new Employee(employeeID: 5, firstName: "Edgar", lastName: "Poe"));
            repoEmployee.AddEmployee(new Employee(employeeID: 3, firstName: "William", lastName: "Foe"));
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception), AllowDerivedTypes = true)]
        public void AddEmployee_ShouldAddEmployee_ThrowException()
        {
            repoEmployee.AddEmployee(new Employee(employeeID: 1, firstName: "John", lastName: "Doe"));
        }

        [TestMethod]
        public void GetEmployee_ShouldGetEmployee_EmployeeIDisOne()
        {
            var e1 = repoEmployee.GetEmployee(1);
            var e2 = new Employee(employeeID: 1, firstName: "John", lastName: "Doe");
            e1.Should().BeEquivalentTo(e2);
        }

        [TestMethod]
        public void GetOrderedEmployeeArray_ShouldGetOrderdArray_true()
        {
            var list = repoEmployee.GetOrderedEmployeeArray();
            var first = list[0].EmployeeID == 1? true: false;
            var second = list[1].EmployeeID == 3 ? true : false;
            var third = list[2].EmployeeID == 5 ? true : false;
            Assert.IsTrue(first && second && third);   
        }
    }
}
