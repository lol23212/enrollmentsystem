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

namespace registrar
{
    public partial class formpersonal_info: Form
    {
        public formpersonal_info()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;Initial Catalog=personal_info;uid=root;pwd=qaz123456789;database=students");
        MySqlCommand cmd = new MySqlCommand();
        public formpersonal_info(string first_name, string middle_name, string last_name)
        {
            InitializeComponent();
            lbfirst.Text = first_name;
            lbmiddle.Text = middle_name;
            lblast.Text = last_name;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            cmd.Connection = con;
            try
            {
                con.Open();
                string account = "select student_num from enrolled_students where first_name = '" + lbfirst.Text + "' and last_name = '" + lblast.Text + "';";
                string pass = "select pass from enrolled_students where first_name = '" + lbfirst.Text + "' and last_name = '" + lblast.Text + "';";
                MySqlCommand acc = new MySqlCommand(account, con);

                MySqlDataReader readacc = acc.ExecuteReader();
                int stnum = 0;
                string passs = "";

                if (readacc.Read())
                {
                    stnum = readacc.GetInt32("student_num");
                }
                readacc.Close();

                MySqlCommand pas = new MySqlCommand(pass, con);
                MySqlDataReader readpass = pas.ExecuteReader();
                if (readpass.Read())
                {

                    passs = readpass.GetString("pass");
                }
                readpass.Close();
                lbstudentnum.Text = stnum.ToString();
                lbpass.Text = passs;
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

        private void butonOK_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}
