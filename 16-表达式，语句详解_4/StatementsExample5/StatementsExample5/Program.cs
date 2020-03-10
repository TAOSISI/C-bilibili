using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatementsExample5
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting("Mr.Okay");
            var result = WhoIsWho("Mr.Okay!");
            Console.WriteLine(result);
            Console.ReadKey();
        }
        static string WhoIsWho(string alias)//必须保证方法一定可以return
        {
            if (alias == "Mr.Okay!")
            {
                return "Tim";
            }
            return "I don't Know!";
        }
        static void Greeting(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return;//尽早return的原则
            }
            Console.WriteLine("Hello,{0}!",name);
        }
    }
}
