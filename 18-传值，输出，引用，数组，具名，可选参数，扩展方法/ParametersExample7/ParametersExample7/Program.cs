using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersExample7
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Tim;Tom,Amy.Lisa";
            string[] result=str.Split(';', ',', '.');
            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
            //int[] myintArray = new int[] { 1, 2, 3 };
            //int result = CalculateSum(myintArray);
            int result = CalculateSum(1, 2, 3);
            Console.WriteLine(result);
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
