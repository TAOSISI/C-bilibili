using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace HelloAccess2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Owner = "Timothy";
            Console.WriteLine(vehicle.Owner);

            Car car = new Car();
            car.Accelerate(1);
            car.Accelerate(1);
            Console.WriteLine(car.Speed);

            car.TurboAccelerate();
            Console.WriteLine(car.Speed);

            Bus bus = new Bus();

            Console.ReadKey();
        }
    }
    class Bus : Vehicle
    {
        public void SlowAccelerate()
        {
            Burn(1);
            _rpm += 500;
        }
    }
}
