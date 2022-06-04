using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_initializer
{
    class Person
    {
        int age;
        string name;
        char gender;
        static void Main(string[] args)
        {
            /* sometime we may only want to initialize only some particular
            member of class for which we use object initilizer*/
            Person p1 = new Person { name = "akash", gender = 'M', age = 28 };
        }
    }
}
