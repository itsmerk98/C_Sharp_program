using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Delegates
{
    //MyDel will store the reference of the method which is returning "int" type value and have 2 integer parmaeters
    delegate int MyDel(int x, int y);
        
    class Program
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        static void Main(string[] args)
        {
            //Assigning reference into the delegate
            MyDel del = new MyDel(Add);
            int result = del(10, 30);
            Console.WriteLine(result);

            del = Multiply;//assigning referece of Multiply to delegate
            result = del(10, 30);
            Console.WriteLine(result);
        }
    }
}
