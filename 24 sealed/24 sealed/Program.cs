using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sealed classes cannot be inherited nor they can be abstract
// can be a derieved or child class
// is generally a sql connection class
namespace _24_sealed
{
    /* sealed  class myclass1
    {
        public void samplemethod()
        {
            Console.WriteLine("sample method in myclass1");
        }
    }

    class myclass2 : myclass1
    {

    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    } */

    // Partial class - one class defined at different locations
    // -at runtime they there will be single instance of a partial class

   /* partial class myclass
    {
        public void samplemethod()
        {
            Console.WriteLine("sample method in myclass");
        }
    }

    partial class myclass
    {
        public void samplemethod1()
        {
            Console.WriteLine("sample method in myclass");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myclass m = new myclass();
            m.samplemethod();
            m.samplemethod1();
        }
    }*/
    //In generic classes we have advantage to actually pass the datatype at the runtime i.e. at runtime we can instantiate a class
    class myclass<T1, T2>
    {
            public T1 myproperty { get; set; }
            public void method(T1 p1, T2 p2)
            {

            }
    }
    class person
    {
        static void Main(string[] args)
        {
            myclass<int, string> obj1 = new myclass<int, string>();
            obj1.myproperty = 10;
            obj1.method(10, "akash");
        }
    }
}
