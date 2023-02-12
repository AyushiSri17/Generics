using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MaximumStringValue
    {
        public static string FindMaxValue(string first, string second, string third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
                //Console.WriteLine("{0} is maximum number among {1} {2} {3}", first, first, second, third);
                return first;

            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
                //Console.WriteLine("{0} is maximum number among {1} {2} {3}", second, first, second, third);
                return second;

            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
                //Console.WriteLine("{0} is maximum number among {1} {2} {3}", third, first, second, third);
                return third;
            else
                //0
                return default;
        }
    }
}
