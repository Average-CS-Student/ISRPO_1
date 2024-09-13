using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source= ADCLG1; Initial catalog=Трухин_ТРЗБД; Integrated Security=True";
        SqlConnection MyConnection;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExecuteQuery("delete from P2 where id = " + textBox1.Text);
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExecuteQuery($"update P2 set [Название] = '{textBox3.Text}', [Автор] = '{textBox4.Text}',[количество страниц] = {textBox5.Text},[год] = {textBox6.Text} where id = {textBox2.Text}");
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExecuteQuery($"insert into P2 values ('{textBox10.Text}', '{textBox9.Text}', {textBox8.Text}, {textBox7.Text})");
            LoadData();
        }

        private void LoadData()
        {
            using (MyConnection = new SqlConnection(connectionString))
            {
                string query = "select * from P2";
                SqlCommand com = new SqlCommand(query, MyConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private bool ExecuteQuery(string query)
        {
            try
            {
                using (MyConnection = new SqlConnection(connectionString))
                {
                    SqlCommand com = new SqlCommand(query, MyConnection);
                    MyConnection.Open();
                    com.ExecuteNonQuery();
                    MyConnection.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
    }
}
