using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class RefactorGenericClass<T> where T : IComparable
    {
        public T first, second, third;
        public RefactorGenericClass(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        //using parameters because method is static
        public static T FindMaxValues(T first, T second, T third)
        {
            if (first.CompareTo(second)>=0 && first.CompareTo(third)>=0)
                return first;
            else if (second.CompareTo(first)>=0 && second.CompareTo(third)>=0)
                return second;
            else 
                return third;
        }
        public void TestMaximum()
        {
            T result = FindMaxValues(first, second, third);
            Console.WriteLine("{0} Maximum Value among {1} {2} {3}: ",result,first,second,third);
        }
    }
}
