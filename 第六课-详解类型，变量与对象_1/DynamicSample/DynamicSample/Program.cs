using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //用C#模仿弱类型语言
            dynamic myVar = 100;
            Console.WriteLine(myVar);
            myVar = "Mr. Olay!";
            Console.WriteLine(myVar);
        }
    }
}
