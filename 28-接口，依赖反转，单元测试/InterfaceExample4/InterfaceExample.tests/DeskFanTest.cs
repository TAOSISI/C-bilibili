using System;
using Xunit;
using InterfaceExample4;
using Moq;

namespace InterfaceExample.tests
{
    public class DeskFanTest
    {
        [Fact]//特征，特性
        public void PowerLowerThanZero_OK()
        {
            var mock = new Mock<IPowerSupply>();
            mock.Setup(ps => ps.GetPower()).Returns(() => 0);
            var fan = new DeskFan(mock.Object);
            //var fan = new DeskFan(new PowerSupplyLowerThanZero());
            var expected = "Won't work.";
            var actual = fan.Work();
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void PowerHigherThan200_Warning()
        {
            var mock = new Mock<IPowerSupply>();
            mock.Setup(ps => ps.GetPower()).Returns(() => 220);
            var fan = new DeskFan(mock.Object);
            //var fan = new DeskFan(new PowerSupplyHigherThan200());
            var expected = "Warning!";
            var actual = fan.Work();
            Assert.Equal(expected, actual);
        }
    }
    class PowerSupplyLowerThanZero : IPowerSupply
    {
        public int GetPower()
        {
            return 0;
        }
    }
    class PowerSupplyHigherThan200 : IPowerSupply
    {
        public int GetPower()
        {
            return 220;
        }
    }
    //使用moq来直接创建实现了接口方法的实例
}
