using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace ClassandNamespace
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            double result = Calculator.Mul(1, 3);
            Console.WriteLine(result);
        }
    }
}
