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
    public partial class Form4 : Form
    {
        Form1 parent;
        public Form4(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "трухин_ТРЗБДDataSet.FacultyLW". При необходимости она может быть перемещена или удалена.
            this.facultyLWTableAdapter.Fill(this.трухин_ТРЗБДDataSet.FacultyLW);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "трухин_ТРЗБДDataSet.SubjectLW". При необходимости она может быть перемещена или удалена.
            this.subjectLWTableAdapter.Fill(this.трухин_ТРЗБДDataSet.SubjectLW);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            parent.form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            parent.form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            parent.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.facultyLWTableAdapter.Fill(this.трухин_ТРЗБДDataSet.FacultyLW);
            this.subjectLWTableAdapter.Fill(this.трухин_ТРЗБДDataSet.SubjectLW);
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
