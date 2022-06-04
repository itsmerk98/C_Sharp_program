using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
- has the same name as that of the class
- Initializes the data members
- is invoked when class is instantiated
- A class can have multiple constructors
- Costructor classification:
    - Default constructor
    - Parameterized constructor
    - Copy constructor
    - Static constructor
*/
namespace constructors
{
    class test
    {
        int marks;
        static int maxmarks;
        /* initializing default constructor*/
        test()
        {
            this.marks = 30;
        }
        /* initializing parameterized constructor*/
        test(int marks)
        {
            this.marks = marks;
        }
        /* copy constructors : it simply copies instance of one constructor to other*/
        test(test t)
        {
            this.marks = t.marks;
        }
        /*for static member we can have static constructor
        - static members is executed before main method */
        static test()
        {
            test.maxmarks = 50;
        }
        void CalculatePercent()
        {
            /* here we not initialized marks to 0 but
            marks have automatically initialized to 0 
            this is because of Default constructor
            - default constructor is provided by default by .NET framework if there is no constructor*/
            int percent = this.marks * 100 / test.maxmarks;
            Console.WriteLine(percent);
        }
        static void Main(string[] args)
        {

            test t1 = new test();
            t1.CalculatePercent();
            test t2 = new test(35);
            t2.CalculatePercent();
            test t3 = new test(t2);
            t3.CalculatePercent();

            /*we can also copy values directly to new object
            but value of member in both the objects will become same
            but in copy constructor both will have seperate variable values*/
            test t4 = new test(45);
            test t5 = t4;
            t4.marks = 48;
            t4.CalculatePercent();
            t5.CalculatePercent();
        }
    }
}
