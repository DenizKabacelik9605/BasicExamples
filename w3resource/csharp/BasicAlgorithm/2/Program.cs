//get  the absolute difference  between n and 51. If n is greater than 51 return triple the absolute difference.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num, result, tripleResult;
            Console.WriteLine("enter the number");
            num = int.Parse(Console.ReadLine());
            result = 51 - num;
            int absResult= Math.Abs(result);
            if (absResult > 51)
            {
                tripleResult = absResult * 3;
                Console.WriteLine($"triple result {tripleResult}");
            }
            else
            {
                Console.WriteLine($" result {absResult}");
            }

        }
    }
}