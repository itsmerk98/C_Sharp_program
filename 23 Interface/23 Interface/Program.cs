using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
- interface supports complete abstraction i.e. nothing can be defined inside an interface
- Provides multiple inheritence : C# supports only single inheritance by default but interfaces helps to achieve multiple inhertance.
*/
namespace _23_Interface
{
    interface Interface1
    {
        void Method1();
        void Method2();
    }
    interface Interface2
    {
        void Method2();
    }
    class MyClass1
    {
        public void M1()
        {
            Console.WriteLine("M1 from MyClass1");
        }
    
    }
    // when we do multiple inheritance classes will be inherited first then interfaces
    class MyClass2 : MyClass1, Interface1, Interface2
    //class MyClass2 : MyClass1, Interface1
    {
        //implementation of methods declared in interface
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }
        /*  // implicitly defines Method2() for both interfaces

            public void Method2()
          {
              Console.WriteLine("Method 2");
          }*/

        // explicit defination of Method2() for both interfaces
        void Interface1.Method2()
        {
            Console.WriteLine(" Interface1 Method 2");

        }
        void Interface2.Method2()
        {
            Console.WriteLine("Interface2 Method 2");

        }
    }
        class Program
    {
        /* static void Main(string[] args)
         {
             MyClass2 m2 = new MyClass2();
             //we can now access all the methods from MyClass1 and interfaces methods defined in MyClass2
             m2.M1();
             m2.Method1();
             m2.Method2();
         }*/

        // consider another scenerio where we have defined another interface Interface2 with a method which have exactly same name as a method in Interace1
        // in the above case we do not define Method2() as it has already been defined in MyClass2, we simply inherit Interface2 and it will implicitly define Method2()
        // in case if definations of Method2() are required to be different the we can define it
        static void Main(string[] args)
        {
            MyClass2 m2 = new MyClass2();
           /* //we can now access all the methods from MyClass1 and interfaces methods defined in MyClass2
            m2.M1();
            m2.Method1();
            m2.Method2();*/
                
            // when we use 2 defination of same method compiler gets confused which method to call
            //m2.Method2();

            //this type of condition can be handled as
            Interface1 i1 = new MyClass2();
            i1.Method2();

            Interface2 i2 = new MyClass2();
            i2.Method2();
            Console.ReadKey();
         }
    }
}
