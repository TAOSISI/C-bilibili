using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExample

{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            //c.PrintXTo1(3);
            int result = c.SumFrom1ToX(100);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
    class Calculator
    {
        //public void PrintXTo1(int x)
        //{
        //    for (int i = x; i > 0; i--)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        //public void PrintXTo1(int x)
        //{
        //    if (x == 1)
        //    {
        //        Console.WriteLine(x);
        //    }
        //    else
        //    {
        //        Console.WriteLine(x);
        //        PrintXTo1(x - 1);
        //    }
        //}
        //public int SumFrom1ToX(int X)
        //{
        //    int result = 0;
        //    for (int i = 1; i < X+1; i++)
        //    {
        //        result = result + i;
        //    }
        //    return result;
        //}
        public int SumFrom1ToX(int X)
        {
            if (X == 1)
            {
                return 1;
            }
            else
            {
                int result = X + SumFrom1ToX(X - 1);
                return result;
            }
        }
    }
}
