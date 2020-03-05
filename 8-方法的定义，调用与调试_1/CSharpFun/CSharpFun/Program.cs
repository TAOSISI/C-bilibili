using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFun
{
    class Program
    {
        //方法不能独立于类之外
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            Console.WriteLine(c.GetCircleArea(10));
            Console.ReadKey(); 
        }
    }
    class Calculator
    {
        //没有static，说明是非静态方法，也就是实例方法，和实例是绑定的
        //如果加上static是静态方法，是隶属于类，与类绑定的
        public double GetCircleArea(double r)
        {
            return Math.PI * r * r;
        }
        public double GetCylinderVolume(double r,double h)
        {
            return 3.14 * r * r * h;
        }
        public double GetConeVolume(double r,double h)
        {
            //return 3.14 * r * r * h / 3;
            return GetCylinderVolume(r, h) / 3;//复用，自顶向下，初步求精
        }
    }
}
