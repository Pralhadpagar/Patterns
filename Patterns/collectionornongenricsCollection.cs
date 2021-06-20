using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Patterns
{
    class collectionornongenricsCollection
    {
        public static void Main()
        {
            // dynamic array or collection in C# 
            // increse size dynamically
            // insert element in middle of collection
            //remove or delete item from middle of collection

            // present prefefines classes in system.collection namespace

            // stack , queue, arraylist , hashtable , linkedlist , sortedlist

            ArrayList arrlist = new ArrayList();

            Console.WriteLine("list capacity " + arrlist.Capacity);
            Console.WriteLine("list capacity " + arrlist.Count);

            arrlist.Add("pralhad");
            arrlist.Add(1);
            arrlist.Add(true);
            arrlist.Add(255.5);
            arrlist.Add("pralhad");

            foreach (var item in arrlist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("list capacity " + arrlist.Capacity);
            Console.WriteLine("list capacity " + arrlist.Count);

            arrlist.Remove(true);

            foreach (var item in arrlist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("list capacity " + arrlist.Capacity);
            Console.WriteLine("list capacity " + arrlist.Count);


            // not type safe as operate on object data type and store any type of value and so that boxing , unboxing require and can give runtime exception.

            //so solution to collection or non generics is generics collection.


            Console.ReadKey();
        }
    }
}
