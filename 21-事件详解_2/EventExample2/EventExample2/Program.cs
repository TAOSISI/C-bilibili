﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();//事件拥有者
            Controller controller = new Controller(form);//事件的响应者
            form.ShowDialog();
        }
    }
    class Controller
    {
        private Form form;
        public Controller(Form form)
        {
            if (form != null)
            {
                this.form = form;
                this.form.Click += this.FormClicked;//事件本身和事件订阅
            }
        }
        private void FormClicked(object sender, EventArgs e)//事件处理器
        {
            this.form.Text = DateTime.Now.ToString();
        }
    }
}
