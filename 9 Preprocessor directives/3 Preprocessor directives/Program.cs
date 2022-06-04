#define PI
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _3_Preprocessor_directives
{
    class Program
    {
        static void Main(string[] args)
        {
            /* - starts with # and starts processing 
                 before actual program runs
               - helps in conditional compilation */
#if (PI)
            Console.WriteLine("PI is defined");
#else
            Console.WriteLine("PI is not defined");
#endif
        }
    }
}
