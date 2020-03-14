using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Vavatech.PSI.WPF.Common.MarkupExtensions
{
    public class EnumSource: MarkupExtension
    {
        private Type enumType;

        public EnumSource(Type enumType)
        {
            this.enumType = enumType;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return Enum.GetValues(enumType).Cast<object>()
                .Select(item => GetDescription(item));
        }

        private string GetDescription(object enumValue)
        {
            var da= enumType.GetField(enumValue.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault() as DescriptionAttribute;

            if (da != null)
                return da.Description;
            else
               return enumValue.ToString();
        }
    }
}
