using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib.MyNamespace
{
    internal class Calculator//internal修饰的类可以在项目中自由访问
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
    }
}
