using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;

namespace WPF_Value_Conversion
{
    class ScoreToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double score)
            {
                if (score >= 0 && score <= 40)
                {
                    return Brushes.Red;
                }
                else if (score > 40 && score <= 70)
                {
                    return Brushes.Yellow;
                }
                else if (score > 70 && score <= 100)
                {
                    return Brushes.Green;
                }
            }
            return Brushes.Gray; // Default color
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
