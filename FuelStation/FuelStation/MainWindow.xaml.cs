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

namespace FuelStation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Item> Products = new List<Item>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Fuel80Click(object sender, RoutedEventArgs e)
        {
            var number = CheckBox();
            if (number > 0)
            {
                Item product = new Item();
                product.Name = "AI-80";
                product.Price = 89;
                product.Count = number;
                product.Total = number * product.Price;
                Products.Add(product);
            }
        }

        private void ClickDelete(object sender, RoutedEventArgs e)
        {
            count.Clear();
        }

        private int CheckBox()
        {
            if (String.IsNullOrWhiteSpace(count.Text) || !int.TryParse(count.Text, out var number))
            {
                MessageBox.Show("Введите кол-во товара!");
            }
            else
            {
                if (number <= 0)
                {
                    MessageBox.Show("Введите коректное кол-во товара!");
                    return -1;
                }
                else
                {
                    return number;
                }
            }
            return 0;
        }

        private void ToPayProducts(object sender, RoutedEventArgs e)
        {
            PayWindow payWindow = new PayWindow(Products);
            payWindow.ShowDialog();
            Products = new List<Item>();
        }

        private void Fuel92Click(object sender, RoutedEventArgs e)
        {
            var number = CheckBox();
            if(number > 0)
            {
                Item product = new Item();
                product.Name = "AI-92";
                product.Price = 152;
                product.Count = number;
                product.Total = number * product.Price;
                Products.Add(product);
            }
        }

        private void Fuel95Click(object sender, RoutedEventArgs e)
        {
            var number = CheckBox();
            if(number > 0)
            {
                Item product = new Item();
                product.Name = "AI-95";
                product.Price = 174;
                product.Count = number;
                product.Total = number * product.Price;
                Products.Add(product);
            }
        }

        private void Fuel98Click(object sender, RoutedEventArgs e)
        {
            var number = CheckBox();
            if (number > 0)
            {
                Item product = new Item();
                product.Name = "AI-98";
                product.Price = 212;
                product.Count = number;
                product.Total = number * product.Price;
                Products.Add(product);
            }
        }

        private void OrbitClick(object sender, RoutedEventArgs e)
        {
            var number = CheckBox();
            if (number > 0)
            {
                Item product = new Item();
                product.Name = "Orbit";
                product.Price = 160;
                product.Count = number;
                product.Total = number * product.Price;
                Products.Add(product);
            }
        }

        private void DirolClick(object sender, RoutedEventArgs e)
        {
            var number = CheckBox();
            if (number > 0)
            {
                Item product = new Item();
                product.Name = "Dirol";
                product.Price = 155;
                product.Count = number;
                product.Total = number * product.Price;
                Products.Add(product);
            }
        }

        private void FlintClick(object sender, RoutedEventArgs e)
        {
            var number = CheckBox();
            if (number > 0)
            {
                Item product = new Item();
                product.Name = "Flint";
                product.Price = 130;
                product.Count = number;
                product.Total = number * product.Price;
                Products.Add(product);
            }
        }

        private void LaysClick(object sender, RoutedEventArgs e)
        {
            var number = CheckBox();
            if (number > 0)
            {
                Item product = new Item();
                product.Name = "Lays";
                product.Price = 300;
                product.Count = number;
                product.Total = number * product.Price;
                Products.Add(product);
            }
        }

        private void J7Click(object sender, RoutedEventArgs e)
        {
            var number = CheckBox();
            if (number > 0)
            {
                Item product = new Item();
                product.Name = "J7";
                product.Price = 350;
                product.Count = number;
                product.Total = number * product.Price;
                Products.Add(product);
            }
        }

        private void Gorilla(object sender, RoutedEventArgs e)
        {
            var number = CheckBox();
            if (number > 0)
            {
                Item product = new Item();
                product.Name = "Gorilla";
                product.Price = 350;
                product.Count = number;
                product.Total = number * product.Price;
                Products.Add(product);
            }
        }

        private void CocaColaClick(object sender, RoutedEventArgs e)
        {
            var number = CheckBox();
            if (number > 0)
            {
                Item product = new Item();
                product.Name = "Coca-Cola";
                product.Price = 250;
                product.Count = number;
                product.Total = number * product.Price;
                Products.Add(product);
            }
        }

        private void FantaClick(object sender, RoutedEventArgs e)
        {
            var number = CheckBox();
            if (number > 0)
            {
                Item product = new Item();
                product.Name = "Fanta";
                product.Price = 250;
                product.Count = number;
                product.Total = number * product.Price;
                Products.Add(product);
            }
        }
    }
}
