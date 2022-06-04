using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* conditional statement - if..else.., switch
    iteration/loops -> for, while,Do While, Foreach loops
    JUMP statements -> Break, Continue, Goto, Return
*/
namespace control_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loop
            /*int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;
                Console.WriteLine(i);
                Console.WriteLine(sum);
                Console.ReadLine();
            }
            */
            /*//Prime number
            int num = int.Parse(Console.ReadLine());
            bool isprime = true;
            for(int i = 2; i<=Math.Sqrt(num); i++)
            {
                if(num%i == 0)
                {
                    isprime = false;
                    break;
                }
            }
            if (isprime)
                Console.WriteLine("Number is PRIME");
            else
                Console.WriteLine("Number is not PRIME");*/

            /*
            //Prime number in the range
            for (int num = 1; num<=100; num++)
            {
                bool isprime = true;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime)
                    Console.WriteLine(num + "\t");
            }
            */

           /* // While loop
            bool isprime = true;
            int count = 0;
            int num = 1;
            while(count < 100)
            {
                isprime = true;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime)
                {
                    Console.Write(num + "\n");
                    count++;
                }
                num++;
            }
            Console.WriteLine();*/

            
           /* //Number of digits using While loop
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int digits = 0;
            while(temp!=0)
            {
                digits++;
                temp = temp / 10;
            }
            Console.WriteLine("{0} is {1} digit number.", num, digits);*/

             //ATM PIN with 3 attempts limit using do..while loop
            string actualpin = "4321";
            int count = 0;
            string pin;
            do
            {
                pin = Console.ReadLine();
                count++;
            } while (pin != actualpin && count < 3);

            if (pin == actualpin)
                Console.WriteLine("welcome user");
            else
                Console.WriteLine("Account Locked");
              

            //JUMP statements
            //Break
            for (int i = 1; i <=10; i++)
            {
                if (i == 5)
                    break;

                Console.WriteLine("i = " + i);

            }

            //Continue
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5 || i == 7)
                    continue;

                Console.WriteLine("i = " + i);
            }

            //GOTO
            int i = 1;
        abc:
            Console.WriteLine(i);
            i++;
            if (i <= 10)
                goto abc;

            //Return
            Console.Write("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());

            if(num2 == 0)
            {
                Console.WriteLine("cannot divide a number by 0");
                return;
            }
            int result = num1 / num2;
            Console.WriteLine("Result is :" + result);  */

        }

    }
}

