using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperatorsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 100; ;//用来声明隐式类型的变量，由于C#是强类型的语言，要求每个变量都要有数据类型
            int y;//显性类型变量
            Console.WriteLine(x.GetType().Name);

            //new操作符
            Form myForm = new Form()//封装，通过变量访问实例
            {
                Text = "Hello",
                FormBorderStyle = FormBorderStyle.SizableToolWindow
            };
            
            //myForm.Text = "Hello";
            myForm.ShowDialog();
            var person = new { Name = "Mr.Okay", Age = 34 };//为匿名类型创建对象，并且隐式类型变量引用实例
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            Console.WriteLine(person.GetType().Name);
            Console.ReadKey();
        }
    }
}
