using System;

namespace Gender
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write m for male, f for female.");
            string userInput = Console.ReadLine();
            Hello(userInput);


        }
        public static void Hello(string gender)
        {
            if(gender == "f")
            {
                Console.WriteLine("Hello, madam");
            }else if (gender == "m")
            {
                Console.WriteLine("Hello, sir");
            }else
            {
                Console.WriteLine("Hello, magical swede");
            }
        }
    }
}
