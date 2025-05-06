using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Class2
    {
        class GradiantPanel : Panel
        {
            public Color ColorTop { get; set; }
            public Color ColorBottom { get; set; }
            protected override void OnPaint(PaintEventArgs e)
            {
                LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, ColorTop, ColorBottom, 90F);
                Graphics g = e.Graphics;
                g.FillRectangle(brush, this.ClientRectangle);

                base.OnPaint(e);
            }
        }
    }
}

