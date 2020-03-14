using System;
using System.Globalization;
using System.Windows;

namespace Vavatech.PSI.WPF.Common.Converters
{
    public class BoolToVisibilityConverter : BaseValueConverter<BoolToVisibilityConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? Visibility.Visible : Visibility.Hidden;
        }
    }
}
