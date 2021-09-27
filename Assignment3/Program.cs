using System;
using System.Linq;

namespace Assignment3
{
    public class Program
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

        public static double multiplyDecimals(double x, double y)
        {
            Func<double, double, double> product = default(Func<double,double, double>);
            
            product = (x, y) => x * y;

            return product(x, y);
        }

        public static bool numericallyEqually(string x, double y)
        {
            Func<string, double, bool> equallity = default(Func<string, double, bool>);

            equallity = (x,y) => double.Parse(x) == y;

            return equallity(x,y);
        }
    }
}
