using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace registrar
{
    public partial class studentforms: Form
    {
        MySqlConnection connect = new MySqlConnection(@"Data Source =localhost;Initial Catalog=personal_info;uid=root;pwd = qaz123456789;database=students");
        MySqlCommand cmd = new MySqlCommand();

        public studentforms()
        {
            InitializeComponent();
        }
        public void Filer()
        {
            connect.Open();

            string sql = "select * from enrolled_students ;";
            if (cbincomp.Checked)
            {
                string notsub = "select * from enrolled_students where  LRNsubmted is null or PSAsubmited is null or medical_cert is null  ;";
                MySqlDataAdapter adapter = new MySqlDataAdapter(notsub, connect);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                connect.Close();
            }
            else
            {

                try
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connect);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    connect.Close();

                }
                catch (Exception ex)
                {

                }
            }
            cmd.Dispose();
            connect.Close();

        }
        public void search(int num)
        {
            if (num == 0)
            {
                string idsearch = "select * from enrolled_students where student_num ='" + txtID.Text + "' ;";
                string fname = "select concat (first_name,' ',middle_name,' ',last_name) as full_name from enrolled_students where student_num = '" + txtID.Text + "' ";
                if (txtID.Text == "")
                {
                    txtname.Clear();
                    Filer();
                }
                else
                {

                    try
                    {
                        connect.Open();
                        cmd = new MySqlCommand(idsearch, connect);
                        MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                        DataTable Tab = new DataTable();
                        adap.Fill(Tab);
                        dataGridView1.DataSource = Tab;
                        cmd = new MySqlCommand(fname, connect);
                        MySqlDataReader fread = cmd.ExecuteReader();
                        if (fread.Read())
                        {
                            string fnames = fread.GetString("full_name");
                            txtname.Text = fnames;
                        }
                        fread.Close();
                    }
                    catch (Exception ex) { }
                    cmd.Dispose();

                    connect.Close();
                }
            }
            else
            {
                string search = "select * from enrolled_students where concat (first_name,' ',middle_name,' ',last_name) like '%" + txtname.Text + "%' ";
                string idsearch = "select student_num from enrolled_students  where concat (first_name,' ',middle_name,' ',last_name) like '%" + txtname.Text + "%' ";
                ;
                if (txtname.Text == "")
                {
                    txtID.Clear();
                    Filer() ;
                }
                else
                {
                    try
                    {
                        connect.Open();
                        cmd = new MySqlCommand(search, connect);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable Table = new DataTable();
                        adapter.Fill(Table);
                        dataGridView1.DataSource = Table;
                        cmd = new MySqlCommand(idsearch, connect);
                        MySqlDataReader read = cmd.ExecuteReader();
                        if (read.Read())
                        {
                            int ID = read.GetInt32("student_num");
                            txtID.Text = ID.ToString();
                        }
                        read.Close();
                    }
                    catch (Exception ex) { }
                    cmd.Dispose();

                    connect.Close();
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void studentforms_Load(object sender, EventArgs e)
        {
            
            
            Filer();
            
        }

        private void ENTER_Click(object sender, EventArgs e)
        {
            search(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtname.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Filer();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search(1);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search(0);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            search(0);
        }

        private void cbincomp_CheckedChanged(object sender, EventArgs e)
        {
            Filer();
        }
    }
}
