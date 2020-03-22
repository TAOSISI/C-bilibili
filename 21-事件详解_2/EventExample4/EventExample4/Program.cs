using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventExample4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyForm form = new MyForm();
            form.ShowDialog();
        }
    }
    class MyForm : Form
    {
        private TextBox textBox;
        private Button button;
        public MyForm()
        {
            this.textBox = new TextBox();
            this.button = new Button();
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBox);
            this.button.Click += this.BottumClicked;
            this.button.Text = "Say Hello";
            this.button.Top = 100;
        }

        private void BottumClicked(object sender, EventArgs e)
        {
            this.textBox.Text = "Hello, World!!!!!!!!!!!!!!!!!!!!!!!!";
        }
    }
}
