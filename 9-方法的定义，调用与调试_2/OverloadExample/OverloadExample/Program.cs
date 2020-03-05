using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine(12);
            Console.WriteLine(200L);
            Console.WriteLine(3000D);//即方法的重载，可以输出多种类型，参数列表不同其他都相同的函数，就是函数重载
            //重载决策，根据重载的参数不同，来决定具体调用哪一个方法的重载
        }
    }
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add<T>(int a, int b)//类型形参是可以参与构成方法签名的
        {
            return a + b;
        }
        public int Add(ref int a, int b)//第一个参数改变为传入参数，种类改变，参数的种类也参与构成方法签名
        {
            return a + b;
        }
        //public int Add(out int a, int b)//第一个参数改变为输出参数，种类改变，参数的种类也参与构成方法签名
        //{
        //    return a + b;
        //}
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public double Add(double a, double b)
        {
            return a + b;//构成方法签名，名字和类型形参，
        }
    }
}
