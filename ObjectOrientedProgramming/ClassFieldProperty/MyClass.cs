using System;

namespace OOP.ClassFieldProperty
{
    //public=Access Modifier, MyClass=Class Name
    public class MyClass
    {
        //Field
        public long MyFieldSumm = 0;
        //Contructor
        public MyClass(int Parameter01, string Parameter02)
        {
            Console.WriteLine("First Parameter {0}, second Parameter {1}", Parameter01, Parameter02);
        }


        //Method/Function
        public long MyMethod(long x, long y)
        {
            MyFieldSumm = x + y;
            return MyFieldSumm;
        }

        //Auto implemented property
        public string FirstName { get; set; }
        public string LastName { get; set; }


        //Property
        private int myPropertyVar;

        public int MyProperty
        {
            get { return myPropertyVar; }
            set { myPropertyVar = value; }
        }
    }
}
