using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MulticastDelegateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student() { ID = 1, PenColor = ConsoleColor.Yellow };
            Student stu2 = new Student() { ID = 2, PenColor = ConsoleColor.Green };
            Student stu3 = new Student() { ID = 3, PenColor = ConsoleColor.Red };

            Action action1 = new Action(stu1.DoHomework);
            Action action2 = new Action(stu2.DoHomework);
            Action action3 = new Action(stu3.DoHomework);

            action1.Invoke();//第二种同步调用（间接）
            action2.Invoke();
            action3.Invoke();//单播委托
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Main thread {0}.", i);
                Thread.Sleep(1000);
            }

            action1 += action2;//多播委托，第三种同步调用（间接）
            action1 += action3;
            action1.Invoke();
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Main thread {0}.", i);
                Thread.Sleep(1000);
            }

            stu1.DoHomework();//第一种同步调用（直接）
            stu2.DoHomework();
            stu3.DoHomework();
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Main thread {0}.",i);
                Thread.Sleep(1000);
            }

            action1.BeginInvoke(null, null);//异步调用，为了避免争抢资源，可以给线程加锁
            action2.BeginInvoke(null, null);
            action3.BeginInvoke(null, null);
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Main thread {0}.", i);
                Thread.Sleep(1000);
            }

            Thread thread1 = new Thread(new ThreadStart(stu1.DoHomework));//显式异步调用
            Thread thread2 = new Thread(new ThreadStart(stu2.DoHomework));
            Thread thread3 = new Thread(new ThreadStart(stu3.DoHomework));
            thread1.Start();
            thread2.Start();
            thread3.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Main thread {0}.", i);
                Thread.Sleep(1000);
            }

            Task task1 = new Task(new Action(stu1.DoHomework));//显式异步调用
            Task task2 = new Task(new Action(stu2.DoHomework));
            Task task3 = new Task(new Action(stu3.DoHomework));
            task1.Start();
            task2.Start();
            task3.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Main thread {0}.", i);
                Thread.Sleep(1000);
            }


            Console.ReadKey();
        }
    }
    class Student
    {
        public int ID { get; set; }
        public ConsoleColor PenColor { get; set; }

        public void DoHomework()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = this.PenColor;
                Console.WriteLine("Student {0} doing homework {1} hour(s).",this.ID,i);
                Thread.Sleep(1000);
            }
        }
    }
}
