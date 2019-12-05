using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FuelStation
{
    /// <summary>
    /// Interaction logic for PayWindow.xaml
    /// </summary>
    public partial class PayWindow : Window
    {
        private int total;
        public PayWindow(List<Item> products)
        {
            InitializeComponent();
            int totalSum = 0;
            foreach(var item in products)
            {
                totalSum += item.Total;
                item.Total = totalSum;
                tableItem.Items.Add(item);
            }
        }

        private void SuccesfulEnd(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Вы успешно оплатили!");
        }
    }
}
