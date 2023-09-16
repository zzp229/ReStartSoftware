using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace 重启软件
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

        //打开
        private void Open(object sender, RoutedEventArgs e)
        {
            var process = Process.Start("Word.exe");
            MessageBox.Show(process.Id.ToString());
            process.Start();
        }

        //关闭
        private void Close(object sender, RoutedEventArgs e)
        {
            string targetProcessName = "C:\\安装\\安装包\\玩机\\MyDock\\Dock_64.exe"; // 替换为目标应用程序的名称

            // 获取所有正在运行的与指定进程名称匹配的进程
            Process[] processes = Process.GetProcessesByName(targetProcessName);

            if (processes.Length > 0)
            {
                foreach (Process process in processes)
                {
                    // 终止进程，关闭应用程序
                    process.Kill();
                }

                Console.WriteLine("应用程序已关闭。");
            }
            else
            {
                Console.WriteLine("未找到指定名称的应用程序。");
            }
        }


        private void Auto(object sender, RoutedEventArgs e)
        {
            var process = Process.Start("C:\\安装\\安装包\\玩机\\MyDock\\Dock_64.exe");
            MessageBox.Show(process.Id.ToString());
            process.Close();
            process.Start();
        }
    }
}
