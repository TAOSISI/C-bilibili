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
            Calculator c = new Calculator();
            int r = c.Add("0", "0");
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
    class Calculator
    {
        public int Add(string arg1, string arg2)
        {
            int a = 0;
            int b = 0;
            bool hasError = false;
            try
            {
                a = int.Parse(arg1);
                b = int.Parse(arg2);
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
                hasError = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Your argument(s) are not number.");
                hasError = true;
            }
            catch (OverflowException)
            {
                //Console.WriteLine("Out of range!");
                //hasError = true;
                throw;
            }
            finally//一定会执行
            {
                if (hasError)
                {
                    Console.WriteLine("Execution has ERROR!");
                }
                else
                {
                    Console.WriteLine("Done!");
                }
            }
            int result = a + b;
            return result;
        }
    }
}
