using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registrar
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Loadform(object form)
        {
            if(this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(fh);
            this.mainpanel.Tag = fh;
            fh.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loadform(new enrollment_request());
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Loadform(new studentforms());
        }

        private void label1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Loadform(new formpersonal_info());
        }
    }
}
