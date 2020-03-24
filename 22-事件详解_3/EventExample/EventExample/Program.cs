using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EventExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();//事件的拥有者
            Waiter waiter = new Waiter();//事件的响应者
            customer.Order += waiter.Action;//事件，事件的处理器，事件的订阅
            customer.Action();
            customer.PayTheBill();
            Console.ReadKey();
        }
    }
    public class OrderEventArgs : EventArgs
    {
        public string DishName { get; set;}
        public string Size { get; set; }
    }
    //声明点菜事件，事件是基于委托的，事件需要委托类型进行约束，即规定的事件需要发送什么样的消息给响应者，也规定了响应者收到什么样的事件消息
    public delegate void OrderEventHandler(Customer customer, OrderEventArgs e);

    public class Customer//首先定义事件的拥有者，类
    {
        private OrderEventHandler orderEventHandler;//用来存储或引用事件处理器
        public event OrderEventHandler Order;
        public double Bill { get; set; }
        public void PayTheBill()
        {
            Console.WriteLine("I will pay ${0}.", this.Bill);
        }
        public void WalkIn()
        {
            Console.WriteLine("Walk into the restaurant.");
        }
        public void SitDown()
        {
            Console.WriteLine("Sit down.");
        }
        public void Think()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Let me think ...");
                Thread.Sleep(1000);
            }
            this.OnOrder("Kongpao Chicken", "large");
        }
        protected void OnOrder(string dishName, string size)
        {
            if (this.Order!=null)
            {
                OrderEventArgs e = new OrderEventArgs();
                e.DishName = dishName;
                e.Size = size;
                this.Order.Invoke(this, e);
            }
        }
        public void Action()
        {
            Console.ReadLine();
            this.WalkIn();
            this.SitDown();
            this.Think();

        }
    }
    public class Waiter
    {
        public void Action(Customer customer, OrderEventArgs e)
        {
            Console.WriteLine("I will serve you the dish - {0}.", e.DishName);
            double price = 10;
            switch (e.Size)
            {
                case "small":
                    price = price * 0.5;
                    break;
                case "large":
                    price = price * 1.5;
                    break;
                default:
                    break;
            }
            customer.Bill += price;
        }
    }
}
