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

namespace WPFControls
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

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the input from the TextBox and display it in the ResultLabel
            string userName = NameTextBox.Text;
            if (!string.IsNullOrEmpty(userName))
            {
                ResultLabel.Content = $"Hello, {userName}!";
            }
            else
            {
                ResultLabel.Content = "Please enter your name.";
            }
        }
    }
}
