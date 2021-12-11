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

namespace Mikhaylova_Layout
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Frames.Navigate(new AgentsPage_1());
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            Frames.Navigate(new AgentsPage_2());
            BtnNext.Background = Brushes.White;
            BtnLast.Background = Brushes.LightSkyBlue;
        }

        private void BtnLast_Click(object sender, RoutedEventArgs e)
        {
            Frames.Navigate(new AgentsPage_1());
            BtnLast.Background = Brushes.White;
            BtnNext.Background = Brushes.LightSkyBlue;
        }
    }
}
