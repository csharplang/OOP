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

### Uses
* A Math class with all static methods. Static classes are useful and provide an easy way to access its members that does not need to work differently for different objects. 
* Above MyStaticClass class. We know the value of MyStaticClass class members will never change regardless of its objects.
* App Configuration class that has all static settings about an app and the values of settings don’t change based on the objects or users.
* A DatabaseConfig class that may have members such as database name, server name, port number, and even a connection string. We know that these values will not change for objects. 
