using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
- in case of overriding virtual method in base class it is not mendatory to be overridden in derieved classes
- but if we want to force derieved class to have some functionality then in such case we can make the base class or some of
  its features as abstract, so that derieved class can define those features which are abstract.
- in every abstract class there should be atleast one property that should be abstract
- abstract methods say what to do not how to do.

REASONS TO USE ABSTRACT CLASS 
- for ex:  in the PERSON(base class) we have defined a method work() which has not been called anywhere
    because PERSON is a base class and a base class is always quiet generalized and does not specify any specific operation
    as work() method does not define any detailed information whereas derieved class are giving much detailed information here.
- another drawback is it is optional to override a virtual method, hence if programmer skips overriding we may get some inappropriate results
   as base class method gets executed.


*/
namespace _22_Abstract_Class
{
    // abstract class
    abstract class person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        // abstract function body with no defination of its own
        public abstract void work();

    }
    /* // class with virtual defination
     class person
     {
         public string Name { get; set; }
         public int Age { get; set; }
         public virtual void work()
         {
             Console.WriteLine("It works..");
         }
     }*/

    class student : person
    {
        /*every class must override abstract method otherwise the inheriting class itself will become abstract*/
        public override void work()
        {
            Console.WriteLine("it studies..");
        }
    }
    class employee : person
    {
        public double Salary { get; set; }
        public string designation { get; set; }
        public override void work()
        // public new void work()
        {
            Console.WriteLine("It earns");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            person p1 = new employee();
            // with this statement p1 object got bound to person class although we have initialize with employee instance
            p1.work();

            //but whenever we want to bind a object with a particular method at runtime we use method overriding
            // only virtual and abstract classes can be overridden.

            //defining another instance for student the for employee
            person p2 = new student();
            p2.work();
            p2 = new employee();
            p2.work();
            Console.ReadKey();




        }
    }
}
