using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Type myType = typeof(Form);
            Console.WriteLine(myType.FullName);
            Console.WriteLine(myType.IsClass);
            //枚举类型，给出一个集合，只可以在该集合中选择值
            Form f = new Form();
            f.WindowState = FormWindowState.Maximized;//此时FormWindowState是枚举类型，只有三个选项
            f.ShowDialog();
            Console.ReadKey();
        }
    }
}
