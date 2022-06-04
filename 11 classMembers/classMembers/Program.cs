using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classMembers
{
    /*classe members can be classified in
  - Instance members / non-static: specific property of each 
  and every instance. For ex: car color may vary from instance 
  to instance.

  - Class members/static: some features are common
   for all the instance of class. for ex: 4 wheels are 
   common for all the instance of class*/
    class test
    {
        int marks;
        /*belongs to instance of class and can be accessed by class instance
         - they can be initialized any where as soon as the class is loaded*/
        static int maxmarks = 50;//belongs to class and can be accessed by class name
        void CalculatePercent()
        {
            int percent = this.marks * 100 / test.maxmarks;
            /*we can write test.maxmarks or maxmarks
            - this- will call out the member in the instance of class
            - test- will call out static member of class*/
            Console.WriteLine(percent);
        }
        static void Main(string[] args)
        {
            // test.maxmarks = 50;
            test t1 = new test();
            t1.marks = 43;
            t1.CalculatePercent();       
            Console.ReadKey();
        }
    }
}
