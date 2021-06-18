using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
   public  class Singleton
    {
        static void Main(string[] args)
        {
                        
              singletonClass myclass = singletonClass.Instance;
              singletonClass.printDetail();

        }
    }


    /// <summary>
    /// singaleton class in sealed should be because if inheritance not possible.
    /// </summary>
    public sealed class singletonClass

    {
        private static int counter = 0;

        // private static readonly singletonClass singletonInstance = new singletonClass();
        private static singletonClass singletonInstance = null;
        private singletonClass()
        {
            counter++;
            Console.WriteLine("Counter is {0}", counter);
        }

        public static singletonClass Instance        
        {
            get
            {
                if(singletonInstance==null)
                {

                    singletonInstance = new singletonClass();
                }
               return singletonInstance ;
            }            
             
        }

        public static void printDetail()
        {
            Console.WriteLine("print");
            Console.Read();
        }

    }

}
