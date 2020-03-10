using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student();
            Console.WriteLine(a);
            Console.WriteLine(qd);
            Console.ReadKey();
        }
    }
    class Student
    {
        public static Queue<decimal> qd;
    }
}
