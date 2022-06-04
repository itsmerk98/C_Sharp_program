using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*data hiding/shadowing*/
namespace _20_Data_hiding
{
    class person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void work()
        {
            Console.WriteLine("It works..");
        }
    }
    class employee:person
    {
        public double Salary { get; set; }
        public string designation { get; set; }
        //public void work()//hides the funtion work() implementation of PERSON class
        // to hide the warning completely we can use 'new'keyword
        public new void work()
        {
            Console.WriteLine("It earns");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            employee emp1 = new employee();
            emp1.work();
            Console.ReadKey();
        }
    }
}
