using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class ExtendMaxMethod
    {
        public static void Maximum(int[] array)
        {
            int length=array.Length;
            Console.WriteLine("Length of array is " + length);
            Array.Sort(array);
            foreach(int item in array) 
            {
             Console.Write(item+" ");
            }
            Console.WriteLine("\nMaximum Value is: "+array[length-1]);
        }
        public static void Maximum(double[] array)
        {
            int length = array.Length;
            Console.WriteLine("Length of array is " + length);
            Array.Sort(array);
            foreach (double item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nMaximum Value is: " + array[length - 1]);
        }
        public static void Maximum(string[] array)
        {
            int length = array.Length;
            Console.WriteLine("Length of array is " + length);
            Array.Sort(array);
            foreach (string item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nMaximum Value is: " + array[length - 1]);
        }
    }
}
