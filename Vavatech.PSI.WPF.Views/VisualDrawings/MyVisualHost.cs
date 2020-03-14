using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Vavatech.PSI.WPF.Views.VisualDrawings
{
    public class MyVisualHost:FrameworkElement
    {
        private VisualCollection children;

        public MyVisualHost()
        {
            children = new VisualCollection(this);

            children.Add(CreateLines());
        }

        private DrawingVisual CreateLines()
        {
            DrawingVisual drawingVisual = new DrawingVisual();
            using (var dc = drawingVisual.RenderOpen())
            {
                dc.DrawLine(new Pen(Brushes.Black,1),new Point(0,0), new Point(400,400)  );
                dc.DrawLine(new Pen(Brushes.Black,1),new Point(0,400), new Point(400,0)  );
            }

            return drawingVisual;
        }

        protected override Visual GetVisualChild(int index)
        {
            return children[index];
        }

        protected override int VisualChildrenCount
        {
            get { return children.Count; }
        }
    }
}
