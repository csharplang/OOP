using System;

namespace OOP.Constructor
{
    class Examples
    {
    }

    //Default contructor
    class Addition
    {
        int a, b;
        public Addition()   //default contructor
        {
            a = 100;
            b = 175;
        }
    }

    //Parameterized Constructor
    class ParameterizedConstructor
    {
        public int a, b;
        public ParameterizedConstructor(int x, int y)  // decalaring Paremetrized Constructor with ing x,y parameter
        {
            a = x;
            b = y;
        }
    }

    //Copy Constructor
    class employee
    {
        private string name;
        private int age;
        public employee(employee emp)   // declaring Copy constructor.
        {
            name = emp.name;
            age = emp.age;
        }
        public employee(string name, int age)  // Instance constructor.
        {
            this.name = name;
            this.age = age;
        }
        public string Details     // Get deatils of employee
        {
            get
            {
                return " The age of " + name + " is " + age.ToString();
            }
        }

        public static void CopyConstructorIMP()
        {
            employee emp1 = new employee("Vithal", 23);  // Create a new employee object.
            employee emp2 = new employee(emp1);          // here is emp1 details is copied to emp2.
            Console.WriteLine(emp2.Details);
        }
    }

    //Static Constructor
    public class StaticConstructor
    {
        static StaticConstructor()
        {
            Console.WriteLine("The static constructor ");
        }
        public static void Salary()
        {
            Console.WriteLine();
            Console.WriteLine("The Salary method");
        }

        public static void StaticConstructorIMP()
        {
            Console.WriteLine("----------Static constrctor example by vithal wadje------------------");
            Console.WriteLine();
            Salary();
            Console.ReadLine();
        }
    }


    //Private Constructor
    public class Counter
    {
        private Counter()   //private constrctor declaration
        {
        }
        public static int currentview;
        public static int visitedCount()
        {
            return ++currentview;
        }

        public static void PrivateConstructorIMP()
        {
            //Counter aCounter = new Counter();   // Error
            Console.WriteLine("-------Private constructor example by vithal wadje----------");
            Console.WriteLine();
            currentview = 500;
            visitedCount();
            Console.WriteLine("Now the view count is: {0}", Counter.currentview);
            Console.ReadLine();
        }
    }
}
