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

namespace WPF_DATABINDINGS
{
    /// <summary>
    /// Interaction logic for DataBind.xaml
    /// </summary>
    public partial class DataBind : Window
    {

        public string BoundText { get; set; }
        public DataBind()
        {
            InitializeComponent();
            DataContext = this;
            BoundText = "Initial Bound Text"; // Initialize the bound text
        }

        // Button click handler for without data binding
        private void ButtonWithoutBinding_Click(object sender, RoutedEventArgs e)
        {
            string input = textBoxWithoutBinding.Text;
            MessageBox.Show($"Without Binding: {input}");
        }

        // Button click handler for with data binding
        private void ButtonWithBinding_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"With Binding: {BoundText}");
        }

    }
}
