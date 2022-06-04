using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overloading
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        /*public void Work()*/
        public virtual void Work()
        {
            Console.WriteLine("it works....");
        }
    }
    class student : Person
    {
        public override void Work()
        {
            Console.WriteLine("it studies....");
        }
    }
    class employee : Person
    {
        public double Salary { get; set; }
        public string designation { get; set; }

        /*public new void Work()*/
        public override void Work()
        {
            Console.WriteLine("it earns....");
        }
    }
    class manager : employee
    {
        public override void Work()
        {
            Console.WriteLine("it manages a team..");
        }
    }
    
    class branchManager : manager
    {
        /*if we do not want the overridden method to be derieved further
            we could put 'sealed' keyword*/
       /* public sealed override void Work()
        {
            Console.WriteLine("it manages branch..");
        }*/
        
    } 
    class ceo: branchManager
    {
        /*we could notice that work can not be overridden */
        public override void Work()
        {
            Console.WriteLine("it manages branch..");
        }

    }
    class program
    {
        static void Main(string[] args)
        {
            /* Person p1 = new employee();
            p1.Work();
            */
            Person p1 = new student();
            p1.Work();
            p1 = new employee();
            p1.Work();
            p1 = new branchManager();
            p1.Work();
            Console.ReadKey();
        }
    }
}
/*
- whenever we want to bind the object with the perticular method we us object overriding
- only virtual and abstract classes can be overridden.
- we can override any number of classes methods as they have one parent class.
*/
