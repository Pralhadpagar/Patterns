using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    // by default class is internal and can be applied only public or internal
     public class AccessModifiers
    {

       

       public  static void Main()
        {
            // B b = new B();

            //A a = new A();
            //B b = new B();
            //b.a = 10;
            //B bb = new B();
            //b.a = 23;
            //D d = new D();
            //D pp = new D();

            int a = D.te;

            int c = a;

            //works in non ready only case.
            //D.te = 6;

            
            D d = new D();

            Console.ReadKey();
        }

       static AccessModifiers()
        {
            int a = D.te;

            int c = a;

           // D.te = 6;
        }
    }
        //
    

   public class A : C
    {

        //public A() :this(1,2)
        //{

        //}

        public int a = 123;
        static int temp;


        public A(int a, int b) : this()
        {
            int bb = temp;
            Console.WriteLine("I am A constructor  parameter   constructor");
        }

        static A()
        {
            
            Add();
            Console.WriteLine("static constructor A");
        }
        public A() 
        {
            Add();
            Console.WriteLine("I am A constructor without parameter / default constructor");

        }

        public static void Add()
        {


        }


    }

    public class B : A
    {

        // inside static constructor we can intialize static fields or obiject
       static int a;
        int bb = 55;
        C obj;
        static  B() 
            {
            a = 10;
          //  C c = new C();
             
            }
        public B() : base(2,3)
        {
            Console.WriteLine("I am B constructor without parameter / default constructor");


        }
        public B(int a, int b)
        {

        }
    }

    public class C

    {
        //public C()
        //{
        //    Console.WriteLine("I am B constructor without parameter / default constructor");
        //}

        public C(int a, int b)
        {
            Console.WriteLine("I am C constructor  parameter  constructor");
        }

        public C()

        {
            Console.WriteLine("I am C constructor without parameter / default constructor");

        }

        static  C()
            {
            Console.WriteLine("static constructor for C");
        }

    }

    public  class D
    {
       public static readonly int te=5;

        const int safe = 10;
        static D()
        {
           
           // te = 5;

        }

        public void add()
        {
          
         // safe = 10;
        }

    }
}
