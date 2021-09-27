using System;
using System.Collections.Generic;
using System.Linq;

namespace BDSA2021.Assignment03
{
    public static class Extensions
    {
       
       public static IEnumerable<int> flatten(this IEnumerable<int>[] xs)
       {
           return(xs.SelectMany(c => c));
       }

       public static IEnumerable<int> numbersDivisbleBy7AndGreaterThan42(this int[] ys)
       {
            return(ys.Where(c => (c % 7 == 0) && (c > 42)));
       }

       public static IEnumerable<int> findLeapYears(this int[] ys)
       {
           return(ys.Where(c => DateTime.IsLeapYear(c)));
       }
    }
}
