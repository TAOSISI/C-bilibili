using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOvcerFlow
{
    class Program
    {
        static void Main(string[] args)

        {
            BadGuy bg = new BadGuy();
            bg.BadMethod();
            unsafe//明确这是不安全的代码，需要在项目中StackOvcerFlow属性，生成中设置可以使用不安全代码
            {
                int * p = stackalloc int[9999999];//明确在栈上切内存
            }

        }
    }
    class BadGuy
    {
        public void BadMethod()
        {
            int x = 100;
            this.BadMethod();//永远没有终止的时候，只递不归，每调用一次，就会在栈上切出一块内存，所以栈会爆炸
        }
    }
}
