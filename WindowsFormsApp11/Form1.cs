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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin; // Set the default button to button1
        }
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;Initial Catalog=personal_info;uid=root;pwd=qaz123456789;database=students");
        MySqlCommand cmd = new MySqlCommand();

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string login = txtLogin.Text;
            
            int pass;

            if (txtLogin.Text == "")
            {
                label1.Text = "Please enter your username";
                label7.Text = "";


            }
            else if (txtPassword.Text == "")
            {
                label7.Text = "Please enter your password";
                label1.Text = "";


            }
            else
            {

                string checkuser = "SELECT count(*) from enrolled_students where student_num =@username and pass = @password;";
                string checkid = "SELECT count(*) from enrolled_students where student_num =@username;";
                


                
                
                    con.Open();
                    try
                    {
                    cmd = new MySqlCommand(checkuser, con);
                    cmd.Parameters.AddWithValue("@username", txtLogin.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    pass = Convert.ToInt32(cmd.ExecuteScalar());
                    cmd = new MySqlCommand(checkid, con);
                    cmd.Parameters.AddWithValue("@username", txtLogin.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    int User = Convert.ToInt32(cmd.ExecuteScalar());
                   

                    if (User == 0) 
                    { 
                        label1.Text = "Invalid username";
                        
                    }
                    
                    else if (pass > 0)
                    {
                        
                        string studentnum = txtLogin.Text;

                        Form10 student = new Form10(studentnum);
                        student.Show();
                        this.Hide();
                    }
                    else
                    {
                        label7.Text = "Incorrect Password";
                    }

                        
                    }
                    catch (Exception ex)
                    {
                        if (ex.InnerException != null)
                        {
                            MessageBox.Show($"Error: {ex.Message}\n\nInner Exception: {ex.InnerException.Message}");
                        }
                        else
                        {
                            MessageBox.Show($"Error: {ex.Message}");
                        }
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            
            
        }

        private void gradiantPanel1_Paint(object sender, PaintEventArgs e)
        {
            if (checkBox1.Checked)
            {

                txtPassword.PasswordChar = '\0';


            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            formlogin form = new formlogin();
            form.Show();
            this.Hide();

        }
    }
}
    

