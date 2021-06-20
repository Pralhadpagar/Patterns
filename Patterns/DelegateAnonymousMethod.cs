using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class DelegateAnonymousMethod
    {
        public delegate void mydelegate();

        public delegate void mydelegate1(string name);
        public delegate string mydelegate2(string name);
        // anonymous method means method without name, using delegate keyword we can do that and also, we can bind code block to delegate or unnamed code block to delgate
        // assignd to variable of delegate type
        public static void Main()
        {

            mydelegate name = delegate
            {
                Console.WriteLine("I am anonymous");

            };

            name.Invoke();

            // anonoums delgate
            mydelegate1 name1 = delegate(string firsname)
            {
                Console.WriteLine("name is {0}", firsname);

            };

            name1.Invoke("Pralhad");

            mydelegate2 mystring = delegate (string mystr)
            {
                return mystr;

            };

           string nameprint =  mystring.Invoke("Pagar");
            Console.WriteLine(nameprint);


//            What are the Limitations of Anonymous Methods in C#?
//An anonymous method in C# cannot contain any jump statement like goto, break or continue.
//It cannot access the ref or out parameter of an outer method.
//The Anonymous methods cannot have or access the unsafe code.
//Points to Remember while working with the Anonymous Methods in C#:
//The anonymous methods can be defined using the delegate keyword
//An anonymous method must be assigned to a delegate type.
//This method can access outer variables or functions.
//An anonymous method can be passed as a parameter.
//This method can be used as event handlers.


            Console.ReadKey();

            //// name given to this method 
            //void  Add()
            //{


            //}

            // Predicate generics deletegate

            // predicate is generics delegate which accept a singal input parameter of any type and return boolean true or false , this are madatory and fixed

            // public delegate bool Predicate<in T>(T obj)
            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee{ ID = 101, Name = "Pranaya", Gender = "Male", Salary = 100000},
                new Employee{ ID = 102, Name = "Priyanka", Gender = "Female", Salary = 200000},
                new Employee{ ID = 103, Name = "Anurag", Gender = "Male", Salary = 300000},
                new Employee{ ID = 104, Name = "Preety", Gender = "Female", Salary = 400000},
                new Employee{ ID = 104, Name = "Sambit", Gender = "Male", Salary = 500000},
            };


            // below we can avoid using delegate keywork passing an arugment to list // we can return find list as well.

            Employee emp1 = listEmployees.Find(

                delegate(Employee x)

                {

                    return x.ID == 104;

                });

            Console.WriteLine("using delegate keyword Find ID is {0}", emp1.Name);

           // Console.ReadKey();


            Predicate<int> preobj = new Predicate<int>(getDetailcount);

            Employee emp = listEmployees.Find(x => preobj(x.ID));

            Console.WriteLine("Find ID is {0}", emp.Name);

           // Console.ReadKey();


            // Lambda expresson : it is shorthand for writing the anonymous function.that is means simplfy the anonymous functions
            // left side the of lambda is input parameters and right hand block of code

            mydelegate2 mydelobj = (par1) =>
            {
                return par1.ToString();
            };
          string myname1 =   mydelobj.Invoke("prakgad");
            Console.WriteLine("my name is {0}", myname1);
            Console.ReadKey();




        }

        private static bool getDetailcount(int obj)
        {
            return obj == 103;
        }
    }

    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }
    }
}
