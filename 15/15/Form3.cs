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
    public partial class Form3 : Form
    {
        Form1 parent;
        public Form3(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "трухин_ТРЗБДDataSet.SpecialtyLW". При необходимости она может быть перемещена или удалена.
            this.specialtyLWTableAdapter.Fill(this.трухин_ТРЗБДDataSet.SpecialtyLW);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            parent.form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            parent.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            parent.form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.specialtyLWTableAdapter.Fill(this.трухин_ТРЗБДDataSet.SpecialtyLW);
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
