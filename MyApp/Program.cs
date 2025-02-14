using System;

namespace MyApp
{


	class Program
	{	
		static void Main()
		{
			Console.WriteLine("Follow, LinuxTLDR");

			Console.WriteLine("    /|");
			Console.WriteLine("   / |");
			Console.WriteLine("  /  |");
			Console.WriteLine(" /   |");
			Console.WriteLine("/	|");
			Console.WriteLine("------");

		// working with variables

		string userName = "Jarvis";
		int userAge = 25;
		string location = "Dalas";
		Console.WriteLine("The young man's name is " +  userName);
		Console.WriteLine("The young mans age is " + userAge + " years old");
		Console.WriteLine("The young man lived in " + location);

		char singleLetter = 'c';
		double luckyNumber =  12.10;
		bool isMale = true;

		Console.WriteLine("singleLetter value is " + singleLetter);
		Console.WriteLine("luckyNumber value is " + luckyNumber);
		Console.WriteLine("Boolean isMale is " + isMale);


		string myPhrase = "Good Morning";
		Console.WriteLine(myPhrase);

		Console.WriteLine(myPhrase.Substring(4));

		// indexing
		Console.WriteLine(myPhrase[5] + "My friend");
		
		// the Substring method can also take 2 arguments
		Console.WriteLine(myPhrase.Substring(5, 3) + "Gardens");

		
		// INTEGERS AND DECIMALS
		Console.WriteLine("Multiplication of 5 by 8 is:" +  5 * 8 );
		Console.WriteLine("Division of 5 by 2 is:" + 5 / 2);
		Console.WriteLine("Difference of 5 to  8 is:" + " " + (5 - 8));
		Console.WriteLine("Addition of 5 and 8 is: " + (5 + 8));
		Console.WriteLine("Modulus returns remainder : " + 5 % 2);


		double result = 5 / 2.0;
		Console.WriteLine(result);

		// incrementing and decrementing
		int myNewNumber = 10;
		myNewNumber--;

		Console.WriteLine("Value after decrementing " + myNewNumber);
		myNewNumber++;
		Console.WriteLine("Value after incremeting " + myNewNumber);

		// Math Methods
		Console.WriteLine("Using Math.Abs() method which returns the absolute value " + Math.Abs(-40));
		Console.WriteLine("Using the Math.Pow() method which is used for power, takes 2 arguments, number and power " + Math.Pow(2, 3));

		Console.WriteLine("Math.Pow() method also works with decimals " + Math.Pow(2.2, 4));
		Console.WriteLine("Math.Sqrt() which returns the squaroot of a value " +  Math.Sqrt(16));

		Console.WriteLine("Math.Max() returns the larget Value " + Math.Max(10,12));
		Console.WriteLine("Math.Min() returns the smallest value :" + Math.Min(12, 11));
		Console.WriteLine("Math.Round() rounds of a decimal to a whole number: " + Math.Round(20.49));

		// Write() prints out the string or statement in the paranthesis and does not move to a new line
		Console.Write("Today is: ");
		Console.WriteLine("Friday");

		// Geting  User input
		Console.Write("Enter your name: ");
		string myName = Console.ReadLine() ?? "";
		Console.WriteLine("Hello Hello " + myName);


		}	
	}
}
