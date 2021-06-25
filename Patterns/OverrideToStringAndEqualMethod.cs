using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Patterns.OverrideToStringAndEqualMethod;

namespace Patterns
{

    public static class newClass

    {
        public static void EwTest(this Oldclass obj)
        {
            Console.WriteLine("extension method");

        }

    }
    public  class OverrideToStringAndEqualMethod
    {

        public static void Main()
        {
            int i = 100;
            Employee emp = new Employee();

            emp.Name = "Pralahd";
            emp.ID = 1;

            Console.WriteLine(i.ToString());
            Console.WriteLine(emp.ToString());
          //  Console.ReadKey();

            /// Equals check value Equality and == check reference equality when complex type.
            /// 
            Customer C1 = new Customer();
            C1.FirstName = "Pranaya";
            C1.LastName = "Rout";

            Customer C2 = C1;

            Console.WriteLine(C1 == C2);
            Console.WriteLine(C1.Equals(C2));
           



            //  Both these methods are used to convert a value to string.The difference is Convert.ToString() method handles null whereas the ToString() doesn’t handle null in C#.

            // checked and uncheked 

            // extension method

            Oldclass oldobj = new Oldclass();
            oldobj.test();
            oldobj.EwTest();
            Console.ReadKey();


        }


        // for extesion methods

        public class Oldclass
        {

            public void test()
            {
                Console.WriteLine("old method");

            }

        }

       

    }
}
