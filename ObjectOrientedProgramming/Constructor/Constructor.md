What is constructor?

A special method of the class that will be automatically invoked when an instance of the class is created is called a constructor. The main use of constructors is to initialize private fields of the class while creating an instance for the class. When you have not created a constructor in the class, the compiler will automatically create a default constructor in the class. The default constructor initializes all numeric fields in the class to zero and all string and object fields to null. 

Some of the key points regarding the Constructor are:
•	A class can have any number of constructors.
•	A constructor doesn't have any return type, not even void.
•	A static constructor cannot be a parametrized constructor.
•	Within a class you can create only one static constructor. 
Constructors can be divided into 5 types:
1.	Default Constructor
2.	Parametrized Constructor
3.	Copy Constructor
4.	Static Constructor
5.	Private Constructor 

Static Constructor
When a constructor is created as static, it will be invoked only once for all of instances of the class and it is invoked during the creation of the first instance of the class or the first reference to a static member in the class. A static constructor is used to initialize static fields of the class and to write the code that needs to be executed only once.

Some key points of a static constructor is:
1.	A static constructor does not take access modifiers or have parameters.
2.	A static constructor is called automatically to initialize the class before the first instance is created or any static members are referenced.
3.	A static constructor cannot be called directly.
4.	The user has no control on when the static constructor is executed in the program.
5.	A typical use of static constructors is when the class is using a log file and the constructor is used to write entries to this file.





Private Constructor 
When a constructor is created with a private specifier, it is not possible for other classes to derive from this class, neither is it possible to create an instance of this class. They are usually used in classes that contain static members only. Some key points of a private constructor are:
1.	One use of a private constructor is when we have only static members.
2.	It provides an implementation of a singleton class pattern
3.	Once we provide a constructor that is either private or public or any, the compiler will not add the parameter-less public constructor to the class.
Default Constructor

A constructor without any parameters is called a default constructor; in other words this type of constructor does not take parameters. The drawback of a default constructor is that every instance of the class will be initialized to the same values and it is not possible to initialize each instance of the class to different values. The default constructor initializes:
1.	All numeric fields in the class to zero.
2.	All string and object fields to null.

Parameterized Constructor  
A constructor with at least one parameter is called a parametrized constructor. The advantage of a parametrizedconstructor is that you can initialize each instance of the class to different values.


 Copy Constructor
The constructor which creates an object by copying variables from another object is called a copy constructor. The purpose of a copy constructor is to initialize a new instance to the values of an existing instance.



Ref: 
http://www.c-sharpcorner.com/UploadFile/0c1bb2/constructors-and-its-types-in-C-Sharp/

