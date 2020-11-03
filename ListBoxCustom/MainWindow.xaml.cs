using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ListBoxCustom
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ObservableCollection<Item> items = new ObservableCollection<Item>();
            items.Add(new Item("Fafaru", 500, "https://4.bp.blogspot.com/-KS-6bHemVNM/VSSoYtvQ8eI/AAAAAAAAJSI/UIrJ1aCAO1s/s1600/02%2B-%2BApp%C3%A9tissant%2Ble%2Bf%C4%81faru%2B%2B%2C%2Bnon.jpg"));
            items.Add(new Item("Fafaru", 500, "https://4.bp.blogspot.com/-KS-6bHemVNM/VSSoYtvQ8eI/AAAAAAAAJSI/UIrJ1aCAO1s/s1600/02%2B-%2BApp%C3%A9tissant%2Ble%2Bf%C4%81faru%2B%2B%2C%2Bnon.jpg"));
            items.Add(new Item("Fafaru", 500, "https://4.bp.blogspot.com/-KS-6bHemVNM/VSSoYtvQ8eI/AAAAAAAAJSI/UIrJ1aCAO1s/s1600/02%2B-%2BApp%C3%A9tissant%2Ble%2Bf%C4%81faru%2B%2B%2C%2Bnon.jpg"));
            items.Add(new Item("Fafaru", 500, "https://4.bp.blogspot.com/-KS-6bHemVNM/VSSoYtvQ8eI/AAAAAAAAJSI/UIrJ1aCAO1s/s1600/02%2B-%2BApp%C3%A9tissant%2Ble%2Bf%C4%81faru%2B%2B%2C%2Bnon.jpg"));
            items.Add(new Item("Fafaru", 500, "https://4.bp.blogspot.com/-KS-6bHemVNM/VSSoYtvQ8eI/AAAAAAAAJSI/UIrJ1aCAO1s/s1600/02%2B-%2BApp%C3%A9tissant%2Ble%2Bf%C4%81faru%2B%2B%2C%2Bnon.jpg"));
            items.Add(new Item("Fafaru", 500, "https://4.bp.blogspot.com/-KS-6bHemVNM/VSSoYtvQ8eI/AAAAAAAAJSI/UIrJ1aCAO1s/s1600/02%2B-%2BApp%C3%A9tissant%2Ble%2Bf%C4%81faru%2B%2B%2C%2Bnon.jpg"));
            items.Add(new Item("Fafaru", 500, "https://4.bp.blogspot.com/-KS-6bHemVNM/VSSoYtvQ8eI/AAAAAAAAJSI/UIrJ1aCAO1s/s1600/02%2B-%2BApp%C3%A9tissant%2Ble%2Bf%C4%81faru%2B%2B%2C%2Bnon.jpg"));
            this.itemListView.ItemsSource = items;
        }
    }
}
