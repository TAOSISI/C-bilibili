using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExample4
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                Student stu;
                stu.ID = 1;
                stu.Score = 100;
                Student* pStu = &stu;//指针
                pStu->Score = 99;//箭头符号
                (*pStu).Score = 1000;//取地址符号和取引用符号
                Console.WriteLine(stu.Score);//凡是用.访问的，都是直接访问，用就>-访问的是通过指针的间接访问
                int x = sizeof(Student);
                Console.WriteLine(x);//输出16,8+8
                Console.ReadKey();

            }
        }
    }
    struct Student//c#中严格规定，指针操作，取地址操作，用指针去访问成员操作，只能使用结构体类型，不能操作引用类型
    {
        public int ID;
        public long Score;
    }
}
