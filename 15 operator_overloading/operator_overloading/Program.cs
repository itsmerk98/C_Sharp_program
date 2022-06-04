using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operator_overloading
{
    class length
    {
        int feet, inch;
        /*default constructor*/
        public length()
        {
            this.feet = 0;
            this.inch = 0;
        }
        /*parameterized constructor*/
        public length(int feet, int inch)
        {
            this.feet = feet;
            this.inch = inch;
        }
        public string getlength()
        {
            return string.Format("length : {0}' {1}\"", feet, inch);
        }
        /*overloading + operator*/
        public static length operator +(length l1, length l2)
        {
            length l3 = new length();
            l3.feet = l1.feet + l2.feet;
            l3.inch = l1.inch + l2.inch;
            if(l3.inch >= 12)
            {
                l3.feet++;
                l3.inch -= 12;
            }
            return l3;
        }
        public static bool operator >(length l1, length l2)
        {
            if (l1.feet > l2.feet)
                return true;
            else if (l1.feet == l2.feet)
            {
                if (l1.inch > l2.inch)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        public static bool operator <(length l1, length l2)
        {
            if (l1.feet > l2.feet)
                return true;
            else if (l1.feet == l2.feet)
            {
                if (l1.inch > l2.inch)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

    }
    class program
    { 
        static void Main(string[] args)
        {
            length len1 = new length(2, 8);
            length len2 = new length(4, 5);
            /*in the statement below we can see that len1 and len3 cannot
                be added directly in this case we need to program operators
                   to do multiple task*/
            //length len3 = len1 + len2;
            length len3 = len1 + len2;

            if (len1 > len2)
                Console.WriteLine("len1 is greater");
            else
                Console.WriteLine("len1 is not greater");
            
            Console.WriteLine(len1.getlength());
            Console.WriteLine(len2.getlength());
            Console.WriteLine("Total : " + len3.getlength());
        }
    }
}
