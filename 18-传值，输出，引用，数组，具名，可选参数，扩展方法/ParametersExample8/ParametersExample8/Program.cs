using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersExample8
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Tim;Tom,Amy.Lisa";
            string[] result = str.Split(';', ',', '.');//必须是参数列表中的最后一个参数，且仅有一个
            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
            //int[] myintArray = new int[] { 1, 2, 3 };
            //int result = CalculateSum(myintArray);
            int result1 = CalculateSum(1, 2, 3);
            Console.WriteLine(result1);
            Console.ReadKey();
        }
        static int CalculateSum(params int[] intArray)
        {
            int sum = 0;
            foreach (var item in intArray)
            {
                sum += item;
            }
            return sum;
        }
    }
}
