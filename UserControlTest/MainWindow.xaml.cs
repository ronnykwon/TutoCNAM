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

namespace UserControlTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void YellowButton_Click(object sender, RoutedEventArgs e)
        {
            Yellow yellow = new Yellow();
            this.UserControlHolder.Children.Clear();
            this.UserControlHolder.Children.Add(yellow);
        }

        private void Red_Click(object sender, RoutedEventArgs e)
        {
            Red red = new Red();
            this.UserControlHolder.Children.Clear();
            this.UserControlHolder.Children.Add(red);
        }
    }
}
