using RandomNameGeneratorLibrary;
using System;

namespace RandomNameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var personGenerator = new PersonNameGenerator();
                var name = personGenerator.GenerateRandomFirstAndLastName();

                Console.WriteLine(name);
                string end = Console.ReadLine();
                if (end == "exit")
                {
                    break;
                }
            }
        }
    }
}
