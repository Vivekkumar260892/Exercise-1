using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input side a : ");
            string Input_1 = Console.ReadLine();
            double side_a = double.Parse(Input_1);
            Console.WriteLine("Input side b : ");
            string Input_2 = Console.ReadLine();
            double side_b = double.Parse(Input_2);
            Console.WriteLine("Input side c : ");
            string Input_3 = Console.ReadLine();
            double side_c = double.Parse(Input_3);
            double s = (side_a + side_b + side_c) / 2;
            Console.WriteLine("s = " + s);
            double area = Math.Sqrt(s * (s - side_a) * (s - side_b) * (s - side_c));
            Console.WriteLine("Area is : " + area);
            Console.ReadKey();
            // Exercise 1// Calculate the area of a triangle using Heron's formula
            // Area = SquareRoot(s * (s-a) * (s-b) * (s-c)) where s=(a+b+c)/2 and 
            //a,b,c are the sides of the triangle// Eg. a=3, b=4, c=5. Area = 6
        }
    }
}
