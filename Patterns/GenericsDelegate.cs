using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
   public class GenericsDelegate
    {
        //after 3.5 we dont require to define delegate instance.
        //C# provide us in-built generics delegate
        // three delegate it provide us
        // func , action , predicate


        // Func : are in system namespace , takes one or more input parameters and return one output parameter / last parameter consider as out parameter

        // takes 16 input parameter , and should be one is outparameter into that and last one , input can be different type or same type , it must have one return type
        // return type is madatory and but not input

        //Action : it also in system namespace .. it can takes 16 input parameters of diff or same type
        //Note: Whenever your delegate returns some value, whether by taking any input parameter or not, you need to use the Func Generic delegate in C#.

        // return nothing.

        //Note: Whenever your delegate does not return any value, whether by taking any input parameter or not, then you need to use the Action Generic delegate in C#.


        // predicate : can take maximum one input parameter  , return boolean , whenver to verify something it do for us.boolean value is madatory .
        //verify certain criteria of method.

        public static void Main()
        {
            Func<int, int, int> funmy = new Func<int, int, int>(Addfunc);

            int b = funmy(1, 2);

            Console.WriteLine(b);
           // Console.ReadKey();

            Action<int, int> myobjj = new Action<int, int>(AddAction);

            myobjj.Invoke(1, 3);

           // Console.WriteLine(b);
            Console.ReadKey();

            Predicate<string> mypred = new Predicate<string>(Islength);

            bool ischeck = mypred.Invoke("Prrp");



            // predicate we already used in last articles. // this what end of delegate.
        }

        static int Addfunc(int a, int b)
        {
            return a + b;
        }

        static void AddAction(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static bool Islength(string name)
        {
            if (name.Length > 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
