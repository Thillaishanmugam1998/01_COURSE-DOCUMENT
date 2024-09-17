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

namespace WPF_LAYOUTS
{
    /// <summary>
    /// Interaction logic for GridViewWindow.xaml
    /// </summary>
    public partial class GridViewWindow : Window
    {
        public GridViewWindow()
        {
            InitializeComponent();
            listView.ItemsSource = new List<Person>
            {
                new Person { Name = "John", Age = 30, Country = "USA" },
                new Person { Name = "Anna", Age = 25, Country = "Germany" },
                new Person { Name = "Mike", Age = 35, Country = "Canada" }
            };
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
    }
}