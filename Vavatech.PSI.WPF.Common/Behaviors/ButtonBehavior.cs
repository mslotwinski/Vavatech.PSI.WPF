using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interactivity;

namespace Vavatech.PSI.WPF.Common.Behaviors
{
    public class ButtonBehavior : Behavior<Button>
    {
        public double Width
        {
            get { return (double)GetValue(WidthProperty); }
            set { SetValue(WidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Width.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty WidthProperty =
            DependencyProperty.Register("Width", typeof(double), typeof(ButtonBehavior), new PropertyMetadata(0.0, new PropertyChangedCallback(OnWidthPropertyChanged)));

        private static void OnWidthPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ButtonBehavior bh = d as ButtonBehavior;
            if (bh.AssociatedObject != null)
            {
                bh.AssociatedObject.Width = (double) e.NewValue;
            }
            //button.Width = e.NewValue;
        }

        public object Content { get; set; }

        protected override void OnAttached()
        {
            AssociatedObject.MouseEnter += AssociatedObject_MouseEnter;

            base.OnAttached();
        }

        private void AssociatedObject_MouseEnter(object sender, MouseEventArgs e)
        {
            AssociatedObject.Width = Width;
            AssociatedObject.Content = Content;
        }
    }
}
