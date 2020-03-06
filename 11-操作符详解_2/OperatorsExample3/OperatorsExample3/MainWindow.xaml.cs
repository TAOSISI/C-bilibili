using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OperatorsExample3
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //this.myButton.Click += delegate (object sender, RoutedEventArgs e)//使用delegate操作符声明了一个匿名方法
            //{
            //    this.myTextBox.Text = "Hello,World!";
            //};
            this.myButton.Click += (sender, e) =>//lambda方法
            {
                this.myTextBox.Text = "Hello,World!";
            };
        }


    }
}
