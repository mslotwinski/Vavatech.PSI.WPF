using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Vavatech.PSI.WPF.Common.MarkupExtensions
{
    public class SplitBinding:MarkupExtension
    {
        public string Source { get; set; }
        public char Separator { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return Source.Split(Separator);
        }
    }
}
