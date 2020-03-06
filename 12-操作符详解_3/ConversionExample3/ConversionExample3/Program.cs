using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionExample3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stone stone = new Stone();
            stone.Age = 5000;
            Monkey wukongSun = (Monkey)stone;//类型转换操作符
            Console.WriteLine(wukongSun.Age);
            Nullable<int> x = null;//可空类型
            //int? x=null;
            //x = 100;
            Console.WriteLine(x);
            Console.WriteLine(x.HasValue);

            Console.ReadKey();

        }
    }
    class Stone
    {
        public int Age;
        public static explicit operator Monkey(Stone stone)//显式类型转换就是目标类型实例的构造器
        {
            Monkey monkey = new Monkey();
            monkey.Age = stone.Age / 500;
            return monkey;
        }
    }
    class Monkey
    {
        public int Age;
    }
}
