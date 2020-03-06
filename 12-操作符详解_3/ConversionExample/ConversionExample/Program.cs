using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            Console.WriteLine(str1+str2);//字符串相加，拼接
            int x = Convert.ToInt32(str1);
            int y = Convert.ToInt32(str2);
            Console.WriteLine(x + y);
            Console.ReadKey();
            //子类向父类转换
            Teacher t = new Teacher();
            Human h = t;
            Animal a = h;
            a.Eat();

        }
    }
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }
    class Human : Animal
    {
        public void Think()
        {
            Console.WriteLine("Who I am?");
        }
    }
    class Teacher : Human
    {
        public void Teach()
        {
            Console.WriteLine("I teach programming");
        }
    }
}
