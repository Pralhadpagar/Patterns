using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{

    // can not be create object// not implement interface and cann not any class derive this class
    public static class StaticTest /*:IGlobalInterface*/
    {
        // static class can not have intance  constructor
        //public StaticTest()
        //{

        //}

       // access modifier not allowed on constructor static
       // static StaticTest()
       // {

       // }

       //// static constructor must be pararmeter less
       // static StaticTest()
       // {


       // }

        static StaticTest()
            {

            Console.WriteLine("Counter is {0}");
        }

        // can not declare instance memeber
        public static void test()

        { 
            //return 2;
        }

        internal static int test(int a)

        {
            return 2;
        }

        //public void onException()
        //{
        //    throw new NotImplementedException();
        //}
    }

    //can not be extend 

    //public class derivedclass : StaticTest

    //{

    // can not be part of inheritance

    ////public class derivedclass : singletonClass
    public class derivedclass
    {
        //possible
        //public void passmethodparameters(singletonClass classintance)
        //{


        //}

        //public void passmethodparameters(StaticTest classintance)
        //{


        //}

        public static void test()
        {
            Console.WriteLine("Counter is {0}");

        }
    }




}
