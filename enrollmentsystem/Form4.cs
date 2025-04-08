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
    public partial class Formcreate: Form
    {
        public Formcreate()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtconfirm.PasswordChar = '\0';


            }
            else
            {
                txtconfirm.PasswordChar = '*';
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpassword.PasswordChar = '\0';


            }
            else
            {
                txtpassword.PasswordChar = '*';
            }
        }

        private void cREATEEMAILToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formcreate prof = new Formcreate();
            prof.Show();
        }

        private void eNROLLMENTDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            formeducation prof = new formeducation();
            prof.Show();
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
    }
}
