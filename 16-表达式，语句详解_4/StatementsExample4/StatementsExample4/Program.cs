using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatementsExample4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 1, 2, 3, 4, 5, 6 };
            IEnumerator enumerator = intArray.GetEnumerator();//整型数组的迭代器，指月
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            enumerator.Reset();
            while (enumerator.MoveNext())//因为第一遍循环的时候，迭代器已经指向最后一个元素，所以不执行
            {
                Console.WriteLine(enumerator.Current);
            }
            Console.ReadKey();
            List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6 };
            foreach (var current in intList)
            {
                Console.WriteLine(current);
            }
        }
    }
}
