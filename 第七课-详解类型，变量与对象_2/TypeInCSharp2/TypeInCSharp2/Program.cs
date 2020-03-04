using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeInCSharp2
{
    class Program
    {  
         //变量=以变量名所对应的内存地址为起点，以其数据类型所要求的存储空间为长度的一块内存区域
        static void Main(string[] args)
        {
            //Student.Amount;
            Student stu = new Student();
            //stu.Age;
            int[] array = new int[100];//方括号为数组，表示声明了一个长度为100的整型的数组
            //array[0];//从0开始
            int x = 100;//局部变量就是声明在方法体和函数体中的变量
        }
    }
    class Student
    {
        public static int Amount;//静态成员是隶属于类而非成员
        public int Age;//成员变量，类似于属性
        public string Name;
        public double Add(double a,double b)//a和b是值参数变量，ref修饰是引用参数变量，out修饰是输出参数变量
        {
            return a + b;
        }
    }
}
