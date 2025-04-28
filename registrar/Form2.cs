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
using Mysqlx.Prepare;
namespace registrar
{
    public partial class formstudent: Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;Initial Catalog=personal_info;uid=root;pwd=qaz123456789;database=students");
        MySqlCommand cmd = new MySqlCommand();
        
        public formstudent(string first_name,string middle_name,string last_name,string birthday)
        {
            InitializeComponent();
            lbfirst.Text = first_name;
            lbmiddle.Text  = middle_name;
            lblast.Text  = last_name;
            lbbirth.Text = birthday;
            
        }
        public void submited()
        {
            string application;
            string LRN;
            string medical;
            string PSA;
            string honorable;
            string reportcard;
            if (rbapplicsubmited.Checked)
            {
                
                 application = "submited";
            }
            if (rbhonorablesubmited.Checked)
            {
                honorable = "submited";
            }
            if (rbLRNsubmited.Checked)
            {
                LRN = "submited";
            }
            if (rbmedicalsubmited.Checked)
            {
                 medical = "submited";
            }
            if (rbPSAsubmited.Checked)
            {
                 PSA = "submited";
            }
            if (rbreportcardsubmited.Checked)
            {
                 reportcard = "submited";
            }
            

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbapplicsubmited.Checked && rbLRNsubmited.Checked && rbmedicalsubmited.Checked && rbPSAsubmited.Checked && rbreportcardsubmited.Checked)
            {
                MessageBox.Show("All requirements are submitted");
                cmd.Connection = con;
                con.Open();

                string sql = "insert into enrolled_students (first_name ,middle_name,last_name ,age  ,gender ,contactno ,Citizenship ,birthdate ,schoolyear ,placebirth ,homeaddress ,fathers_name ,mothers_name ,no_ofsiblings ,guardians_name ,guardians_relation ,guardians_contact,last_school,year_graduated ,honor_recieved,LRN , program,year_block,semester ,dateenrolled,no_subjects ,no_units ) select first_name ,middle_name,last_name ,age  ,gender ,contactno ,Citizenship ,birthdate ,schoolyear ,placebirth ,homeaddress ,fathers_name ,mothers_name ,no_ofsiblings ,guardians_name ,guardians_relation ,guardians_contact,last_school,year_graduated ,honor_recieved,LRN , program,year_block,semester ,dateenrolled,no_subjects ,no_units from personal_info where first_name = '" + lbfirst.Text + "' and middle_name ='" + lbmiddle.Text + "' and last_name = '" + lblast.Text + "'and birthdate ='" + lbbirth.Text + "';";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                string delete = "delete from personal_info where first_name = '" + lbfirst.Text + "' and last_name = '" + lblast.Text + "' and middle_name ='" + lbmiddle.Text + "'and birthdate ='" + lbbirth.Text + "';";
                cmd.CommandText = delete;
                cmd.ExecuteNonQuery();


                if (rbhonorablesubmited.Checked)
                {
                    string insert = "update enrolled_students set LRNsubmted = 'submited',PSAsubmited ='submited',medical_cert='submited', honorable_dismissal= 'submited' ,application_form ='submited' , reportcard ='submited' where first_name = '" + lbfirst.Text + "' and last_name = '" + lblast.Text + "' and middle_name ='" + lbmiddle.Text + "'and birthdate ='" + lbbirth.Text + "';";
                    cmd.CommandText = insert;
                    cmd.ExecuteNonQuery();
                    string firstname = lbfirst.Text;
                    string middlename = lbmiddle.Text;
                    string lastname = lblast.Text;
                    formpersonal_info formpersonal = new formpersonal_info(firstname, middlename, lastname);
                    formpersonal.Show();
                    cmd.Dispose();
                    con.Close();
                    this.Close();
                }
                else if (rbmedicalsubmited.Checked ^ rbLRNsubmited.Checked ^ rbPSAsubmited.Checked ^ rbreportcardsubmited.Checked)
                {
                    

                        string insert = "update enrolled_students set LRNsubmted = 'submited',PSAsubmited ='submited',medical_cert='submited' ,application_form ='submited' , reportcard ='submited' where first_name = '" + lbfirst.Text + "' and last_name = '" + lblast.Text + "' and middle_name ='" + lbmiddle.Text + "'and birthdate ='" + lbbirth.Text + "';";
                        cmd.CommandText = insert;
                        cmd.ExecuteNonQuery();
                        string firstname = lbfirst.Text;
                        string middlename = lbmiddle.Text;
                        string lastname = lblast.Text;
                        formpersonal_info formpersonal = new formpersonal_info(firstname, middlename, lastname);
                        formpersonal.Show();
                    
                    


                    cmd.Dispose();
                    con.Close();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Please submit all requirements to enroll");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formstudent_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(rbapplicsubmited.Checked && rbreportcardsubmited.Checked)
            {
                cmd.Connection = con;
                con.Open();
                string sql = "insert into enrolled_students (first_name ,middle_name,last_name ,age  ,gender ,contactno ,Citizenship ,birthdate ,schoolyear ,placebirth ,homeaddress ,fathers_name ,mothers_name ,no_ofsiblings ,guardians_name ,guardians_relation ,guardians_contact,last_school,year_graduated ,honor_recieved,LRN , program,year_block,semester ,dateenrolled,no_subjects ,no_units ) select first_name ,middle_name,last_name ,age  ,gender ,contactno ,Citizenship ,birthdate ,schoolyear ,placebirth ,homeaddress ,fathers_name ,mothers_name ,no_ofsiblings ,guardians_name ,guardians_relation ,guardians_contact,last_school,year_graduated ,honor_recieved,LRN , program,year_block,semester ,dateenrolled,no_subjects ,no_units from personal_info where first_name = '" + lbfirst.Text + "' and middle_name ='" + lbmiddle.Text + "' and last_name = '" + lblast.Text + "'and birthdate ='" + lbbirth.Text + "';";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                string delete = "delete from personal_info where first_name = '" + lbfirst.Text + "' and last_name = '" + lblast.Text + "' and middle_name ='" + lbmiddle.Text + "'and birthdate ='" + lbbirth.Text + "';";
                cmd.CommandText = delete;
                cmd.ExecuteNonQuery();


                if (rbhonorablesubmited.Checked)
                {
                    string insert = "update enrolled_students set honorable_dismissal= 'submited' ,application_form ='submited' , reportcard ='submited' where first_name = '" + lbfirst.Text + "' and last_name = '" + lblast.Text + "' and middle_name ='" + lbmiddle.Text + "'and birthdate ='" + lbbirth.Text + "';";
                    cmd.CommandText = insert;
                    cmd.ExecuteNonQuery();
                }
                else
                {

                    string insert = "update enrolled_students set application_form ='submited' , reportcard ='submited' where first_name = '" + lbfirst.Text + "' and last_name = '" + lblast.Text + "' and middle_name ='" + lbmiddle.Text + "'and birthdate ='" + lbbirth.Text + "';";
                    cmd.CommandText = insert;
                    cmd.ExecuteNonQuery();
                    if(rbLRNsubmited.Checked)
                    {
                        string ins = "update enrolled_students set LRNsubmited ='submited'  where first_name = '" + lbfirst.Text + "' and last_name = '" + lblast.Text + "' and middle_name ='" + lbmiddle.Text + "'and birthdate ='" + lbbirth.Text + "';";
                        cmd.CommandText = ins;
                        cmd.ExecuteNonQuery();
                    }
                    if (rbmedicalsubmited.Checked)
                    {
                        string ins = "update enrolled_students set medical_cert ='submited'  where first_name = '" + lbfirst.Text + "' and last_name = '" + lblast.Text + "' and middle_name ='" + lbmiddle.Text + "'and birthdate ='" + lbbirth.Text + "';";
                        cmd.CommandText = ins;
                        cmd.ExecuteNonQuery();
                    }
                    if (rbPSAsubmited.Checked)
                    {
                        string ins = "update enrolled_students set PSAsubmited ='submited'  where first_name = '" + lbfirst.Text + "' and last_name = '" + lblast.Text + "' and middle_name ='" + lbmiddle.Text + "'and birthdate ='" + lbbirth.Text + "';";
                        cmd.CommandText = ins;
                        cmd.ExecuteNonQuery();
                    }
                    
                }
                MessageBox.Show("requirements are submitted please submit the remaining requirments in the future");

                string firstname = lbfirst.Text;
                string middlename = lbmiddle.Text;
                string lastname = lblast.Text;
                formpersonal_info formpersonal = new formpersonal_info(firstname, middlename, lastname);
                formpersonal.Show();
                
                this.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("please submit application and report card to enroll");
            }
        }
    }
}
