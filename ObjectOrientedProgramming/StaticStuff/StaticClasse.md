# Static classe

### Main Feature
* Static classes cannot be instantiated.
* Static classes contain only static members.
* Static classes are sealed. That means, you cannot inherit other classes from instance classes. 
* Static classes cannot contain Instance Constructors.

### Example
```CSharp
public static class MyStaticClass
    {
        // Static fields  
        public static string FirstName = "R M Shahidul Islam";
        public static string LastName = "Shahed";
        public static string Designation = "Project Manger";
        public static DateTime DateofBirth = new DateTime(1987, 06, 01);
        public static string Country = "Bangladesh";
        
        // Static method  
        public static int Summation(int x, int y) => x + y;
    }
```