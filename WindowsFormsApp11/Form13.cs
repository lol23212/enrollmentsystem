using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp1
{
    public partial class formgradesput: Form
    {
        public formgradesput(string clas,string prog,string studentnum)
        {
            InitializeComponent();
            lbcllass.Text = clas;
            lbprog.Text = prog;
            lbid.Text = studentnum;

        }
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;uid=root;pwd=qaz123456789;database=students");
        MySqlCommand cmd = new MySqlCommand();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void formgradesput_Load(object sender, EventArgs e)
        {
            string grades = "select CS2321,CC1083,`PE 3`,GEM,CS2565,`GE 1`,`GE 4` from student_grades where student_num = @student_num";
            cmd = new MySqlCommand(grades, con);
            cmd.Parameters.AddWithValue("@student_num", lbid.Text);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string data = "update student_grades set CS2321 = @cs2321,CC1083 = @cc1083,`PE 3` = @pe3,GEM = @gem,CS2565 = @cs2565,`GE 1` = @ge1,`GE 4` = @ge4 where student_num = @student_num";
            string CS2321 =dataGridView1.Rows[0].Cells["CS2321"].Value.ToString();
            string CC1083 = dataGridView1.Rows[0].Cells["CC1083"].Value.ToString();
            string PE3 = dataGridView1.Rows[0].Cells["PE 3"].Value.ToString();
            string GEM = dataGridView1.Rows[0].Cells["GEM"].Value.ToString();
            string CS2565 = dataGridView1.Rows[0].Cells["CS2565"].Value.ToString();
            string GE1 = dataGridView1.Rows[0].Cells["GE 1"].Value.ToString();
            string GE4 = dataGridView1.Rows[0].Cells["GE 4"].Value.ToString();
            cmd = new MySqlCommand(data, con);
            cmd.Parameters.AddWithValue("@cs2321", CS2321);
            cmd.Parameters.AddWithValue("@cc1083", CC1083);
            cmd.Parameters.AddWithValue("@pe3", PE3);
            cmd.Parameters.AddWithValue("@gem", GEM);
            cmd.Parameters.AddWithValue("@cs2565", CS2565);
            cmd.Parameters.AddWithValue("@ge1", GE1);
            cmd.Parameters.AddWithValue("@ge4", GE4);
            cmd.Parameters.AddWithValue("@student_num", lbid.Text);
            
            cmd.ExecuteNonQuery();
            MessageBox.Show("Grades Updated");




        }
    }
}
