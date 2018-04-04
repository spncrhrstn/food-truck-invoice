﻿using System;
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

namespace FoodTruck
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

        private void EditInventoryOnClick(object sender, RoutedEventArgs e) {
            var window = new ItemEntry();
            window.ShowDialog();
        }

        private void SearchInvoicesOnClick(object sender, RoutedEventArgs e) {
            var window = new InvoiceSearch();
            window.ShowDialog();
        }
    }
}
