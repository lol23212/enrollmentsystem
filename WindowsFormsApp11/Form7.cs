using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;uid=root;pwd=qaz123456789;database=students");
        MySqlCommand cmd = new MySqlCommand();

        public object MySqlDataAdaptor { get; private set; }

        public Form7()
        {
            InitializeComponent();
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void gradiantPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gradiantPanel2_Paint(object sender, PaintEventArgs e)
        {
            string sql = "select * from list";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
             adapter.Fill(dt);

            dataGridView2.DataSource = dt;

        }

        private void gradiantPanel1_Paint_1(object sender, PaintEventArgs e)
        {
            string sql = "select first_name, middle_name, last_name, student_num from enrolled_students";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con);
            
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource= dt;    
            string firstname = dataGridView1.Rows[0].Cells[0].Value.ToString();
            string middlename = dataGridView1.Rows[0].Cells[1].Value.ToString();
            string lastname = dataGridView1.Rows[0].Cells[2].Value.ToString();
            string studentnum = dataGridView1.Rows[0].Cells[3].Value.ToString();

            lbFirstName.Text = firstname;
            lbMiddleName.Text = middlename;
            lbSurname.Text = lastname;
            lbStudentID.Text = studentnum;

            


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
