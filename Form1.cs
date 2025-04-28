using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace activity_login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;Initial Catalog=personal_info;uid=root;pwd=qaz123456789;database=students");
        MySqlCommand cmd = new MySqlCommand();
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtlogin.Text == "" ^ txtpassword.Text == "")
            {
                label1.Text = "Please enter your username";
                label7.Text = "Please enter your password";
            }
            
            string login = txtlogin.Text;
            if (int.TryParse(login, out int num))
            {

                string checkuser = "SELECT exists (select 1 FROM enrolled_students WHERE student_num ='" + txtlogin.Text + "');";
                string checkpass = "SELECT exists (select 1 FROM enrolled_students WHERE pass ='" + txtpassword.Text + "');";



                int use;
                int pass;
                con.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand(checkuser, con);
                    use = Convert.ToInt32(cmd.ExecuteScalar());

                    cmd = new MySqlCommand(checkpass, con);
                    pass = Convert.ToInt32(cmd.ExecuteScalar());





                    if (use == 0)
                    {
                        label7.Text = "wrong password";
                    }
                    if (pass == 0)
                    {
                        label1.Text = "wrong username";
                    }
                    else if (use == 1 && pass == 1)
                    {
                        string studentnum = txtlogin.Text;
                        string studentpass = txtpassword.Text;
                        formstudent student = new formstudent(studentnum, studentpass);
                        student.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                label1.Text = "wrong username";
                label7.Text = "wrong password";
            }
        }
    }
}
