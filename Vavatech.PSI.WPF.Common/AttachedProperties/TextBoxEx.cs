using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Vavatech.PSI.WPF.Common.AttachedProperties
{
    [ContentProperty("Content")]
    public class TextBoxEx : TextBox
    {
        public object Content
        {
            get { return (object)GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Content.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ContentProperty =
            DependencyProperty.Register("Content", typeof(object), typeof(TextBoxEx), new PropertyMetadata(null,OnPropertyChange));

        private static void OnPropertyChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
           TextBoxEx textBox = d as TextBoxEx;
            textBox.Text = e.NewValue.ToString();
        }
    }
}
