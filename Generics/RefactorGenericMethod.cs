using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class RefactorGenericMethod<T> where T : IComparable
    {
        public static T FindMaxValues(T first, T second, T third)
        {
            if (first.CompareTo(second) >= 0 && first.CompareTo(third) >= 0)
                return first;

            else if (second.CompareTo(first) >= 0 && second.CompareTo(third) >= 0)
                return second;

            else
                return third;
        }

    }
}
