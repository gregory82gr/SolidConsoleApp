using System;

namespace DepedencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeBusinessLogic = new EmployeeBusinessLogic();
            var employee = employeeBusinessLogic.GetEmployeeDetails(1001);
            Console.WriteLine($"ID: {employee.ID}, Name: {employee.Name}, Department: {employee.Department}, Salary: {employee.Salary}");
            Console.ReadLine();
        }
    }
}
