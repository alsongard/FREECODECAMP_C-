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
``phrase[0]``


``Console.ReadLine()``

### **Classes**
A class is a container