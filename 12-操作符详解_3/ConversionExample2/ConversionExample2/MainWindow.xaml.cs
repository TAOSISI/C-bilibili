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

namespace ConversionExample2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(this.tb1.Text);//解析
            //double x=double.TryParse(this.tb1.Text,输出参数)
            double y = System.Convert.ToDouble(tb2.Text);
            double result = x + y;
            //this.tb3.Text = System.Convert.ToString(result);
            this.tb3.Text = result.ToString();
        }
    }
}
