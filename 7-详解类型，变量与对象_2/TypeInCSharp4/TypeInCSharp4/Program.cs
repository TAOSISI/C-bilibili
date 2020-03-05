using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeInCSharp4
{
    class Program
    {
        //引用类型的变量与引用类型的实例之间的关系
        //引用类型变量里存储的数据是对象的内存地址
        static void Main(string[] args)
        {
            Student stu;//局部变量是在栈上分配内存的
            stu = new Student();//此时才在内存堆中创建真正的实例
            Student stu2;
            stu2 = stu;//引用类型变量里面装的是实例的地址
            Console.WriteLine(stu.ID);//输出0，即变量的默认值，但是在C#中，本地变量必须有显式的赋值
            //常量为值不可以改变的变量
            const int x = 100;
            Console.WriteLine(x);
            //x = 200;
            //装箱与拆箱
            int y = 10;
            object obj = x;//即装箱
            int z = (int)obj;//拆箱，会损失性能
        }
    }
    class Student//类是典型的引用类型
    {
        //为Student类创造两个实例
        public uint ID;//都是结构体类型的变量，结构体都是值类型，所以这两个也是值类型的变量
        public ushort Score;//改成public即可从外部访问

    }
}
