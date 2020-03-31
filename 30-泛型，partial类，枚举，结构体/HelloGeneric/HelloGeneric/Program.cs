using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple() { Color = "Red" };
            Book book = new Book() { Name = "New Book" };
            Box<Apple> box1 = new Box<Apple>() { Cargo = apple };
            Box<Book> box2 = new Box<Book>() { Cargo = book };
            Console.WriteLine(box1.Cargo.Color);
            Console.WriteLine(box2.Cargo.Name);

            Console.ReadKey();
        }
    }
    class Book
    {
        public string Name { get; set; }
    }

    class Apple
    {
        public string Color { get; set; }
    }
    class Box<TCargo>//将普通类改装成泛型的方法就是在后面加上一对尖括号，其中的内容为类型参数
    {
        public TCargo Cargo { get; set; }
    }
}
