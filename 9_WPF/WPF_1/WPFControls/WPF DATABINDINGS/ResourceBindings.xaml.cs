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
    /// Interaction logic for ResourceBindings.xaml
    /// </summary>
    public partial class ResourceBindings : Window
    {
        public ResourceBindings()
        {
            InitializeComponent();
        }

        // Button click handler for without binding
        private void ButtonWithoutBinding_Click(object sender, RoutedEventArgs e)
        {
            string input = textBoxWithoutBinding.Text;
            MessageBox.Show($"Without Binding: {input}");
        }

        // Button click handler for resource binding
        private void ButtonWithResourceBinding_Click(object sender, RoutedEventArgs e)
        {
            // Get the text from the shared resource
            string inputFromResource = (string)this.Resources["SharedText"];
            MessageBox.Show($"With Resource Binding: {inputFromResource}");
        }
    }
}
