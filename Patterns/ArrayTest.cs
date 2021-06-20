using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class ArrayTest
    {
        public static void Main()
        {
            //Array 

            // primitive type variable which hold singla values ..int ,double
            // if you want to store multiple values then use array.

            // two type : single dimensional and ,multidimensional

            // singal : data store in form of row 
            // multi : data store in form of rows and columns

            // two type of multi : jagged array : array of array or coulmn and row are not equal .. 2 rectangular : rows and columns are equal :

            // In C#, the arrays can be declared as fixed-length or dynamic. The Fixed length array means we can store a fixed number of elements while in case of the dynamic array, the size automatically increases as we add new items into the array.

            //Note: The Arrays in C# are reference types that are derived from the System.Array class. 

            // one dimensional

            int[] arr = new int[6]; // inilialize using new keyword

            // or

            int[] arr2 = { 1,2,3,4,5,6}; // initialize usind arrgument values

            // you can assign value here
            for(int i=0;i<6;i++)
            {
                Console.WriteLine(arr[i]);
            }

            int a = 0;

            for(int i = 0; i < 6; i++)
            {

                a += 10;

                arr[i] = a;


            }
            // can not assign value fpr array.
            foreach (int values in arr)
            {
                Console.WriteLine(values);
                
            }

            Console.ReadKey();


            // we can use array method , sort , reverse , copy , lenth,, as default namespace is system , where as not of system.collection but it consider part of Ilist collection
            // implicit type of array using var keyword  var pp = new array[10];

            var implicitarr = new[] { 17, 23, 4, 59, 27, 36, 96, 9, 1, 3 };
            int arrlenth = implicitarr.Length;
            Console.WriteLine(arrlenth);
            for (int i = 0; i < implicitarr.Length; i++)
            {
                Console.Write(implicitarr[i] + " ");
            }
            Console.ReadKey();

            // Multi dimensional array

            // 4 rows , 5 coulmns
            int[,] arrayrectangular = new int[4,5];
            for (int i = 0; i < arrayrectangular.GetLength(0); i++)
            {
                for (int j = 0; j < arrayrectangular.GetLength(1); j++)
                {
                    a += 5;
                    arrayrectangular[i, j] = a;
                    Console.Write(arrayrectangular[i, j] + " ");
                }
            }
            Console.ReadKey();


            //Assigning the array elements at the time of declaration
            int[,] declare = {{11,12,13,14},
                          {21,22,23,24},
                          {31,32,33,34}};


            //jagged array 

            //Creating an jagged array with four rows
            int[][] jaggedarr = new int[4][];
            //Initializing each row with different column size
            // Uisng one dimensional array
            jaggedarr[0] = new int[5];
            jaggedarr[1] = new int[6];
            jaggedarr[2] = new int[4];
            jaggedarr[3] = new int[5];
            //printing the values of jagged array using nested for loop
            //It will print the default values as we are assigning any
            //values to the array
            for (int i = 0; i < jaggedarr.GetLength(0); i++)
            {
                for (int j = 0; j < jaggedarr[i].Length; j++)
                {
                    Console.Write(jaggedarr[i][j] + " ");
                }
            }

            //int[][] arr = {
            //                new int[4]{11,12,13,14},
            //                new int[5]{21,22,23,24,25},
            //                new int[3]{31,32,33}
            //               };
            ////printing the values of jagged array by using nested for loop
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.Write(arr[i][j] + " ");
            //    }
            //}
            //Console.WriteLine();

            //The Arrays in C# are strongly typed.

            // object array 

            object[] arr1 = new object[6];

            arr1[0] = 3.899;
            arr1[1] = 3;
            arr1[2] = 'g';
            arr1[3] = "Geeks";

            // it will display 
            // nothing in output
            arr1[4] = null;

            // it will show System.Object
            // in output
            arr1[5] = new object();

            // Display the element of 
            // an object array
            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }

            // static .. fixed size , given fixed lenth, dynamic List<int> runtime assign lenth 
        }
    }
}
