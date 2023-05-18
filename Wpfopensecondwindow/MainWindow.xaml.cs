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

namespace Wpfopensecondwindow
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

        private void OpenWindow(object sender, RoutedEventArgs e)


        {
            Window1 objWindow1 = new Window1();
            this.Visibility = Visibility.Hidden;
            objWindow1.Show();
        }

        private void OpenWindow2(object sender, RoutedEventArgs e)
        {
            Window2 objWindow2 = new Window2();
            this.Visibility = Visibility.Hidden;
            objWindow2.Show();

        }
    }
}
