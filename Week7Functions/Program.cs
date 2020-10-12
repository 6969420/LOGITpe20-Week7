using System;

namespace Week7Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your year of birth:");
            string userInput = Console.ReadLine();
            CalculateAge(userInput);
        }

        public static void CalculateAge(string yearOfBirth)
        {
            int usersYearOfBirth = Int32.Parse(yearOfBirth);
            Console.WriteLine($"Your are {2020 - usersYearOfBirth} years old");
        }
    }
}
