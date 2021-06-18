using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{

    // can not be create object
    public static class StaticTest 
    {
        // static class can not have intance  constructor
        //public StaticTest()
        //{

        //}

        // access modifier not allowed on constructor static
        //public static StaticTest()
        //    {

        //    }

        // static constructor must be pararmeter less
        //static StaticTest( int a)
        //{


        //}

           static StaticTest()
            {
              
            }

        // can not declare instance memeber
        //public void test()

        //{

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
    }




}
