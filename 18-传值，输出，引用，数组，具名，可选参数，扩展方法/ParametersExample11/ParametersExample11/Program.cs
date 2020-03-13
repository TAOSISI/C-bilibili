using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersExample11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>() { 1, 2, 3, 4, 5, 14, 35, 32 };
            //bool result = AllGreaterThanTen(myList);
            bool result = myList.All(i => i > 10);//all是一个扩展方法

            Console.WriteLine(result);
            Console.ReadKey();
        }
        static bool AllGreaterThanTen(List<int> intList)
        {
            foreach (var item in intList)
            {
                if (item<=10)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
