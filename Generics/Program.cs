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
            int d = 10, e = 22, f = 55;
            float g = 20.5f, h = 58.6f, i = 69.9f;
            string j = "abc", k = "def", l = "ghi";

            Console.WriteLine("Please choose option of program to execute");
            Console.WriteLine("1: PrintArray \n2: PrintArrayUsingGenericMethod \n3: PrintArrayUsingGenericClass \n4. FindMaximumIntergerNumber \n5. FindMaximumFloatNumber \n6. MaximumStringValue \n7. MaximumUsingGenericMethod");
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
                case 5:
                    //float p=0.0f , q=0.0f , r=0.0f ,result=0.0f;
                    Console.WriteLine("Enter 3 Float Numbers");
                    float p = float.Parse(Console.ReadLine());
                    float q = float.Parse(Console.ReadLine());
                    float r = float.Parse(Console.ReadLine());
                    float result=MaximumFloatNumber.FindMaxValue(p, q, r);
                    Console.WriteLine("{0} is greatest among {1} {2} {3}",result,p,q,r);
                    break;
                case 6:
                    Console.WriteLine("Enter 3 String Values");
                    string str1 = Console.ReadLine();
                    string str2 = Console.ReadLine();
                    string str3 = Console.ReadLine();
                    string value=MaximumStringValue.FindMaxValue(str1, str2, str3);
                    Console.WriteLine("{0} is greatest among {1} {2} {3}", value, str1, str2, str3);
                    break;
                case 7:
                    int intMax=RefactorGenericMethod<int>.FindMaxValues(d,e,f);
                    Console.WriteLine("{0} is greatest among {1} {2} {3}", intMax, d, e, f);
                    float floatMax = RefactorGenericMethod<float>.FindMaxValues(g, h, i);
                    Console.WriteLine("{0} is greatest among {1} {2} {3}", floatMax, g, h, i);
                    string stringMax = RefactorGenericMethod<string>.FindMaxValues(j, k, l);
                    Console.WriteLine("{0} is greatest among {1} {2} {3}", stringMax, j, k, l);
                    break;
                default:
                    Console.WriteLine("Choose the correct option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
