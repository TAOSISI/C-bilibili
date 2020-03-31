using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloOOP2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(Car);
            Type tb = t.BaseType;
            Console.WriteLine(tb.FullName);

            Type tTop = tb.BaseType;
            Console.WriteLine(tTop.BaseType==null);//object是没有基类的

            //是一个，is a，一个子类的实例从语义上来说也是父类的实例

            Vehicle vehicle = new Car();
            object o1 = new Vehicle();
            object o2 = new Car();

            Console.ReadKey();
        }
    }
    class Vehicle
    {

    }
    class Car : Vehicle
    {

    }
}

