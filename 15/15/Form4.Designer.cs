namespace _15
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.трухин_ТРЗБДDataSet = new _15.Трухин_ТРЗБДDataSet();
            this.subjectLWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectLWTableAdapter = new _15.Трухин_ТРЗБДDataSetTableAdapters.SubjectLWTableAdapter();
            this.subjectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.facultyLWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facultyLWTableAdapter = new _15.Трухин_ТРЗБДDataSetTableAdapters.FacultyLWTableAdapter();
            this.faculityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.трухин_ТРЗБДDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectLWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyLWBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectIDDataGridViewTextBoxColumn,
            this.subjectNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.subjectLWBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(247, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // трухин_ТРЗБДDataSet
            // 
            this.трухин_ТРЗБДDataSet.DataSetName = "Трухин_ТРЗБДDataSet";
            this.трухин_ТРЗБДDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectLWBindingSource
            // 
            this.subjectLWBindingSource.DataMember = "SubjectLW";
            this.subjectLWBindingSource.DataSource = this.трухин_ТРЗБДDataSet;
            // 
            // subjectLWTableAdapter
            // 
            this.subjectLWTableAdapter.ClearBeforeFill = true;
            // 
            // subjectIDDataGridViewTextBoxColumn
            // 
            this.subjectIDDataGridViewTextBoxColumn.DataPropertyName = "SubjectID";
            this.subjectIDDataGridViewTextBoxColumn.HeaderText = "SubjectID";
            this.subjectIDDataGridViewTextBoxColumn.Name = "subjectIDDataGridViewTextBoxColumn";
            // 
            // subjectNameDataGridViewTextBoxColumn
            // 
            this.subjectNameDataGridViewTextBoxColumn.DataPropertyName = "SubjectName";
            this.subjectNameDataGridViewTextBoxColumn.HeaderText = "SubjectName";
            this.subjectNameDataGridViewTextBoxColumn.Name = "subjectNameDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.faculityIDDataGridViewTextBoxColumn,
            this.facultyNameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.facultyLWBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(267, 13);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(246, 425);
            this.dataGridView2.TabIndex = 1;
            // 
            // facultyLWBindingSource
            // 
            this.facultyLWBindingSource.DataMember = "FacultyLW";
            this.facultyLWBindingSource.DataSource = this.трухин_ТРЗБДDataSet;
            // 
            // facultyLWTableAdapter
            // 
            this.facultyLWTableAdapter.ClearBeforeFill = true;
            // 
            // faculityIDDataGridViewTextBoxColumn
            // 
            this.faculityIDDataGridViewTextBoxColumn.DataPropertyName = "FaculityID";
            this.faculityIDDataGridViewTextBoxColumn.HeaderText = "FaculityID";
            this.faculityIDDataGridViewTextBoxColumn.Name = "faculityIDDataGridViewTextBoxColumn";
            // 
            // facultyNameDataGridViewTextBoxColumn
            // 
            this.facultyNameDataGridViewTextBoxColumn.DataPropertyName = "FacultyName";
            this.facultyNameDataGridViewTextBoxColumn.HeaderText = "FacultyName";
            this.facultyNameDataGridViewTextBoxColumn.Name = "facultyNameDataGridViewTextBoxColumn";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(519, 415);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "обновить данные";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(519, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Студент";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(519, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Специальность";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Успеваемость";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(648, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form4";
            this.Text = "Предмет и факультет";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.трухин_ТРЗБДDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectLWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyLWBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Трухин_ТРЗБДDataSet трухин_ТРЗБДDataSet;
        private System.Windows.Forms.BindingSource subjectLWBindingSource;
        private Трухин_ТРЗБДDataSetTableAdapters.SubjectLWTableAdapter subjectLWTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource facultyLWBindingSource;
        private Трухин_ТРЗБДDataSetTableAdapters.FacultyLWTableAdapter facultyLWTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn faculityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}