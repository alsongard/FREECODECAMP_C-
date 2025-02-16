// See https://aka.ms/new-console-template for more information
namespace calculator
{
	class Program
	{
		static void Main(string [] args)
		{
			

			// EXAMPLE OF THE CALCULATOR METHOD
			// to convert a string into an interger we use the
			// Convert.Tomethod() 

			int first_number =  Convert.ToInt32("43");
			int second_number = Convert.ToInt32("87");

			Console.WriteLine(first_number + second_number);

			// GET USER INPUT
			double userValue_1;
			double userValue_2;

			Console.Write("Enter any number that comes to mind: ");
			userValue_1 = Convert.ToDouble(Console.ReadLine());

			Console.Write("Enter any second number: ");
			userValue_2 = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Select either of the following signs: \n 1: + \n 2: - \n 3: *  \n 4: / \n 5: %");
			int signSymbol = Convert.ToInt32(Console.ReadLine());

			if (signSymbol == 1)
			{
				Console.WriteLine("Performing addition of : " + userValue_1 + " and " + userValue_2);
				Console.WriteLine(userValue_1 + userValue_2);
			}
			else if (signSymbol == 2)
			{
				Console.WriteLine("Performing subtraction of : " + userValue_1 + " and " + userValue_2);
				Console.WriteLine(userValue_1 - userValue_2);
			}
			else if (signSymbol == 3)
			{
				Console.WriteLine("Performing multiplication of : " + userValue_1 + " and " + userValue_2);
				Console.WriteLine(userValue_1 * userValue_2);
			}
			else if (signSymbol == 4)
			{
				Console.WriteLine("Performing division of : " + userValue_1 + " and " + userValue_2);
				Console.WriteLine(userValue_1 / userValue_2);
			}
			else if (signSymbol == 5)
			{
				Console.WriteLine("Performing modulus of : " + userValue_1 + " and " + userValue_2);
				Console.WriteLine(userValue_1 % userValue_1);
			}

			
		}
	}
}
