using System;

namespace DepedencyInversionPrincipleSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeBusinessLogic = new EmployeeBusinessLogic();
            var employee = employeeBusinessLogic.GetEmployeeDetails(1);
            Console.WriteLine($"ID: {employee.ID}, Name: {employee.Name}, Department: {employee.Department}, Salary: {employee.Salary}");
            Console.ReadLine();
        }
    }
}
