using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperatorsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.File.Create("D:\\C#\\Bilibili\\HelloWorld.txt");
            Form myForm = new Form();
            myForm.Text = "Hello, World!";
            myForm.ShowDialog();//成员访问操作符的使用方法
            Calculator c = new Calculator();
            double x = c.Add(3.0, 5.0);
            Console.WriteLine(x);
            Action myAction = new Action(c.PrintHello); //委托，仅访问c.PrintHello这个名字，并非调用，所以不需要写()
            myAction();
            int[] myIntArray1 = new int[10];
            int[] myIntArray2 = new int[] { 1, 2, 3, 4, 5 };//数组访问操作符，初始化器
            Console.WriteLine(myIntArray2[0]);
            Console.WriteLine(myIntArray2[4]);
            Console.WriteLine(myIntArray2[myIntArray2.Length - 1]);
            Dictionary<string, Student> StuDic = new Dictionary<string, Student>();//当一个类后带有尖括号，代表泛型类
            for (int i = 1; i <= 100; i++)
            {
                Student stu = new Student();
                stu.Name = "s_" + i.ToString();
                stu.Score = 100 + i;
                StuDic.Add(stu.Name, stu);
            }
            Student number6 = StuDic["s_6"];
            Console.WriteLine(number6.Score);
            //default获取默认值
            int d = default(int);//结果返回0
            Console.WriteLine(d);
            Form myForm1 = new Form();
            Console.WriteLine(myForm1 == null);

            Console.ReadKey();
        }
    }
    enum Level
    {
        //Low,Mid,High
        Low = 0,
        Mid = 1,
        High = 2
    }
    class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
        public void PrintHello()
        {
            Console.WriteLine("Hello");
        }
    }
    class Student
    {
        public string Name;
        public int Score;

    }
}
