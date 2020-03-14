using System;
using System.Globalization;
using System.Windows;
using System.Windows.Media;
using Vavatech.PSI.WPF.Models;

namespace Vavatech.PSI.WPF.Common.Converters
{
    //nie powinno się pisać takich konwerterów. Lepiej użyć triggerów.
    public class ActivityTypeToColorConverter : BaseValueConverter<ActivityTypeToColorConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ActivityType eValue = (ActivityType) value;

            if (eValue == ActivityType.Working)
            {
                return Brushes.Coral;
            }

            if(eValue==ActivityType.Delegated)
            {
                return Brushes.Yellow;
            }

            if(eValue == ActivityType.Rest)
            {
                return Brushes.LightGreen;
            }

            throw new ArgumentOutOfRangeException();
        }
    }
}
