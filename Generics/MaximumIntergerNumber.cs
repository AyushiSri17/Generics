using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MaximumIntergerNumber
    {
        public static void FindMaxValue(int first, int second, int third)
        {
            if (first.CompareTo(second)>=0 && first.CompareTo(third)>=0)
                Console.WriteLine("{0} is maximum number among {1} {2} {3}",first,first,second,third);

            else if (second.CompareTo(first)>=0 && second.CompareTo(third)>=0)
                Console.WriteLine("{0} is maximum number among {1} {2} {3}", second, first, second, third);

            else
                Console.WriteLine("{0} is maximum number among {1} {2} {3}", third, first, second, third);
        }
    }
}
