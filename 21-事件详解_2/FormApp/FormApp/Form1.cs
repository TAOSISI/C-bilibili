using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
            this.MyBottom.Click += BottomClick;
        }

        private void BottomClick(object sender, EventArgs e)
        {
            this.textBox1.Text = "Hello, World!";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
