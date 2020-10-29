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
    /// Interaction logic for Gallery.xaml
    /// </summary>
    public partial class Gallery : UserControl
    {
        private List<int> nombres;
        public Gallery()
        {
            InitializeComponent();
            nombres = new List<int>();
            for (int i = 0; i < 5000; i++)
            {
                nombres.Add(i);
            }

            this.gallery.ItemsSource = nombres;
        }

        private void ListBoxItem_Loaded(object sender, RoutedEventArgs e)
        {
            ListBoxItem lbi = sender as ListBoxItem;
            object dataItem = lbi.DataContext;
            Console.WriteLine("item loaded : " + dataItem);

            
        }

        private void ListBoxItem_Unloaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
