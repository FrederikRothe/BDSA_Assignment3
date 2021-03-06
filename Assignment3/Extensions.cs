using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

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

       public static bool isSecure(this Uri u)
       {
           return(u.Scheme == Uri.UriSchemeHttps);
       }

       public static int WordCount(this string s)
       {
           return(s.Split(" ").Where(c => Regex.IsMatch(c, @"([a-z]|[A-Z])")).Count());
       }
    }
}
