using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstuctorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student stu = new Student();//这句话中就调用了student构造器,当有了带参数的构造器后，默认构造器就会报错
            Student stu = new Student(2,"Mr.Okay");
            Console.WriteLine(stu.ID);//此时会输出0,0是默认构造器将内存中的对象（字段）初始化构造。
            Console.WriteLine("=========================");
            Student stu2 = new Student();//此时并非默认构造器，而是下面定义的不带参数的构造器
            Console.WriteLine(stu2.ID);
            Console.ReadKey();
        }
    }
    class Student
    {
        //当声明一个类，但是没有声明构造器，此时编译器会自动生成默认构造器
        //构造器没有返回的类型，快速输入ctor+Tab+Tab
        public Student()
        {
            this.ID = 1;
            this.Name = "NO name";//此刻执行上述程序则会输出1
        }
        //如果此时要求所有的学生必须带有学号，那么需要构造一个带有参数的构造器
        public Student(int initId, string initName)
        {
            this.ID = initId;
            this.Name = initName;
        }
        public int ID;
        public string Name;
    }
}
