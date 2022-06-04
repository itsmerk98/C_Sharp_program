using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static void SampleMethod()
        {
            Console.WriteLine("This is sample method");
        }
        static int add(int x, int y)
        {
            int sum = x + y;
            return sum;
        }
        static void call_by_val(int x)
        {
            Console.WriteLine("initial value of formal parameter" + x);
            x = 100;
            Console.WriteLine("final value of formal parameter" + x);
        }
        static void call_by_ref(ref int x)
        {
            Console.WriteLine("initial value of formal parameter" + x);
            x = 100;
            Console.WriteLine("final value of formal parameter" + x);
        }
        static void call_by_out(out int x)
        {
            Console.WriteLine("initial value of formal parameter" + x);
            x = 100;
            Console.WriteLine("final value of formal parameter" + x);
        }
        static void Main(string[] args)
        {
            int num1 = 10, num2 = 10,a=10;
            Console.WriteLine("Program started");

            SampleMethod();

            Console.WriteLine("initial value of actual parameter" + a);
            call_by_val(a);
            Console.WriteLine("final value of actual parameter" + a);

            Console.WriteLine("initial value of actual parameter" + a);
            call_by_ref(ref a);
            Console.WriteLine("final value of actual parameter" + a);

            Console.WriteLine("initial value of actual parameter" + a);
            call_by_out(out a);
            Console.WriteLine("final value of actual parameter" + a);

            Console.WriteLine("program ended");
            int x = add(num1, num2);
            Console.WriteLine(x);


        }
    }
}
