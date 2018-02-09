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
using Chapter2.Collections.CollectionsLib;

namespace Chapter2.Collections.WPFLittleShop
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

        private void FruitsButton_Click(object sender, RoutedEventArgs e)
        {
            var littleShop = new LittleShop();

            var fruits = littleShop.GetFruitsList();

            foreach (var fruit in fruits)
            {
                FruitsList.Items.Add(fruit);
            }

            FruitsList.Items.Add("--------");
            FruitsList.Items.Add($"Item Count: {fruits.Count}");
            FruitsList.Items.Add($"Capacity: {fruits.Capacity}");

        }

        private void ItemsButton_Click(object sender, RoutedEventArgs e)
        {
            var littleShop = new LittleShop();

            var items = littleShop.GetShopItems();

            for (int i=0; i<items.Count; i++)
            {
                ItemsList.Items.Add(items[i]);
            }

            ItemsList.Items.Add("--------");
            ItemsList.Items.Add($"Item Count: {items.Count}");
            ItemsList.Items.Add($"Capacity: {items.Capacity}");
        }
    }
}
