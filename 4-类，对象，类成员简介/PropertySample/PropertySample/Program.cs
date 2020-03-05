using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertySample
{
    class Program
    {
        static void Main(string[] args)
        {
            //以属性侧重的类
            AdventureWorksLT2012Entities proxy = new AdventureWorksLT2012Entities();
            foreach(Product p in proxy.Products)
            {
                Console.WriteLine(p.Name);
            }
            Console.WriteLine("========================");
            Console.WriteLine(proxy.Products.Count());
        }
    }
}
