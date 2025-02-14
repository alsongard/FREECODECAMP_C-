// See https://aka.ms/new-console-template for more information
namespace calculator
{
	class Program
	{
		static void Main(string [] args)
		{
			Console.Write("Enter full name:");
			string fullName = Console.ReadLine() ?? "";
			Console.Write("Enter age: ");
			string userAge = Console.ReadLine() ?? "";

			Console.WriteLine("Username is : " + fullName + " age is :" + userAge); 
		}
	}
}
