using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatementsExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            int sum = 0;
            do//先执行再判断，do的循环体至少执行一次
            {
                Console.WriteLine("Please input first number.");
                string str1 = Console.ReadLine();
                if (str1.ToLower() == "end")//将所有的字符转换为小写
                {
                    break;
                }
                int x;
                try
                {
                    x = int.Parse(str1);
                }
                catch
                {
                    Console.WriteLine("First number has problem! Restart.");
                    continue;//放弃本次循环，开始下一个循环
                }

                Console.WriteLine("Please input second number.");
                string str2 = Console.ReadLine();
                if (str2.ToLower() == "end")//将所有的字符转换为小写
                {
                    break;
                }
                int y;
                try
                {
                    y = int.Parse(str2);
                }
                catch
                {
                    Console.WriteLine("Second number has problem! Restart.");
                    continue;
                }

                sum = x + y;
                if (sum == 100)
                {
                    score++;
                    Console.WriteLine("Correct!{0}+{1}={2}", x, y, sum);
                }
                else
                {
                    Console.WriteLine("Error!{0}+{1}={2}", x, y, sum);
                }
            }
            while (sum == 100);
            Console.WriteLine("Your score is {0}.", score);
            Console.ReadKey();
        }
    }
}
