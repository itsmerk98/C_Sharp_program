using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace type_casting
{
    class Program
    {
        static void Main(string[] args)
        {
            short num1 = 10;
            short num2 = 20;
            //short sum = num1 + num2; // type conversion problem as integer cannot be converted to short type.
            // integer is bigger type(i.e data type occoupying more size) cannot be converted to smaller data type
            short sum = (short)(num1 + num2);//type casted integer to short
            Console.WriteLine(sum);
            
            //boxing and unboxing
            int a = 10;
            object o = a; //object can store any type of data for example 'a' is automatically convreted to object type, this is called 'boxing'.
            //int b = o;// converting object to integer gives error as object is larger type so we require to convert object-->int explicitly.
            int b = (int)(o);//unboxing
        }
    }
}
