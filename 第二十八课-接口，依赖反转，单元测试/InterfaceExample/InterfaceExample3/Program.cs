using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample3
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new PhoneUser(new NokiaPhone());
            //引入接口后，会变成松耦合
            //var user = new PhoneUser(new EricssonPhone());
            user.UsePhone();
            Console.ReadKey();
        }
    }
    //创建用户
    class PhoneUser
    {
        private IPhone _phone;//接口类型
        //构造器接受接口类型的
        public PhoneUser(IPhone phone)
        {
            _phone = phone;
        }
        public void UsePhone()
        {
            _phone.Dail();
            _phone.PickUp();
            _phone.Send();
            _phone.Receive();
        }
    }
    interface IPhone
    {
        //四个方法
        void Dail();
        void PickUp();
        void Send();
        void Receive();
    }
    class NokiaPhone : IPhone
    {
        public void Dail()
        {
            Console.WriteLine("Nokia calling ...");
        }

        public void PickUp()
        {
            Console.WriteLine("Hello! This is Tim!");
        }

        public void Receive()
        {
            Console.WriteLine("Nokia message ring ...");
        }

        public void Send()
        {
            Console.WriteLine("Hello");
        }
    }
    class EricssonPhone : IPhone
    {
        public void Dail()
        {
            Console.WriteLine("Ericsson calling ...");
        }

        public void PickUp()
        {
            Console.WriteLine("Hi! This is Tim!");
        }

        public void Receive()
        {
            Console.WriteLine("Ericsson ring ...");
        }

        public void Send()
        {
            Console.WriteLine("Hi!"); ;
        }
    }
}
