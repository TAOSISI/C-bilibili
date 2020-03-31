using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            RaceCar raceCar = new RaceCar();
            Car car = new Car();
            car.ShowOwner();
            Console.ReadKey();
        }
    }
    class Vehicle
    {
        public Vehicle()//实例构造器
        {
            this.Owner = "N/A";//先执行基类的构造器
        }
        public string Owner { get; set; }//全盘继承
    }
    class Car: Vehicle
    {
        public Car()
        {
            this.Owner = "Car Owner";//再执行子类的构造器
        }
        public void ShowOwner()
        {
            Console.WriteLine(base.Owner);//base的关键字只能向上访问一层
        }
    }
    class RaceCar : Car
    {

    }
}
