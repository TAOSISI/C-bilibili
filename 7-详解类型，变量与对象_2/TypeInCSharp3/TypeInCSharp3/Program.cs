using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeInCSharp3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b;
            b = 100;//值类型变量，没有实例
            sbyte sb;
            sb = 100;
            ushort us;//表示没有符号的短整型
            us = 1000;
            short s;//表示带有符号的短整型
            s = -1000;
            string str = Convert.ToString(s, 2);
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
