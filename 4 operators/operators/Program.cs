using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* arithmetic operators -> +,-,*,/,%, ++,--
   relational operators -> ==,!=,>,<,>=,<=
   Logical operators -> &&,||, !
   */
namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 50, b = 10;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

            string username = Console.ReadLine();
            string password = Console.ReadLine();
            string valid = (username == "akash" && password == "123") ?
                "welcome user" : "invalid user";
            Console.WriteLine(valid);
            Console.ReadLine();

        }
    }
}
