using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_OOPS
{
    /* - Is a programming paradigm
               - Describe the blueprint before implementation
               - Based on the concept of objects as objects are elementary types.
               - Objects may contain data and functionality.
               
               Principal Concepts of OOP's:
               -class, 
               -objects,
               -encapsulation, 
               -Abstraction - what to do not how to do, 
               -Inheritance, 
               -Polymorphism */
    class Program
    {
        //class implementation

        class test
        {
            int marks;
            void CalculatePercent()
            {
                int percent = marks * 100 / 50;
                Console.WriteLine(percent);
            }

            static void Main(string[] args)
            {
                test t1 = new test();
                t1.marks = 43;
                t1.CalculatePercent();

                test t2 = new test();
                t2.marks = 38;
                t2.CalculatePercent();
                Console.ReadKey();
            }
        }
    }
}
