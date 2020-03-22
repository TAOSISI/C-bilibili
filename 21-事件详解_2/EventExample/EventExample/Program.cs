using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace EventExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();//事件的拥有者
            timer.Interval = 1000;
            Boy boy = new Boy();//事件的响应者
            Girl girl = new Girl();
            timer.Elapsed += boy.Action;//事件的成员，+=是事件订阅的操作符
            timer.Elapsed += girl.Action;
            timer.Start();
            Console.ReadLine();
        }
    }
    class Boy
    {
        internal void Action(object sender, ElapsedEventArgs e)//事件的处理器
        {
            Console.WriteLine("Jump!");
        }
    }
    class Girl
    {
        internal void Action(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Sing!");
        }
    }
}
