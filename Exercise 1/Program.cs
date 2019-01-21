using System;

namespace Exercise 2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 2// Input a number (n) from the user and check if it is even or odd.// Write your code here
            Console.WriteLine("Input a number : ");
            string Input = Console.ReadLine();
            int numbr_1 = int.Parse(Input);
            if (numbr_1 % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("odd number");
            }
            Console.ReadKey();




        }
    }
}
