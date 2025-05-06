using Formregular;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form11 : Form
    {
        public Form11(string student_num)
        {
            InitializeComponent();
            lbStudentID.Text = student_num;
            
        }
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;uid=root;pwd=qaz123456789;database=students");
        MySqlCommand cmd = new MySqlCommand();
        private void datagrid()
        {
            
            try
            {
                string sql = "select * from student_schedule where Program = @program ;";
                cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@program", cbProgram.Text);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                DataGridViewCheckBoxColumn checkBox = new DataGridViewCheckBoxColumn();
                checkBox.HeaderText = "Select";
                checkBox.Name = "Check";
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add(checkBox);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex) {  }
        }
        private void gradiantPanel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void cbProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            datagrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            con.Open();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Check"].Value);
                if (isSelected)
                {
                    string subject_code = row.Cells[1].Value.ToString();
                    string subject_name = row.Cells["Course Description"].Value.ToString();
                    string day = row.Cells["Day"].Value.ToString();
                    string time = row.Cells["Day"].Value.ToString();
                    string instructor = row.Cells["Instructor"].Value.ToString();
                    string program = row.Cells["Program"].Value.ToString();
                    string clas = row.Cells["Class"].Value.ToString();


                    string sql = "insert into student_subjects ( student_num,subject_code, subject_name, Day,Time, instructor, semester,program) " +
                                 "VALUES (@student_num, @code, @name, @day,@time, @instructor, @class,@program)  ";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@student_num", lbStudentID.Text);
                    cmd.Parameters.AddWithValue("@code", subject_code);
                    cmd.Parameters.AddWithValue("@name", subject_name);
                    cmd.Parameters.AddWithValue("@day", day);
                    cmd.Parameters.AddWithValue("@time", time);
                    cmd.Parameters.AddWithValue("@instructor", instructor);
                    cmd.Parameters.AddWithValue("@program", program); 
                    cmd.Parameters.AddWithValue("@class", clas);   

                    cmd.ExecuteNonQuery();
                }
            }
            Form8 f = new Form8();
            f.Show();
            con.Close();
            btnEnroll.Hide();
        }

        private void gradiantPanel1_Paint(object sender, PaintEventArgs e)
        {
            string sql = "select first_name, middle_name, last_name from enrolled_students where student_num = @student_num;";
            cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@student_num", lbStudentID.Text);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            adapter.Fill(dt);
            lbFirstname.Text = dt.Rows[0][0].ToString();
            lbMiddleName.Text = dt.Rows[0][1].ToString();
            lbSurname.Text = dt.Rows[0][2].ToString();
            adapter.Dispose();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            formlogin f = new formlogin();
            f.Show();
        }
    }
}
