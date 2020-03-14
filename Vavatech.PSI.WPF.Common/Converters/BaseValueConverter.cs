using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Vavatech.PSI.WPF.Common.Converters
{
    public abstract class BaseValueConverter<T> :MarkupExtension, IValueConverter where T : class, new() 
    {
        //singleton zapewnia, że nie nowa instancja nie będzie tworzona za każdym wywołaniem
        private static T converter = null;

        public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);

        public virtual object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return converter ?? (converter = new T());
        }


    }
}