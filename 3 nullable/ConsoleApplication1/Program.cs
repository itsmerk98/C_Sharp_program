using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nullabel
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = null;
            //int a = null; //this statement gives error as int is not nullable datatype i.e. it cannot hold data
            //but there may be cases where we may get null data inside interger
            // in such cases we us '?' followed by data type to make data type nullable
            int? a = null; // here a is nullable
            int? b = a ?? 20; // the condititon here is if ‘a’ is'Null' then copy 20 to ‘b’ otherwise if  ‘a’ is ‘not Null’ copy value of ‘a’ to ‘b’.
            Console.WriteLine("a was nullable" + b);

            int? c = 10; // here a is non - nullable
            int? d = c ?? 20; // the condititon here is if c is'Null' then copy 20 otherwise copy value of 'c'
            Console.WriteLine("c was non - nullable" + d);

        }
    }
}
