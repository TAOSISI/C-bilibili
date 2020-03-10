using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatementsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            x++;
            Console.WriteLine(x);
            x--;
            Console.WriteLine(x);
            ++x;
            Console.WriteLine(x);
            --x;
            Console.WriteLine(x);
            int score = 90;
            if (score >= 60)//复合语句
            {
                if (score >= 85)
                {
                    Console.WriteLine("Best!");
                }
                else
                {
                    Console.WriteLine("Good!");
                }
            }
            else
            {
                Console.WriteLine("Failed!");
            }
            Console.ReadKey();
        }
    }
}
