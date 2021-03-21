using application_checker.appCls;
using application_checker.appDt;
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
using System.Windows.Threading;

namespace application_checker
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool check = false;
        private DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();
            TxbNameUser.Text = Environment.UserName + " / Сборка ОС: " + Environment.Version + " / Версия ОС: " + Environment.OSVersion;
            TxbHeaderWindow.Text = "Checker ENV" + " .::. " + Environment.SystemDirectory;
            DataTimer();
            NavigationPages.frameMainPage = FrmMainPages;
        }

        private void StcPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void BtnCloseApplication_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void BtnMaxSize_Click(object sender, RoutedEventArgs e)
        {
            EventData();
        }

        private void BtnMin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void EventData() {
            if (check == false)
            {
                this.WindowState = WindowState.Maximized;
                check = true;
            }
            else
            {
                this.WindowState = WindowState.Normal;
                check = false;
            }
        }

        private void DataTimer() {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(10);
            timer.Tick += UpdateDataGrid;
            timer.Start();
        }

        private void UpdateDataGrid(object sender, EventArgs e)
        {
            FrmMainPages.Navigate(new PageMainScreen());                
        }
    }
}
