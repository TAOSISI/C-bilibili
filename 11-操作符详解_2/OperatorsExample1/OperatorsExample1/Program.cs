using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu.Report();
            CsStudent csStu = new CsStudent();
            csStu.Report();
            Console.ReadKey();
        }
    }
    class Student
    {
        public void Report()
        {
            Console.WriteLine("I'm a student.");
        }
    }
    class CsStudent : Student//继承
    {
        new public void Report()//此时new是修饰符
        {
            Console.WriteLine("I'm a CS student.");
        }
    }
}
