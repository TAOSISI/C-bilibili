using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongTyped
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;//int是标准整数类型，在内存中占据4个字节，一个字节是8个比特位，即32个比特位
            x = 100;
            long y;//长的整数类型，在内存中占据8个字节，即64位
            y = 100L;
            bool a;bool b;
            a = true;
            b = false;
        }
    }
}
