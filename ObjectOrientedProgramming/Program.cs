using OOP.MethodOverloading;
using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyClass myCall = new MyClass(101,"Introduction to IT");
            BasicCalulation basicCalulation = new BasicCalulation();

            Console.WriteLine(basicCalulation.Summation(5.50, 5.50));

            Console.ReadKey();
        }
    }
}
