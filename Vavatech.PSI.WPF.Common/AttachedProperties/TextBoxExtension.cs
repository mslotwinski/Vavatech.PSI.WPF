using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Vavatech.PSI.WPF.Common.AttachedProperties
{
    public class TextBoxExtension : DependencyObject
    {
        public static object GetContent(TextBox obj) //zmieniliśmy typ parametru z DependancyObject aby uniemożliwić wykorzystanie na niewłaściwych typach
        {
            return (object)obj.GetValue(ContentProperty);
        }

        public static void SetContent(TextBox obj, object value)
        {
            obj.SetValue(ContentProperty, value);
        }

        // Using a DependencyProperty as the backing store for Content.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ContentProperty =
            DependencyProperty.RegisterAttached("Content", typeof(object), typeof(TextBoxExtension), new PropertyMetadata(null,OnPropertyChange));

        private static void OnPropertyChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            TextBox textBox = d as TextBox;

            textBox.MouseEnter -= TextBox_MouseEnter;

            textBox.Text = e.NewValue.ToString();

            textBox.MouseEnter += TextBox_MouseEnter;

            //odpinamy aby nie powielać handlerów.

        }

        private static void TextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.Width = 200;
        }
    }
}