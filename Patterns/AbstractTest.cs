using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{

    // only public , not other modifier for abstract class

    // need to check on modifiers on class basis and other type basis
   public class AbstractTest :  IGlobalInterface
    {
        public static void Main()
        {

            test2 tests = new test2();
            tests.add();
            // test of sealed class
            //Main main = new Main();
            //main.Add();

            // can not create object of abstract class.
            // MyAbstract ab = new MyAbstract();
            // reference variable is posssible
            // MyAbstract ab = new testabstract();

          // testabstract ab = new testabstract();
           //  ab.virtualmethod();
          //  ab.number();

            //ab.add();
            //ab.virtualmethod();
            //ab.minus();
            //testabstract abstracts = new testabstract();
            //abstracts.add();
            //abstracts.virtualmethod();
            Console.ReadKey();

        }

        public void onException()
        {
            throw new NotImplementedException();
        }
    }   

    // any other class type can derive from abstract class. typically is super class for base classes//

    // inheritance // abstract inherits its feature to derive classes.
    public abstract class MyAbstract /*: testabstract*/

    {

        public abstract void add();

        public  virtual void virtualmethod()
        {
            Console.WriteLine("virtual method myabstract");

        }

        public virtual int number()
        {
            return 1;

        }

        public void minus()
        {


        }
        // have constructor
        public MyAbstract()
        {

        }


        // can have static construtor
        static MyAbstract()
        {

        }

    }

    //    Super Class: The class whose features are inherited is known as super class(or a base class or a parent class).
    //Sub Class: The class that inherits the other class is known as subclass(or a derived class, extended class, or child class). The subclass can add its own fields and methods in addition to the superclass fields and methods.
    //Reusability: Inheritance supports the concept of “reusability”, i.e.when we want to create a new class and there is already a class that includes some of the code that we want, we can derive our new class from the existing class. By doing this, we are reusing the fields and methods of the existing class.

    public class testabstract : MyAbstract
    {
        public testabstract()
        {

        }

        public override void add()
        {
            //throw new NotImplementedException();

            Console.WriteLine("derived add method ..abstract");

        }

        //public override mymethod()
        //    {}
        //public new void virtualmethod()
        public override void virtualmethod()
        {
            Console.WriteLine("virtual method testabstract");
             base.virtualmethod();
        }

        public override int number()
        {
            int number = base.number();

            if(number > 6 )
            {

                Console.WriteLine("no 6");
            }
            else
            {
                Console.WriteLine("Number five");

            }
            return 6;
        }

    }

    public class test2 : testabstract
    {
        public override void add()
        {
            //throw new NotImplementedException();

            Console.WriteLine("derived add method ..abstract");

        }
        public override void virtualmethod()
        {
            Console.WriteLine("virtual method test2");
            // base.virtualmethod();
        }


    }

    public sealed class Main
    {

        public void Add()
        {


        }

    }

}
