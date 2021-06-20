using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
   public  class Genericscollection
    {
        public static void Main()
        {

            // Generics collection classes implemeted in system.collection.generics
            // dot net framework re-implemented non-generics into generics collection 
            //such as List<T> , ArrayList<T> , stack<T> , Queue<T>
            // T is the type of value want to store into the collection.
            // you need to provide type explicitl
            // Dictornary <Tkey, TValue>.
            // Genics collections are strongly type.

            //List<int> listofinteger = new List<int>();

            // boxing and unboxing is not require here.

            // List<Customer> customer = new List<Customer>();
            //

            // bool IsEqual = Calculator.Areequal(1, "hh");

            // using generics
            //bool IsEqual = Calculator.AreEqual<int>(1, 2);
            ////bool IsEqual = Calculator.Areequal(1, 2);
            //if (IsEqual == true)
            //    Console.WriteLine("Equal");
            //else
            //    Console.WriteLine("Not Equal");

            //Console.ReadKey();

            Mygenricsclass<int> classgentics = new Mygenricsclass<int>(10);

            int value = classgentics.MyGenericsMethod(100);

            Console.ReadKey();


            // AddRange add one list to another list of same type.

        }

        public class Calculator

        {
            // Here we can overload areequal method but to many code is require, no reuse of code
            //public static  bool Areequal(int value1, int value2)
            //{

            //    return value1 == value2;
            //}

            // primitive and reference type derived from system.object , but here problem is boxing and unboxing
            //public static bool Areequal(object value1, object value2)
            //{

            //    return value1 == value2;
            //}

            //solution to above is generics

            public static bool AreEqual<T>(T values1, T values2)
            {

                return values1.Equals(values2);
            }
        }

        // class and members are generics

        public class Mygenricsclass<T>

        {
            // member genrics
            private T genricmember;

            // method genrics
            public T MyGenericsMethod(T parametervalue)

            {
                Console.WriteLine("type of generics {0} ", typeof(T).ToString());
                return genricmember;

            }

            // property genrics
            public T MyProperty { get; set; }

            //constructor generics
            public Mygenricsclass(T values)
            {

            }


        }

    }
}
