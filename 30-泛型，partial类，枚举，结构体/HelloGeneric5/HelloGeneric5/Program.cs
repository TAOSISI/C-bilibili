using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGeneric5
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> a1 = Say;//action委托只能引用没有返回值的方法
            a1.Invoke("Timothy");//通过委托去调用数据间接调用
            Action<int> a2 = Mul;
            a2(1);

            Func<int, int, int> func1 = Add;//func委托可以引用有返回值的方法
            var result1 = func1(100, 200);
            Console.WriteLine(result1);

            Func<double, double, double> func2 = Add;
            var result2 = func2(100.1, 200.2);
            Console.WriteLine(result2);

            //泛型委托是如何与lamta表达式一起使用的
            Func<double, double, double> func3 = (a, b) => { return a + b; };
            var result3 = func3(100.1, 200.2);
            Console.WriteLine(result3);

            Console.ReadKey();
        }
        static void Say(string str)
        {
            Console.WriteLine($"Hello,{str}!");
        }
        static void Mul(int x)
        {
            Console.WriteLine(x*100);
        }
        static int Add(int a,int b)
        {
            return a + b;
        }
        static double Add(double a, double b)
        {
            return a + b;
        }
    }
}
