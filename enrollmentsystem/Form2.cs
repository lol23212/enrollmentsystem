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
    public partial class formprofile : Form
    {
        public formprofile()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            formeducation prof = new formeducation();
            prof.Show();
        }

        private void eNROLLMENTDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            formeducation prof = new formeducation();
            prof.Show();
        }

        private void rETURNTOLOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            formLogin prof = new formLogin();
            prof.Show();
        }

        private void myToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cREATEEMAILToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formcreate prof = new Formcreate();
            prof.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
