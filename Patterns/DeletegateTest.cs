using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
   public  class DeletegateTest
    {
        // define delegate with name .. Type safe function pointer..and hold reference of method and execute that method.

        // it is very simillar to class and must be signature of method same with delegate signature.

        //two type singal cast delete , multicast delegate

        // if del is used for invoke single delegate then its called singal cast and if want to invoke two or more method then its called multicast delegate

        public delegate int MyDelegate(int a, int b);
        public static void Main()
        {
            // define deletgate
        

        MyDelegate del = new MyDelegate(Add);

         int c =   del.Invoke(1, 2);
            Console.WriteLine("Value is {0}",c);
           // Console.ReadKey();

            del += minus;
           // or // del -= minus
            int D = del.Invoke(3, 2);
            Console.WriteLine("Value is {0}", D);

            // or the another way of calling

            MyDelegate d1 = new MyDelegate(anotherAdd1);
            MyDelegate d2 = new MyDelegate(anotherAdd2);
            MyDelegate d3 = new MyDelegate(anotherAdd3);
            Console.ReadKey();

            MyDelegate mycount = d1 + d2 + d3;

            mycount.Invoke(2, 3);

            Console.WriteLine("Value is {0}", D);
            //Add(1,2);
            int Add(int a , int b)

        {

            return a + b;
        }
            int minus (int a , int b)
            {

                return a - b;
            }

            int anotherAdd1(int a , int b)
            {
                return b;

            }
            int anotherAdd2(int a, int b)
            {
                return b;

            }
            int anotherAdd3(int a, int b)
            {
                return b;

            }
        }
  }
}
