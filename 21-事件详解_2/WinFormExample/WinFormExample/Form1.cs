using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.button3.Click += this.button1_Click;//这是一种挂接事件处理器的方法
            //this.button3.Click += new EventHandler(this.button1_Click);//委托
            //this.button3.Click += delegate (object sender, EventArgs e)//匿名委托
            //{
            //    this.textBox1.Text = "哈哈！";
            //};
            this.button3.Click += (sender, e) =>//lameta表达式
              {
                  this.textBox1.Text = "HOHO！";
              };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender==this.button1)
            {
                this.textBox1.Text = "Hello!";
            }
            if (sender==this.button2)
            {
                this.textBox1.Text = "World!";
            }
            if (sender==this.button3)
            {
                this.textBox1.Text = "Mr.Okay!";
            }
        }
    }
}
