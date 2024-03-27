using System;

namespace DepedencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var ebl = new EmployeeBusinessLogic();
            var ed = ebl.GetEmployeeDetails(1);
            Console.WriteLine(ed.Name);
            Console.ReadLine();
        }
    }
}
