using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15
{
    public partial class Form1 : Form
    {
        public Form2 form2;
        public Form3 form3;
        public Form4 form4;
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2(this);
            form3 = new Form3(this);
            form4 = new Form4(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "трухин_ТРЗБДDataSet.StudentLW". При необходимости она может быть перемещена или удалена.
            this.studentLWTableAdapter.Fill(this.трухин_ТРЗБДDataSet.StudentLW);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.studentLWTableAdapter.Fill(this.трухин_ТРЗБДDataSet.StudentLW);
        }
    }
}
