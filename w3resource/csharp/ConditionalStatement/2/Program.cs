//check whether a given number is even or odd

namespace MyNamespace
{
    public class MyClass
    {

        public static void Main(string[] args)
        {



            Console.WriteLine("Enter the number");
            int num1 = int.Parse(Console.ReadLine());
            MyClass myclass = new MyClass();
            Console.WriteLine("dönen değer " + myclass.EvenOrOdd(num1));
        }

        public string EvenOrOdd(int num1)
        {
             string even="Number is even integer";
             string odd="Number is odd integer";
             return  num1%2==0 ? even : odd ;
        }
    }
}