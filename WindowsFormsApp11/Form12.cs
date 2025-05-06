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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
            this.AcceptButton = button2; // Set the default button to button1
        }
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;uid=root;pwd=qaz123456789;database=students");
        MySqlCommand cmd = new MySqlCommand();
        private void Form12_Load(object sender, EventArgs e)
        {
            
        }

        private void gradiantPanel2_Paint(object sender, PaintEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;

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

                string checkuser = "SELECT count(*) FROM teachersacc WHERE teacher_ID = @username AND passwords = @password";
                string checkid = "SELECT count(*) FROM teachersacc WHERE teacher_ID = @username";

                try
                {
                    con.Open();
                    using (MySqlCommand cmd1 = new MySqlCommand(checkid, con)) {
                        cmd1.Parameters.AddWithValue("@username", login);
                        

                        int User = Convert.ToInt32(cmd1.ExecuteScalar());
                        if (User == 0)
                        {
                            label1.Text = "Invalid username";
                            return;

                        }
                    }
                    using (MySqlCommand cmd2 = new MySqlCommand(checkuser, con))
                    {
                        cmd2.Parameters.AddWithValue("@username", login);
                        cmd2.Parameters.AddWithValue("@password", password);
                        pass = Convert.ToInt32(cmd2.ExecuteScalar());
                        if (pass > 0)
                        {

                            

                           
                            Form9 f = new Form9(login);
                            f.Show();
                            this.Hide();
                        }
                        else
                        {
                            label7.Text = "Incorrect Password";
                        }

                    }







                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
