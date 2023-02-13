using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class ExtendMaxGenericMethod<T>
    {
        public T[] array;
        public ExtendMaxGenericMethod(T[] array)
        { 
        this.array = array;
        }
        public static void FindMaxValues(T[] array)
        {
            int length = array.Length;
            Console.WriteLine("Length of array is " + length);
            //sorting in ascending order
            Array.Sort(array);
            foreach (T item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nMaximum Value is: " + array[length - 1]);
        }
        public void TestMaximum()
        {
            FindMaxValues(array);
        }
    }
}
