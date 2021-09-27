using System;
using System.Linq;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static string reverseString(string s)
        {
            Func<string,string> reverseString = default(Func<string,string>);
            
             reverseString = s => new string(s.Reverse().ToArray());

             return reverseString(s);
        }
    }
}
