using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Windows.Threading;

namespace Vavatech.PSI.WPF.Common.MarkupExtensions
{
    public class ObservableSource : MarkupExtension
    {
        private ObservableCollection<string> items = new ObservableCollection<string>();

        private DispatcherTimer timer = new DispatcherTimer();

        private int index;

        public TimeSpan Interval { get; set; }

        public ObservableSource()
        {
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += TimerOnTick;
            timer.Start();
        }

        private void TimerOnTick(object sender, EventArgs e)
        {
            items.Add($"Hello {index++}");
            if (index==10) timer.Stop();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return items;
        }
    }
}
