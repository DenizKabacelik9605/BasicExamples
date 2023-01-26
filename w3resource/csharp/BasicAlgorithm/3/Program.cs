//check two integer, and return true if one of them is 30 or if their sum is 30


namespace MyNamespace
{
    public class MyClass
    {
        public static void Main(string[] args)
        {       
       MyMethod();
        }

        public static int MyMethod()
        { int num1, num2;  
               Console.WriteLine("enter the first number");
                 num1=int.Parse(Console.ReadLine()) ;
                  Console.WriteLine("enter the first number");
                     num2=int.Parse(Console.ReadLine()) ;
                     return (num1==30 ||num2==30 ||(num1+num2)==30)? true :(num1+num2);
                       

        }
    }

}
//------------------------------- solution of w3resource
// using System;
// namespace exercises
// {
//      class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine(test(30, 0));
//             Console.WriteLine(test(25, 5));
//             Console.WriteLine(test(20, 30));
//             Console.WriteLine(test(20, 25));
//             Console.ReadLine();
//         }

//       public static bool test(int x, int y)
//         {
//             return x == 30 || y == 30 || (x + y == 30);
//         }
//   }
// }