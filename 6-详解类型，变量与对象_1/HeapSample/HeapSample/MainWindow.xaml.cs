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

namespace HeapSample
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
        List<Window> winList;//声明变量，以消耗内存，声明在函数之外，需要在两个函数中都看到它
        //实例永远在堆里
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            winList = new List<Window>();//声明list实例，list中可以装Window，此时为空
            for (int i = 0; i < 15000; i++)
            {
                Window w = new Window();//将变量赋予实例
                winList.Add(w);
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            winList.Clear();//此时实例（气球）为垃圾，C#中的垃圾收集站会找一个合适的时机收回气球
        }
    }
}
