using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersExample10
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3.14159;
            double y = x.Round(4);
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
    static class DoubleExtension//扩展方法
    {
        public static double Round(this double input, int digits)
        {
            double result = Math.Round(input, digits);
            return result;
        }
    }
}
