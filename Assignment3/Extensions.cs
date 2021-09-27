using System;
using System.Collections.Generic;
using System.Linq;

namespace BDSA2020.Assignment03
{
    public static class Extensions
    {
       
       public static IEnumerable<int> flatten(IEnumerable<int>[] xs)
       {
           return(xs.SelectMany(c => c));
       }
    }
}
