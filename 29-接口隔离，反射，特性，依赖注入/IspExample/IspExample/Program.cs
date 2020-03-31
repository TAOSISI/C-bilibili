using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IspExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver driver1 = new Driver(new Car());
            driver1.Drive();

            var driver2 = new Driver(new Truck());
            driver2.Drive();

            var driver3 = new Driver(new HeavyTank());
            driver3.Drive();

            Console.ReadKey();

            ITank tank = new HeavyTank();
            //+++++++++++++分割线+++++++++++++++++++++++++++++
            var t = tank.GetType();
            object o = Activator.CreateInstance(t);
            MethodInfo fireMi = t.GetMethod("Fire");
            MethodInfo runMi = t.GetMethod("Run");
            fireMi.Invoke(o, null);
            runMi.Invoke(o, null);

            Console.ReadKey();
        }
    }
    class Driver
    {
        private IVehicle _vehicle;
        public Driver(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }
        public void Drive()
        {
            _vehicle.Run();
        }
    }
    interface IVehicle
    {
        void Run();
    }
    class Car : IVehicle
    {
        public void Run()
        {
            Console.WriteLine("Car is running ...");
        }
    }
    class Truck : IVehicle
    {
        public void Run()
        {
            Console.WriteLine("Truck is running ...");
        }
    }
    interface IWeapon
    {
        void Fire();
    }
    interface ITank:IVehicle,IWeapon//一个接口对多个接口的继承
    {
    }
    class LightTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom!");
        }

        public void Run()
        {
            Console.WriteLine("Ka ka ka ...");
        }
    }
    class MidiumTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom!!");
        }

        public void Run()
        {
            Console.WriteLine("Ka! ka! ka! ...");
        }
    }
    class HeavyTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom!!!");
        }

        public void Run()
        {
            Console.WriteLine("Ka!! ka!! ka!! ...");
        }
    }
}
