using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAndInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            //气球是引用变量，而孩子是实例
            //气球不一定有孩子牵着
            new Form();
            //气球有孩子牵着
            //声明引用变量
            Form myForm;
            myForm = new Form();
            myForm.Text = "My Form";
            myForm.ShowDialog();
            //有小孩但是没有牵气球
            //Form myForm;
            //两个小朋友牵着同一个气球
            Form myForm1;
            Form myForm2;
            myForm1 = new Form();
            myForm2 = myForm1;
            myForm1.Text = "My Form1";
            myForm2.ShowDialog();
            myForm2.Text = "I changed it!";
            myForm1.ShowDialog();
        }
    }
}
