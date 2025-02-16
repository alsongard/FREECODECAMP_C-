// See https://aka.ms/new-console-template for more information
using System;

namespace Part_2
{
    class Program
    {
        static void Main()
        {
            int[] myArray = {12, 14, 16, 18, 20, 22, 24};

            Console.WriteLine(myArray[0]); // accessing values using indexing

            // arrays are mutable, meaning it's values can be changed
            myArray[0] = 200;
            Console.WriteLine(myArray[0]);

            string[] languages = new string[10];

            languages[0] = "C#";
            languages[1] = "C++";
            languages[2] = "Python";
            languages[3] = "JavaScript";
            languages[4] = "NodeJS";

            string[] other_languages = {"HTML", "CSS3", "Java", "React", "NextJS"};

            for (int i = 0; i < other_languages.Length; i++)
            {
                languages[i+5] = other_languages[i];
            }
            foreach(string developer_language in languages)
            {
                Console.WriteLine(developer_language);
            }
        }
    }
}