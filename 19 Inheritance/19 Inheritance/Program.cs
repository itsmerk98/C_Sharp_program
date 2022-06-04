using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
- rather than defining similar features again and again we can define in base class and can reuse it in another classes
- Inheritance allows us to define a class in terms of another .
- One class(base) shares its members with another class(derieved), which allows reusability.
- When a derieved class is lacking the required member, it takes from base class.
- Base and derieved classes have 'is a' relationship.
*/
namespace _19_Inheritance
{
    // base/parent class
    class Myclass1
    {
        protected int a;//protected member are only accessible its own class and in which it is derieved.
        internal int b;
        public Myclass1()
        {
            Console.WriteLine("MyClass1 defaut constructor");
        }
        static Myclass1()
        {
            Console.WriteLine("myclass1 static constructor");
        }
        public Myclass1(int a)
        {
            Console.WriteLine("Myclass1 parameterized constructor");
        }
        public void Method1()
        {
            Console.WriteLine("Method1 from MyClass1");
        }

    }
    // subclass / inheriting/ child class
    /* if a derieved class does not have some called method of its own then only it will take that method from base class
        otherwise if child class have its own method then it will not take base class version*/
    class Myclass2 : Myclass1
    {
        public Myclass2()
        {
            Console.WriteLine("MyClass2 defaut constructor");
        }
        static Myclass2()
        {
            Console.WriteLine("myclass2 static constructor");
        }
        //public Myclass2(int b)
        public Myclass2(int b): base (b)
        {
            Console.WriteLine("Myclass2 parameterized constructor");
        }
       /* public void Method1()
        {
            Console.WriteLine("Method1 from MyClass2");
        }*/
        public void Method2()
        {
            Console.WriteLine("Method2 from MyClass2");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            // Myclass1 obj1 = new Myclass1();
            //as soon as the derieved class is initialized the constucter of base class is invoked first and then derieved class constructors
             //Myclass2 obj2 = new Myclass2();
             //obj2.Method1();
            //obj2.Method1();

             Myclass2 obj2 = new Myclass2(10);
            //default constructor is base class is initialize and then parameterized constructor of class 2 is initialized
            // we can also initialize base constructor as well

            // the static constructor of derieved class is executed first the base class.
            Console.ReadKey();
        }
    }
}
