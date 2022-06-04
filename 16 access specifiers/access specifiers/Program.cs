using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* access specifiers can be classified as 
- private - member declared as private can not be accessed from outside of class or can not be inherited.
- internal - member declared as internal it can be accessed from any class within  the current assembly or project.
           - a class defined in namespace is by default internal
- public - if we want to access a functionality to some other project then we declare it as public
- Protected - if a member declared as protected in base class it will be inherited as public */
namespace access_specifiers
{
    //a class can be either public or internal and by default class is internal
    //private class myclass1
    class myclass
    {
        //int a;//by default a is private
        internal int a;
    }
    public class myclass1//the class has been declared as public
    {
        public int a; //it can be accessed from anywhere outside of assembly
        internal int b;// it can accessed anywhere inside the assembly
    }
    class Program
    {
        static void Main(string[] args)
        {
            myclass m = new myclass();
            //m.a = 100;
            m.a = 100;//now there is no error because 'a'is defined as internal
        }
    }
}
