using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Vavatech.PSI.WPF.Common.MarkupExtensions
{
    public class CurrentDirectory: MarkupExtension
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return Environment.CurrentDirectory;
        }
    }
}
