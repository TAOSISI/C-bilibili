using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMemberExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student(1);
            Console.WriteLine(stu1.ID);
            //stu1.ID = 2;//只读字段是不能赋值的
        }
    }
    class Student
    {
        public readonly int ID;
        public int Age;
        public int Score;
        public Student(int id)
        {
            this.ID = id;
        }
        public static int AverageAge;
        public static int AverageScore;
        public static int Amount = 100;
    }
}
