using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student stu = new Student(1, "Tim"); //一种数据结构
            //Console.WriteLine(stu.ID);
            //Console.WriteLine(stu.Name);
            //stu.Report();

            //Type t = typeof(Student);//一种数据类型
            //object o = Activator.CreateInstance(t, 1, "Tim");
            //Console.WriteLine(o.GetType().Name);
            ////Console.WriteLine(o);//没有name的属性
            //Student stu = o as Student;
            //Console.WriteLine(stu.Name);

            Type t = typeof(Student);
            dynamic stu = Activator.CreateInstance(t, 1, "Tim");
            Console.WriteLine(stu.Name);

            Console.WriteLine(Student.Amount);//代表现实世界中的“种类”

            Student s1 = new Student(1, "Tim");
            Student s2 = new Student(2, "Tom");
            Console.WriteLine(Student.Amount);
            Console.ReadKey();
        }
    }
    class Student
    {
        public static int Amount { get; set; }//静态属性
        static Student()//静态构造器，用来初始化静态成员
        {
            Amount = 100;
        }

        public Student(int id, string name)//实例构造器
        {
            this.ID = id;
            this.Name = name;
            Amount++;
        }
        ~Student()//析构器
        {
            Amount--;
            Console.WriteLine("Bye bye! Release the system resources ...");
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public void Report()
        {
            Console.WriteLine($"I'm #{this.ID} student, my name is {this.Name}.");
        }
    }
}
