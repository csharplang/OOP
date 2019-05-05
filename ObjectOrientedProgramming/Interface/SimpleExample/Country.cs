using System;

namespace OOP.Interface.SimpleExample
{
    class Country : IBangladesh, INetherland, ICanada
    {
        public void Bangladesh()
        {
            Console.WriteLine("Capital of Bangladesh is Dhaka");
        }

        public void Canada()
        {
            Console.WriteLine("Capital of Canada is Ottawa");
        }

        public void Netherland()
        {
            Console.WriteLine("Capital of Netherland is Amsterdam");
        }
    }
}
