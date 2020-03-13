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
            a.qd = new Queue<string>();
            Queue<string> numbers = new Queue<string>();
            numbers.Enqueue("123");
            a.qd.Enqueue("123");

            Console.WriteLine(a);
            Console.WriteLine(a.qd);
            Console.ReadKey();
        }
    }
    class Student
    {
        public Queue<string> qd;
    }
}
