// See https://aka.ms/new-console-template for more information
using System;

namespace functions
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Getting started with functions");
            Greeting("Remember Me");

            // GetYear is a non-static method that can be accessed using instance
            Program programInstance = new Program();
            int birthYear = programInstance.GetYear(25);
            Console.WriteLine("She was born in " + birthYear);


            Console.Write("Enter one of your favorite Car brand: ");
            string favoriteCarBrand = Console.ReadLine() ?? "";

            getCarDetails(favoriteCarBrand); // this is a static method just call in your main function 

            // accessing non-static function
            // create an instance of the class
            programInstance.GetSpeed(390);
        }

        static void Greeting(string name)
        {
            Console.WriteLine("Hello Mr/Mrs " + name);
        }
        int GetYear(int age)
        {
            int currentYear = DateTime.Now.Year;
            int birth_year = currentYear - age;
            Console.WriteLine(currentYear - age);
            return birth_year;
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
}