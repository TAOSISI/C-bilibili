using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMemberExample3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Brush.DefaultColor.Red);
            Console.WriteLine(Brush.DefaultColor.Green);
            Console.WriteLine(Brush.DefaultColor.Blue);

            //Brush.DefaultColor=new Color() { Red = 255, Green = 255, Blue = 255 };//静态只读字段也不能够被赋值
            //静态只读字段的功能是为实例和类型保存一旦初始化后就不希望再改变的值。
        }
    }
    class Color
    {
        public int Red;
        public int Green;
        public int Blue;
    }
    class Brush
    {
        //public static readonly Color DefaultColor = new Color()//类的静态只读字段，
        //{
        //    Red = 0,
        //    Green = 0,
        //    Blue = 0
        //};
        public static readonly Color DefaultColor;
        static Brush()//静态构造函数
        {
            Brush.DefaultColor = new Color() { Red = 0, Green = 0, Blue = 0 };
        }
    }
}
