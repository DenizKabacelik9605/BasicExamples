// learn array practice, data assigment to  array elemets 
// learn use class metod and property in other class
//learn staic data examle with class
//learn List
namespace dataexamples
{
    public class Program
    {
        public static void Main(string[] args)
        {

            ArrayExamples arrayExample = new ArrayExamples();
            arrayExample.arrayMehod();
            ObjectExamples objExample = new ObjectExamples(14, "Test", false);

            Console.WriteLine(arrayExample.Value1);
            objExample.ObjectMethod();
            objExample.ObjectMethod2();
            staticData sd= new staticData(1, "Sultan","Kabaçelik");
             Console.WriteLine(sd.surname);
             
            


        }
    }
    public class ArrayExamples
    {
        public int Value1 { get; set; } = 5;
        public void arrayMehod()
        {
            string[] s = new string[5];
            s[0] = "Deniz";
            s[4] = "Umut";
            Console.WriteLine($"String array first element {s[0]}");
            string[] s2 = { "hello", "word", "this", "is", "my", "examples" };
            Console.WriteLine($"String s2 array third elememnt {s2[2]}");

        }
    }

    public class ObjectExamples
    {


       public int a { get; set; }
        public int[] b = { 3, 5, 8, 9 };
        public string e;
        public bool d;

        public ObjectExamples(int a)
        {
            this.a = a;
        }
        public ObjectExamples(int a, string e, bool d)
        {
            this.a = a;
            this.e = e;
            this.d = d;
        }
        public void ObjectMethod()
        {


            Console.WriteLine(a);

        }
        public void ObjectMethod2()
        {


            Console.WriteLine(d + " " + e);

        }

    }


    public class staticData
    {   

        int id;
        string name;

         public string surname;

        public staticData(int id, string name, string surname)
        {

            this.id=id;
            this.name=name;
            this.surname=surname;
        }
        




    }

      public class ListExample{

         List<string> l=new List<string>();

      }


}