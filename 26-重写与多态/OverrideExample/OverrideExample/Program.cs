using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = new Vehicle();
            Car c = new Car();
            c.Run();
            v.Run();
            Console.WriteLine(v.Speed);
            Vehicle r = new RaceCar();
            r.Run();
            RaceCar rc = new RaceCar();
            rc.Run();
            Vehicle v1 = new Car();
            v1.Run();
            Console.WriteLine(v1.Speed);
            Console.ReadKey();
        }
    }
    class Vehicle
    {
        private int _speed;
        public virtual int Speed//属性也是可以被重写的
        {
            get { return _speed;}
            set { _speed = value; }
        }
        public virtual void Run()
        {
            Console.WriteLine("I'm running!");
            _speed = 100;
        }
    }
    class Car : Vehicle
    {
        private int _rpm;
        public override int Speed
        {
            get
            {
                return _rpm / 100 ;
            }

            set
            {
                _rpm = value * 100 ;
            }
        }
        public override void Run()
        {
            Console.WriteLine("Car is running!");
            _rpm = 5000;
        }
    }
    class RaceCar :Car
    {
        public void Run()//类成员的隐藏
        {
            Console.WriteLine("Race Car is running!");
        }
    }
}
