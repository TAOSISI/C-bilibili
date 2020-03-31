using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGeneric3
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> list = new List<int>();//用整型刻画
            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            IDictionary<int, string> dict = new Dictionary<int, string>();
            dict[1] = "Timothy";
            dict[2] = "Michael";
            Console.WriteLine($"Student #1 is {dict[1]}");
            Console.WriteLine($"Student #2 is {dict[2]}");

            Console.ReadKey();
        }
    }
}
