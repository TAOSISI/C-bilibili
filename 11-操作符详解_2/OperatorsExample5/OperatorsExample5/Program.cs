using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExample5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 12345678;
            int y = ~x;//求相反数，按位取反再加一
            int a = int.MinValue;
            int b = -a;
            Console.WriteLine(x);
            Console.WriteLine(y);
            string str1 = Convert.ToString(x, 2).PadLeft(32, '0');
            string str2 = Convert.ToString(y, 2).PadLeft(32, '0');
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(a);
            Console.WriteLine(b);
            string stra = Convert.ToString(a, 2).PadLeft(32, '0');
            string strb = Convert.ToString(b, 2).PadLeft(32, '0');
            Console.WriteLine(stra);
            Console.WriteLine(strb);
            Student stu = new Student(null);
            Console.WriteLine(stu.Name);
            Console.ReadKey();
        }
    }
    class Student
    {
        public Student(string initName)
        {
            if (!string.IsNullOrEmpty(initName))
            {
                this.Name = initName;
            }
            else
            {
                throw new ArgumentException("initName cannot be null or empty.");
            }
            this.Name = initName;
        }
        public string Name;
    }
}
