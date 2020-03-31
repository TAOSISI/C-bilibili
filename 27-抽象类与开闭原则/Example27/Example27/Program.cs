using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example27
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Car();//父类类型变量引用子类实例
            v.Run();

            Console.ReadKey();
        }
    }
    abstract class Student//函数成员没有被完全实现的类就是抽象类
    {
        abstract public void Study();//完全没有被实现的方法，也就是抽象方法，此时类也变成了抽象类
    }
    interface VehicleBase//完全未实现
    {
        void Stop();
        void Fill();
        void Run();
    }
    abstract class Vehicle:VehicleBase//抽象类，专为做基类复用而生,做不完全的实现逻辑的类
    {
        public void Stop()
        {
            Console.WriteLine("Stopped!");
        }
        public void Fill()
        {
            Console.WriteLine("Pay and fill...");
        }
        abstract public void Run();
    }
    class Car:Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Car is running!");
        }
    }
    class Truck:Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Truck is running!");
        }
    }
    class RaceCar : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Race car is running!");
        }
    }
}
