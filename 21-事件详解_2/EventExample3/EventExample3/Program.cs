using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventExample3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyForm form = new MyForm();//事件的拥有者和响应者
            form.Click += form.FormClicked;
            form.ShowDialog();
        }
    }
    class MyForm : Form
    {
        internal void FormClicked(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }
    }
}
