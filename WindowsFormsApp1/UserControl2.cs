using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }
    }
}
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