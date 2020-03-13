using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersExample3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student outterStu = new Student() { Name = "Tim" };
            Console.WriteLine("HashCode={0}, Name={1}", outterStu.GetHashCode(), outterStu.Name);
            Console.WriteLine("-----------------------------");
            IWantSideEffect(ref outterStu);
            Console.WriteLine("HashCode={0}, Name={1}", outterStu.GetHashCode(), outterStu.Name);
            SomeSideEffect(ref outterStu);
            Console.WriteLine("HashCode={0}, Name={1}", outterStu.GetHashCode(), outterStu.Name);
            Console.ReadKey();
        }
        static void SomeSideEffect(ref Student stu)
        {
            stu.Name = "Tom";
            Console.WriteLine("HashCode={0}, Name={1}", stu.GetHashCode(), stu.Name);
        }
        static void IWantSideEffect(ref Student stu)//引用类型的引用参数
        {
            stu = new Student() { Name = "TOM" };
            Console.WriteLine("HashCode={0}, Name={1}", stu.GetHashCode(),stu.Name);
        }
    }
    class Student
    {
        public string Name { get; set; }
    }
}
