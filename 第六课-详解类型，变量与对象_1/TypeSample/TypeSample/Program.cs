using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Type myType = typeof(Form);
            PropertyInfo[] pInfos = myType.GetProperties();//属性的信息
            MethodInfo[] mInfos = myType.GetMethods();//方法的信息
            Console.WriteLine(myType.BaseType.FullName);
            foreach (var p in pInfos)
            {
                Console.WriteLine(p.Name);
            }
            Console.WriteLine("++++++++++++++++++++++++++");
            foreach (var m in mInfos) 
            {
                Console.WriteLine(m.Name);
            }
            Console.ReadKey();
        }
    }
}
