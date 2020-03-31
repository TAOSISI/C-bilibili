using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib.MyNamespace;

namespace HelloClass
{
    class Program
    {
        static void Main(string[] args)//类的方法成员
        {
            Calculator calc = new Calculator();
            double res = calc.Add(1, 2);
            Console.WriteLine(res);
            Console.ReadKey();
        }
        class Student//成员类
        {

        }
    }
    class Student
    {

    }
}
namespace MyNS
{
    class Teacher
    {

    }
}
class Computer//这个类声明在全局名称空间中
{

}