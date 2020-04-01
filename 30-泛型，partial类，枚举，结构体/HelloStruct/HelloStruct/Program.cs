using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student() { ID=101,Name="Tim"};
            object obj = stu1;//装箱
            Student stu2 = (Student)obj;//拆箱
            Console.WriteLine($"#{stu2.ID} Name:{stu2.Name}");

            Student stu3 = stu1;
            stu3.Name = "Michael";
            stu3.ID = 1001;
            Console.WriteLine($"#{stu3.ID} Name:{stu3.Name}");

            stu1.Speak();

            Student stu4 = new Student(1, "Tcs");
            stu4.Speak();
            Console.ReadKey();
        }
    }
    interface ISpeak
    {
        void Speak();
    }
    struct Student:ISpeak//结构体也可以实现接口
    {
        public Student(int id,string name)//结构体不允许显示的无参构造器，但是允许有参构造器
        {
            this.ID = id;
            this.Name = name;
        }
        public int ID { get; set; }
        public string Name { get; set; }

        public void Speak()
        {
            Console.WriteLine($"I'm #{this.ID} student {this.Name}");
        }
    }
}
