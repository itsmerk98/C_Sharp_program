using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
- properties are named members of the class
- Is used to provide restricted access to data members.
- Accessors like 'set' and 'get'are used for validation
-properties provides restricted access to the external data classes
for ex: - we can restrict a variable to get value >10000 by applying validations using properties*/
namespace properties
{
    class Accounts
    {
        float init_amount;//it is not static as initial amount can vary for all user
        static float interest;//it static because interest rate is fixed
        /* if we want to create a property in which we do not want to put any restriction 
            but  we set and get the values then we could simply declare them as below which is a standard 
                way to provide values outside the class*/
        public string name { get; set; }
        public float InitialAmount //named member of class
        {
            set //set accessor is implemented implicitly for asigning the value
            {
                if(value<1000)
                {
                    Console.WriteLine("initial amount cannot be less than 1000");
                    return;
                }
                //InitialAmount = value;
                init_amount = value;
            }
            get //get accessor is used to retrieve the value
            {
                //return InitialAmount;
                return init_amount;
            }
        }
        public static float InterestRate
        {
            private set { interest = value; } //private along with set will not allow any external class to set this value
            get { return interest; }
        }
        //default constructor
        public Accounts()
        {
            this.InitialAmount = 10000;
        }
        //parameterized constructor
        public Accounts(float amt)
        {
            this.InitialAmount = amt;
        }
        //static constructor which is asigning the value to interest rate
        static Accounts()
        {
            Accounts.InterestRate = 9.5f;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Accounts ac1 = new Accounts();
            //ac1.InitialAmount = 500;//checking validation by giving value less than 1000
            //ac1.InitialAmount = 1500; // it will accept the initial value
            // if nothing is assigned default constructor will take the value
            Accounts ac1 = new Accounts(5000);//we can also give value while creating object as we have a parametrized constructor
            //Accounts.InterestRate = 10;// the statement is invalid as set accessor is private but we could read the value anytime
            Console.WriteLine(ac1.InitialAmount);
            Console.WriteLine(Accounts.InterestRate);
            ac1.name = "akash";//setting the values
            Console.WriteLine(ac1.name);//retrieving the values
            Console.ReadKey();
        }
    }
}
