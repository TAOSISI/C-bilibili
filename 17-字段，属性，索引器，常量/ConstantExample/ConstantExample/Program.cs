using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WASPEC.WebsiteURL);
        }
    }
    class WASPEC
    {
        public const string WebsiteURL = "http://www.waspec.org//";
    }
}
