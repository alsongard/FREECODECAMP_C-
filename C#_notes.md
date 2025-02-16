# Getting Started
To create a new C# project do the following:
```
dotnet new console -o MyApp
```

In Program.cs === which is the main file for writting the program code do the following:
```
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Follow, LinuxTLDR!");
    }
}
```
To run the C# file use the following command: dotnet run


### Output 
To display an output or write sth on the terminal use:
```
Console.WriteLine("hello World");
```
The ``Console.WriteLine()`` is used to display output.


### Variables
integer : int (wholenumbers)
decimal numbers : float, double, decimal(most accurate)
string : string | ""
character : char | ''
boolean : true | false


### working with strings
\n : new line character
\t : tab
escaping characters : \use backslash

### concatenation
appending one string to another string or a variable or one variables to another string
In concatenation we use (+) positive sign.

#### **String attributes**
stringVariable.Length
the Lenght property returns the length fo the string
method: this  is a piece of code that perform's a specific tasks.

#### **String method**
.ToUppter()
.ToLower()
.IndexOf() : returns the indexof the given keyword
.Contains("academy") : returns true or false if string is found in the variableString
.subString() : the subString method is used to grap a string from the given index. 

String Indexing:
``phrase[0]`


### **Getting User Input**
To get user input, use the ReadLine() method.
``Console.ReadLine()``
Example:
```
string full_name = ;
Console.Write("Enter full name:"); // prints out the statement and does not create new line
full_name = Console.ReadLine();
```

### **Arrays**
To declare an array, there are 2 ways:
```
int[] myNUmbers = {1, 2, 3};

//OR
int[] myNumbers = new int[20];
```


### **Functions**
Getting started with functions:
return type : declare the return type
type of function :
    static - it can be accessed in main function without declaring an instance
    non-static functions: need to be accessed using an instance

```
class MyProgram()
{
    static void Main()
    {   
        Console.Write("Enter one of your favorite Car brand: ");
        string favoriteCarBrand = Console.ReadLine();

        getCarDetails(favoriteCarBrand); // this is a static method just call in your main function 

        // accessing non-static function
        // create an instance of the class
        MyProgram myProgramInstance = new MyProgram();
        myProgramInstance.GetSpeed(390);
    }
    static void getCarDetails(string carBrand)
    {
        Console.WriteLine("Car Brand name is " + carBrand);
    }
    void GetSpeed(int speed)
    {
        Console.WriteLine("The cars speed is " + speed);
    }

}
```            

### **Return**
The return is value that is returned from running a function can be of any data type.
previously we have being using void which means return nothing.
```
static int myAge(int birthYear)
{
    int age = DateTime.Now.Year - birthYear;
    return age;
}
Console.WriteLine(myAge(2001))
```

### **Classes**
A class is a container
