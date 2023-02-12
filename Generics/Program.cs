using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to generics programming");
            Console.WriteLine("------------------------------------");
            int[] intArray = { 20, 30, 40 };
            double[] doubleArray = { 12.7, 56.8, 89.2 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
            string[] stringArray = { "HOW", "ARE", "YOU" };

            Console.WriteLine("Please choose option of program to execute");
            Console.WriteLine("1: PrintArray \n2: PrintArrayUsingGenericMethod \n3: PrintArrayUsingGenericClass \n4. FindMaximunIntergerNumber");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    PrintArray.ToPrint(intArray);
                    PrintArray.ToPrint(doubleArray);
                    PrintArray.ToPrint(charArray);
                    Console.ReadLine();
                    break;
                case 2:
                    GenericPrintArray.ToPrint<int>(intArray);
                    GenericPrintArray.ToPrint<double>(doubleArray);
                    GenericPrintArray.ToPrint<char>(charArray);
                    GenericPrintArray.ToPrint<string>(stringArray);
                    break;
                case 3:
                    GenericClass<int> intObj = new GenericClass<int>(intArray);
                    intObj.ToPrint();
                    GenericClass<double> doubleObj = new GenericClass<double>(doubleArray);
                    doubleObj.ToPrint();
                    GenericClass<char> charObj = new GenericClass<char>(charArray);
                    charObj.ToPrint();
                    GenericClass<string> stringObj = new GenericClass<string>(stringArray);
                    stringObj.ToPrint();
                    break;
                case 4:
                    Console.WriteLine("Enter 3 Integer Numbers");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());
                    int c = Convert.ToInt32(Console.ReadLine());
                    MaximumIntergerNumber.FindMaxValue(a, b, c);
                    break;
                default:
                    Console.WriteLine("Choose the correct option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
