using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class PrintArray
    {
        public static void ToPrint(int[] array)
        {
            Console.WriteLine("Displaying Interger Array");
            Console.Write("[ ");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.Write("]");
        }
        public static void ToPrint(double[] array)
        {   
            Console.WriteLine("\nDisplaying Double Array");
            Console.Write("[ ");
            foreach (double element in array)
            {
                Console.Write(element + " ");
            }
            Console.Write("]");
        }
        public static void ToPrint(char[] array)
        {
            Console.WriteLine("\nDisplaying Characters Array");
            Console.Write("[ ");
            foreach (char element in array)
            {
                Console.Write(element + " ");
            }
            Console.Write("]");
        }
    }
}
