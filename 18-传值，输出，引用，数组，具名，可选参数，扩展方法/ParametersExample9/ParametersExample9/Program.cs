using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersExample9
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintInfo("Tim", 34);
            //具名调用
            PrintInfo(name: "Tim", age: 34);//优点1，提高代码的可读性，优点2，参数位置不再受参数列表顺序的约束了
            PrintInfo();//默认
            Console.ReadKey();
        }
        static void PrintInfo(string name = "Tim", int age = 34)
        {
            Console.WriteLine("Hello {0}, you are {1}", name, age);
        }
    }
}
