using System;

namespace MyLib
{
    public class Vehicle
    {
        public string Owner { get; set; }
        protected int _rpm;//protected可以跨程序集
        private int _fuel;//private会限制访问成员在类的类体中，加下划线的一般是实例私有字段
        public void Refuel()
        {
            this._fuel = 100;
        }
        protected void Burn(int fuel)
        {
            _fuel -= fuel;
        }
        public void Accelerate(int fuel)
        {
            Burn(fuel);
            _rpm += 1000;
        }
        public int Speed { get { return _rpm / 100; } }//只读属性
    }
    public class Car : Vehicle
    {
        public void TurboAccelerate()//涡轮增压加速
        {
            Burn();
            Burn();
            _rpm += 3000;
        }
        public void ShowOwner()
        {
            Console.WriteLine(base.Owner);
        }
    }
}
