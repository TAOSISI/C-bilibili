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
using System.Windows.Threading;//多线程

namespace EventSample
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        //基于事件
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();//实例化timer
            timer.Interval = TimeSpan.FromSeconds(1);//一秒触发一次，timespan为时间间隔
            timer.Tick += Timer_Tick;//将Timer_Tick函数挂接到该事件上
            timer.Start();
        }
        //该方法称为事件处理器
        private void Timer_Tick(object sender, EventArgs e)
        {
            this.timeTextBox.Text = DateTime.Now.ToString();
        }
    }
}
