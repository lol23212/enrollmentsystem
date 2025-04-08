using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enrollmentsystem
{
    public partial class formeducation : Form
    {
        public formeducation()
        {
            InitializeComponent();
        }

        private void myToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            formprofile prof = new formprofile();
            prof.Show();
        }

        private void rETURNTOLOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            formLogin prof = new formLogin();
            prof.Show();
        }

        private void bprev_Click(object sender, EventArgs e)
        {
            this.Hide();
            formprofile prof = new formprofile();
            prof.Show();
        }

        private void cREATEEMAILToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formcreate prof = new Formcreate();
            prof.Show();
        }

        private void bnext_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formcreate prof = new Formcreate();
            prof.Show();
        }
    }
}
