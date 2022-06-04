using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*structure are value type classes are reference type*/
namespace _25_structure
{
    struct mystruct
    {
        public int val { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            mystruct mystruct1 = new mystruct();
            mystruct1.val = 10;

            mystruct mystruct2 = mystruct1;
            Console.WriteLine(mystruct2.val);

            mystruct1.val = 20;
            Console.WriteLine(mystruct2.val);
            Console.ReadKey();

        }
    }
}
