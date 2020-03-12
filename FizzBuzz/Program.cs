using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int iMax;
            NewTry:
            try
            {
                Console.Clear(); 
                Console.Write("Give any number between 8 and 50: ");
                input = Console.ReadLine();
                iMax = Int32.Parse(input);
                if (iMax > 50 || iMax < 8) goto NewTry;
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{input}' to an integer! Press a key to try again...");
                Console.ReadLine();
                goto NewTry;
            }

            for (int i = 1; i <= iMax; i++)
            {
                if (i % 3 + i % 4 == 0)
                {
                    Console.Write(i + "=FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.Write(i + "=Fizz");
                }
                else if (i % 4 == 0)
                {
                    Console.Write(i + "=Buzz");
                }
                else
                {
                    Console.Write(i);
                }
                if (i != iMax) Console.Write(", ");
            }

            Console.WriteLine("\n\nGreetings! You've just ended the FizzBuzz " + 1 + " to " + iMax +" with flying colors... press a key to close...");
            Console.Read();
        }
    }
}
