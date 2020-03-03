using System;
using System.Collections;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 1, 2, 3, 4, 5 };//整形数组
            ArrayList nums2 = new ArrayList { 1, 2, 3, 4, 5 };
            Console.WriteLine(Sum(nums1));
            Console.WriteLine(Avg(nums1));
            //在不使用接口的情况下，只能再重新写两个符合ArrayList的函数
            Console.WriteLine(Avg(nums2));
            Console.ReadKey();
        }
        //static int Sum(int[] nums)
        //{
        //    int sum = 0;
        //    foreach(var n in nums)//要求nums这一对象必须可迭代
        //    {
        //        sum += n;
        //    }
        //    return sum;
        //}
        //static double Avg(int[] nums)
        //{
        //    int sum = 0;double count = 0;
        //    foreach(var n in nums)
        //    {
        //        sum += n;count++;
        //    }
        //    return sum / count;
        //}
        static int Sum(IEnumerable nums)
        {
            int sum = 0;
            foreach (var n in nums)//要求nums这一对象必须可迭代
            {
                sum += (int)n;
            }
            return sum;
        }
        static double Avg(IEnumerable nums)
        {
            int sum = 0; double count = 0;
            foreach (var n in nums)
            {
                sum += (int)n; count++;
            }
            return sum / count;
         }
    }
}
