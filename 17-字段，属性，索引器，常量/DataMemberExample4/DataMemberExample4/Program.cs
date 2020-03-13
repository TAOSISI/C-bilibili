using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student stu1 = new Student();
            //stu1.Age = 20;

            //Student stu2 = new Student();
            //stu2.Age = 20;

            //Student stu3 = new Student();
            //stu3.Age = 20;

            //int avgAge = (stu1.Age + stu2.Age + stu3.Age) / 3;
            //Console.WriteLine(avgAge);
            //try{
            //    Student stu1 = new Student();
            //    stu1.SetAge(20);
            //    Student stu2 = new Student();
            //    stu2.SetAge(20);
            //    Student stu3 = new Student();
            //    stu3.SetAge(20);

            //    int avgAge = (stu1.GetAge() + stu2.GetAge() + stu3.GetAge()) / 3;
            //    Console.WriteLine(avgAge);
            //    Console.ReadKey();
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            try
            {
                Student stu1 = new Student();
                stu1.Age = 20;
                Student stu2 = new Student();
                stu2.Age = 20;
                Student stu3 = new Student();
                stu3.Age = 20;//字段是如何经过getset方法对演化为属性的

                int avgAge = (stu1.Age + stu2.Age + stu3.Age) / 3;
                Console.WriteLine(avgAge);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    class Student
    {
        private int age;//即从外界无法直接访问该字段
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value >=0 && value <= 120)//没有对value进行变量的声明，因为微软准备了value这个名称的变量，是上下文关键字
                {
                    this.age = value;//在setor访问器中准备好了这个关键字，代表由用户传进来的值
                }
                else
                {
                    throw new Exception("Age value has ERROR!");
                }
            }
        }
        public int GetAge()
        {
            return this.age;
        }
        //为字段设置返回值，保护字段不被非法值污染
        public void SetAge(int value)
        {
            if (value >= 0 && value <= 120)
            {
                this.age = value;
            }
            else
            {
                throw new Exception("Age value has ERROR!");
            }
        }
    }
}
