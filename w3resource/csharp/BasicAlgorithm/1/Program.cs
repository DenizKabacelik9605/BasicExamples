//compute the sum of two given integer values.If the values are the same, then return triple their sum.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicAlgorithm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine($"Result {p.MyMethod()}");

        }

        public int MyMethod()
        {
            int num1, num2, result;
            Console.WriteLine("Enter the first number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            num2 = int.Parse(Console.ReadLine());
            return num1 != num2 ? num1 + num2 : (num1 + num2) * 3;
           //alternative 
        //    if(num1 != num2)
        //    {
        //       result=num1 + num2;
        //    }
        //    else{
        //      result=(num1 + num2) * 3;
        //    }
        //    return result;

        }
    }
}

