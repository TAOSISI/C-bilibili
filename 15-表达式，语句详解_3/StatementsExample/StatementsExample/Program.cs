using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatementsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //块语句，语句只能出现在方法体中，方法体中的花括号是块语句
            //块语句无论何时都会被编译器视为一条语句
            {
                int x = 100;//标签语句
                if (x > 75) Console.WriteLine(x);//嵌入式语句
                //hello: Console.WriteLine("Hello, World!");
                //goto hello;//标签语句
            }
            Level myLevel = Level.High;
            switch (myLevel)
            {
                case Level.High:
                    Console.WriteLine("High Level!");
                    break;
                case Level.Mid:
                    Console.WriteLine("Mid Level!");
                    break;
                case Level.Low:
                    Console.WriteLine("Low Level!");
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }
    }
    enum Level
    {
        High,
        Mid,
        Low
    }
}
