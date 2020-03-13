using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            int y = 100;
            stu.AddOne(y);
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
    class Student
    {
        public void AddOne(int x)//声明时不带任何修饰符的参数就是值参数
        {
            x = x + 1;
            Console.WriteLine(x);
        }
    }
}
