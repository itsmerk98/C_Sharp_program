using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            Console.WriteLine("enter age");
            int age =int.Parse(Console.ReadLine());
            Console.WriteLine("user name is {0}\nUser age is {1} ",name, age);
            Console.WriteLine("user name is " + name + "\nUser age is " + age);
            Console.Write("hello c#\n");
            Console.WriteLine("hello");
            Console.ReadKey();
        }
    }
}
