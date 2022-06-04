using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer
{
    /* for multiple classes we may have a relationships. for example department and employee have 'has a' relationship
     - allows an object to be indexed such as an array.
        for ex: we can make department class object as array of employee class.
     - instance of this class can be accessed by using the array access operator([])
     - Use get and set accessors for defining an indexer.
     - Index can only be defined by 'this' keyword :
        'this' keywords refers to current object.*/
    class employee
    {
        //auto implemented properties Id, EmpName, Salary
        public int Id { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }
    }
    class department
    {
        public int DeptId { get; set;}
        public string deptName { get; set; }
        employee[] EmpList;// array of employee type defined in department class
        
        //default constructor
        public department()
        {
            DeptId = 10;
            deptName = "sales";
            EmpList = new employee[3]
            {
                new employee { Id = 101, EmpName="Alex", Salary = 50000 },
                new employee { Id = 102, EmpName="Brad", Salary = 45000 },
                new employee { Id = 103, EmpName="Chris", Salary = 40000 }
            };
        }
        public employee getEmployee(int id)
        {
            foreach(employee emp in EmpList)
            {
                if (id == emp.Id)
                    return emp;

            }
            return null;
        }
        public employee getemployee(string name)
        {
            foreach (employee emp in EmpList)
            {
                if (name == emp.EmpName)
                    return emp;
            }
            return null;
        }
        // rather than defining the functions we can also define indexer 
        //indexer will only have ' this' name
        //indexer method to search based on id
        public employee this[int id]
        {
            get
            {
                foreach (employee emp in EmpList)
                {
                    if (id == emp.Id)
                        return emp;
                }
                return null;
            }
        }
        // indexer method to search based on name
        public employee this[string name]
        {
            get
            {
                foreach (employee emp in EmpList)
                {
                    if (name == emp.EmpName)
                        return emp;
                }
                return null;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            department dept = new department();

            Console.WriteLine(dept[101].EmpName);
            Console.WriteLine(dept["Brad"].Id);
            Console.ReadKey();
        }
    }
}
