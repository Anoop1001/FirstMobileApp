using System;
using System.Globalization;
using Xamarin.Forms;

namespace FirstApp.Converters
{
    class BooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !string.IsNullOrEmpty($"{value}");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !string.IsNullOrEmpty($"{value}");
        }
    }
}
