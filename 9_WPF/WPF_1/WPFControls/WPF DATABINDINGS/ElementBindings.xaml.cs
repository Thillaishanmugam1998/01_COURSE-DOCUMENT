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
    /// Interaction logic for ElementBindings.xaml
    /// </summary>
    public partial class ElementBindings : Window
    {
        public ElementBindings()
        {
            InitializeComponent();
        }

        // Button click handler for without binding
        private void ButtonWithoutBinding_Click(object sender, RoutedEventArgs e)
        {
            string input = textBoxWithoutBinding.Text;
            MessageBox.Show($"Without Binding: {input}");
        }

        // Button click handler for element binding
        private void ButtonWithElementBinding_Click(object sender, RoutedEventArgs e)
        {
            string inputFromSource = textBoxSource.Text;
            MessageBox.Show($"With Element Binding (Source TextBox): {inputFromSource}");
        }
    }
}
