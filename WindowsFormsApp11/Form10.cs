using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Connection;
using MySqlX.XDevAPI.Relational;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WindowsFormsApp1
{
    public partial class Form10 : Form
    {
        public Form10(string  user)
        {
            InitializeComponent();
            lbStudentID.Text = user;
            datagrid();
        }
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;uid=root;pwd=qaz123456789;database=students");
        MySqlCommand cmd = new MySqlCommand();
        private void datagrid()
        {
            
                


                try
                {
                    
                    string check = "select count(*) from student_grades where class = @class;";
                    MySqlCommand cmd = new MySqlCommand(check, con);
                    cmd.Parameters.AddWithValue("@class", cbClass.Text);
                    con.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count == 50)
                    {
                        MessageBox.Show(cbClass.Text + " is full");
                    }
                    else if(cbClass.Text == "Class") { }
                    else
                    {
                        string sql2 = "select * from student_schedule where Class = @class and Program = @program;";
                        cmd = new MySqlCommand(sql2, con);
                        cmd.Parameters.AddWithValue("@class", cbClass.Text);
                        cmd.Parameters.AddWithValue("@program", cbProgram.Text);
                        MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd);
                        DataTable dt2 = new DataTable();
                        adapter2.Fill(dt2);
                        dataGridView1.DataSource = dt2;
                    }
                    con.Close();
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gradiantPanel2_Paint(object sender, PaintEventArgs e)
        {
        }
                
            
            
        

        private void cbProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select Class,advisor,program from section where program = @program;";
            MySqlCommand cmd1 = new MySqlCommand(sql, con);
            cmd1.Parameters.AddWithValue("@program", cbProgram.Text);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void gradiantPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            
            string sql = "select first_name, middle_name, last_name from enrolled_students where student_num = @student_num;";
            cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@student_num", lbStudentID.Text);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            adapter.Fill(dt);
            lbFirstName.Text = dt.Rows[0][0].ToString();
            lbMiddleName.Text = dt.Rows[0][1].ToString();
            lbSurname.Text = dt.Rows[0][2].ToString();
            adapter.Dispose();


        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }
        private void btnEnroll_Click(object sender, EventArgs e)
        {
            string check = "select exist";
            string updatecc = "update enrolled_students set course = @course ,class = @class where student_num = @student_num";
            
            cmd = new MySqlCommand(updatecc, con);
            cmd.Parameters.AddWithValue("@course", cbProgram.Text);
            cmd.Parameters.AddWithValue("@class", cbClass.Text);
            cmd.Parameters.AddWithValue("@student_num", lbStudentID.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            
                string coursein = "insert into student_grades (student_num, first_name, middle_name, last_name,class,program) values (@student_ID, @first_name, @middle_name, @last_name,@class,@program)";
                cmd = new MySqlCommand(coursein, con);
                cmd.Parameters.AddWithValue("@student_ID", lbStudentID.Text);
                cmd.Parameters.AddWithValue("@first_name", lbFirstName.Text);
                cmd.Parameters.AddWithValue("@middle_name", lbMiddleName.Text);
                cmd.Parameters.AddWithValue("@last_name", lbSurname.Text);
                cmd.Parameters.AddWithValue("@class", cbClass.Text);
                cmd.Parameters.AddWithValue("@program", cbProgram.Text);
            
                cmd.ExecuteNonQuery();
           
            

  
            btnEnroll.Hide();
            Form8 f = new Form8();
            f.Show();
            
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            datagrid();
        }
    }
        }

        
    

