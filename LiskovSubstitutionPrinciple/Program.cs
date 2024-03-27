using System;
using System.Collections.Generic;
namespace LiskovSubstitutionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liskov Substitution Principle Violated");
            Apple apple = new Orange();
            Console.WriteLine(apple.GetColor());
            Console.ReadLine();
        }
    }
}
