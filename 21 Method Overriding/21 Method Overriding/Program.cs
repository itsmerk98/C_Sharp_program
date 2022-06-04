using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
- Performs dynamic polymorphism.

- Allows you to invoke method that belongs to different class in same
  hierarchy using the base class reference.

- Virtual and Override keywords are used to implement method overriding.

*/
namespace _21_Method_Overriding
{
    class person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual  void work()
        //public void work()
        {
            Console.WriteLine("It works..");
        }
    }

    class student: person
    {
        public override void work()
        {
            Console.WriteLine("it studies..");
        }
    }
    class employee : person
    {
        public double Salary { get; set; }
        public string designation { get; set; }
        public override  void work()
        // public new void work()
        {
            Console.WriteLine("It earns");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            person p1 = new employee(); // with this statement p1 objet got bound to person class although we have initialize with employee instance
            p1.work();

            //but whenever we want to bind a object with a particular method at runtime we use method overriding
            // only virtual and abstract classes can be overridden.

            //defining another instance for student the for employee
            person p2 = new student();
            p2.work();
            p2 = new employee();
            p2.work();
        }
    }
}
