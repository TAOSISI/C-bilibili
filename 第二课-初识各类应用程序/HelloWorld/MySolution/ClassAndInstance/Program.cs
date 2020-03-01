using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAndInstance
{
    class Program 
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Form myForm;
            myForm = new Form();///实例
            myForm.Text = "My Form";
            myForm.ShowDialog();
        }
    }
}
