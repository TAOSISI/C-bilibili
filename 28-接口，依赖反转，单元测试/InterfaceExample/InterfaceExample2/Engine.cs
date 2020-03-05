using System;
using System.Collections;

namespace InterfaceExample
{
    class Program2
    {
        static void Main(string[] args)
        {
            var engine = new Engine();
            var car = new Car(engine);
            car.Run(3);
            Console.WriteLine(car.Speed);
            Console.ReadKey();
        }
    }
    class Engine
    {
        public int RPM { get; private set; }
        public void Work(int gas)
        {
            this.RPM = 1000 * gas;
        }
    }

    //Car是紧耦合在Engine上的，会导致程序不好调试，所以开发的时候应当避免紧耦合
    class Car
    {
        private Engine _engine;//创造依赖关系
        public Car(Engine engine)
        {
            _engine = engine;
        }
        public int Speed { get; private set; }
        public void Run(int gas)
        {
            _engine.Work(gas);
            this.Speed = _engine.RPM / 100;
        }
    }
}
