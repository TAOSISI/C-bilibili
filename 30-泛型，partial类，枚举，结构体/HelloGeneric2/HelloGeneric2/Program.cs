using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGeneric2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.ID = 100000000001;
            student.Name = "Tim";

        }
    }
    interface IUnique<TId>//泛型接口
    {
        TId ID { get; set; }
    }
    class Student : IUnique<ulong>//泛型类
    {
        public ulong ID { get; set; }
        public string Name { get; set; }
    }
}
