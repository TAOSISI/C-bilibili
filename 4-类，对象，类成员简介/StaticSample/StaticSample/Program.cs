using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaticSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");//类的方法，.是成员访问操作符
            Form form = new Form();
            form.Text = "Hello";//实例的方法和属性
            form.ShowDialog();

        }
    }
}
