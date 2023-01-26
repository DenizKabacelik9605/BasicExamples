using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//swap  to numbers

namespace _3
{
    public class Program
    {

        public static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.WriteLine("enter the first number");

            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            num2 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine($" After Swapping");
            Console.WriteLine($"First number {num1} Second Number {num2}");

        }


    }


}