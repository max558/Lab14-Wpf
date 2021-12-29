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

namespace Lab14___WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                NameProduct ="Хлеб",
                PriceProduct = 50,
                ImagePathProduct = "Data/Хлеб.jpg",
                CategoryProduct = CategoryProducts.Food
            });
            products.Add(new Product()
            {
                NameProduct ="Мясо",
                PriceProduct = 4000,
                ImagePathProduct = "Data/Мясо.jpg",
                CategoryProduct = CategoryProducts.Food
            });
            products.Add(new Product()
            {
                NameProduct ="Телевизор",
                PriceProduct = 50000,
                ImagePathProduct = "Data/Телевизор.jpg",
                CategoryProduct = CategoryProducts.Appliances
            });
            products.Add(new Product()
            {
                NameProduct ="Холодильник",
                PriceProduct = 90000,
                ImagePathProduct = "Data/Холодильник.jpg",
                CategoryProduct = CategoryProducts.Appliances
            });
            lstBox.ItemsSource = products;
        }
    }
}
