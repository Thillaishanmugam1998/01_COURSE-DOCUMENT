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

namespace WPF_Dynamic_Resources
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Change the color of the DynamicBrush resource at runtime
            SolidColorBrush dynamicBrush = (SolidColorBrush)Application.Current.Resources["DynamicBrush"];
            if (dynamicBrush != null)
            {
                dynamicBrush.Color = Colors.DeepSkyBlue; // This will update the UI dynamically
            }
        }
    }
}
