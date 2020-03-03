using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample4
{
    //接口，解耦和依赖倒置原则如何被单元测试应用
    //本例以生产电扇的厂商，电源有保护功能，电扇依赖在电源上
    //先写出紧耦合，再用接口将耦合松开，在进行单元测试
    class Program
    {
        static void Main(string[] args)
        {
            var fan = new DeskFan(new PowerSupply());
            Console.WriteLine(fan.Work());
            Console.ReadKey();
        }
    }
    //解耦,设定接口，并把所有的耦合类型更改为接口类型
    public interface IPowerSupply
    {
        int GetPower();
    }
    public class PowerSupply:IPowerSupply
    {
        //电源
        public int GetPower()
        {
            return 100;//标准电源，永远输出只有100
        }
    }
    public class DeskFan
    {
        private IPowerSupply _powerSupply;//紧耦合
        public DeskFan(IPowerSupply powerSupply)
        {
            //构造器ctor+tab+tab
            _powerSupply = powerSupply;
        }
        public string Work()
        {
            int power = _powerSupply.GetPower();
            if (power <= 0)
            {
                return "Won't work.";
            }
            else if (power < 100)
            {
                return "Slow";
            }
            else if (power < 200)
            {
                return "Work Fine.";
            }
            else
            {
                return "Warning!";
            }
        }
    }
}
