using System;

namespace OOP.AbstractClass.WithAbstractClass
{
    public static class Execute
    {
        public static void Run()
        {
            FullTimeEmployee fte = new FullTimeEmployee()
            {
                ID = 101,
                FirstName = "David",
                LastName = "Pie",
            };

            Console.WriteLine(fte.GetFullName());
            Console.WriteLine(fte.GetMonthlySalary());
        }
    }
}
