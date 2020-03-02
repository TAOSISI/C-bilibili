using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdentifiersExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 100;
            long y = 3L;
            float a = 3.0F;
            double b = 4.00;
            char c = 'a';//单引号只能赋值一个字符
            bool d = true;
            bool e = false;
            string str = null;
            //Form f = null;
            Form f = new Form();
            f.ShowDialog();
            //以var声明的变量，编译器会自动推断出他的类型
            var x = 3;
            Console.WriteLine(x.GetType().Name);
            Console.WriteLine(X);
            Calculator g = new Calculator();
            int h = g.Add(2, 3);
            Console.WriteLine(h);
            string i = g.Today();
            Console.WriteLine(i);
            g.PrintSum(6, 4);
        }
        class Calculator
        {
            public int Add(int a, int b)
            {
                int result = a + b;
                return result;
            }
            public string Today()
            {
                int day = DateTime.Now.Day;
                return day.ToString();
            }
            public void PrintSum(int a,int b)
            {
                //没有任何数据返回
                int result = a + b;
                Console.WriteLine(result);
            }
        }
    }
}
