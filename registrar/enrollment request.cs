using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;


namespace registrar
{
    
    public partial class enrollment_request: Form
    {
        MySqlConnection connect = new MySqlConnection(@"Data Source =localhost;Initial Catalog=personal_info;uid=root;pwd = qaz123456789;database=students");
        MySqlCommand cmd = new MySqlCommand();
        public enrollment_request()
        {
            InitializeComponent();
        }
        public void search()
        {
            string search = "select * from personal_info where concat (first_name, middle_name, last_name) like '%" + textBox1.Text + "%' ";
            connect.Open();
            cmd = new MySqlCommand(search, connect);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable Table = new DataTable();
            adapter.Fill(Table);
            dataGridView1.DataSource = Table;
            cmd.Dispose();
            connect.Close();
        }
        public void Filer()
        {
            connect.Open();

            string sql = "select * from personal_info ;";
            
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
                cmd.Dispose();
                connect.Close();
            
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }

        private void enrollment_request_Load(object sender, EventArgs e)
        {
            
            Filer();
            

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string search = "select * from personal_info where first_name like '%" + textBox1.Text + "%' or last_name like '%" + textBox1.Text + "%' or middle_name like '%" + textBox1.Text + "%';";

            cmd = new MySqlCommand(search, connect);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable Table = new DataTable();
            adapter.Fill(Table);
            dataGridView1.DataSource = Table;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {
                string first_name = row.Cells[0].Value.ToString();
                string middle_name = row.Cells[1].Value.ToString();
                string last_name = row.Cells[2].Value.ToString();
                string birthdate = row.Cells[7].Value.ToString();
                formstudent f = new formstudent(first_name,middle_name,last_name,birthdate);
                
                f.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Filer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            Filer();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search();
            }
        }
    }
}
