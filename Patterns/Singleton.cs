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
            //singletonClass myclass = singletonClass.Instance;
            //singletonClass.printDetail();

            // if want to check multhreaded then as below

            Parallel.Invoke(
                () => GetEMpDetail(),
                () => GetSecurityDetail()
                );
        }

        public static void GetEMpDetail()
        {
            singletonClass instance = singletonClass.Instance;
            instance.PrintDetails("DetailEmp");
            //Console.WriteLine("DetailEmp");
            //Console.Read();
        }
        public static void GetSecurityDetail()
        {
            singletonClass instance = singletonClass.Instance;
            instance.PrintDetails("securitydetails");
            //Console.WriteLine("securitydetails");
            //Console.Read();
        }
    }


    /// <summary>
    /// singaleton class in sealed should be because if inheritance not possible.
    /// </summary>
    public sealed class singletonClass

    {
        private static int counter = 0;

        // no thread safe
        // private static readonly singletonClass singletonInstance = new singletonClass();
        // thread safe with double check and locking 
        private static singletonClass singletonInstance = null;
        private static readonly object sharedresource = new object();

        // Eager Loading ..  while in appliation start up CLR take care of all thread safe.

        // or below Lazy initilization - delay the object initialization until the object is needed and which on demand 

        // pass delegate to constructor

        private static readonly Lazy<singletonClass> singleobj = new Lazy<singletonClass>(() => new singletonClass());
        private singletonClass()
        {
            counter++;
            Console.WriteLine("Counter is {0}", counter);
        }

        /// <summary>
        ///  commented for lazy loading in singleton pattern.
        /// </summary>
        //public static singletonClass Instance        
        //{
        //    get
        //    {
        //        //// Thread safe singaleton example.
        //        if (singletonInstance == null)
        //        {
        //            lock (sharedresource)
        //            {
        //                if (singletonInstance == null)
        //                {

        //                    singletonInstance = new singletonClass();
        //                }
        //            }
        //        }
        //       return singletonInstance ;
        //    }            
             
        //}

        public static singletonClass Instance

        {
            get
            {
               // Allows you to check whether or not the instance has been created with the IsValueCreated property.
                return singleobj.Value;
            }

        }

        //we can take static as well as below 
        //public static void printDetail()
        //{
        //    Console.WriteLine("print");
        //    Console.Read();
        //}

        //public  void printDetail()
        //{
        //    Console.WriteLine("print");
        //    Console.Read();
        //}
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
            Console.Read();
        }
    }

}
