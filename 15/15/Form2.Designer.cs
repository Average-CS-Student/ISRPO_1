namespace _15
{
    partial class Form2
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
            this.academicPerformanceLWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.academicPerformanceLWTableAdapter = new _15.Трухин_ТРЗБДDataSetTableAdapters.AcademicPerformanceLWTableAdapter();
            this.aCRecordBookNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCSemesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCSubjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCMarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCExamDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCLecturerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.трухин_ТРЗБДDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicPerformanceLWBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aCRecordBookNumberDataGridViewTextBoxColumn,
            this.aCSemesterDataGridViewTextBoxColumn,
            this.aCSubjectDataGridViewTextBoxColumn,
            this.aCMarkDataGridViewTextBoxColumn,
            this.aCExamDateDataGridViewTextBoxColumn,
            this.aCLecturerNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.academicPerformanceLWBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // трухин_ТРЗБДDataSet
            // 
            this.трухин_ТРЗБДDataSet.DataSetName = "Трухин_ТРЗБДDataSet";
            this.трухин_ТРЗБДDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // academicPerformanceLWBindingSource
            // 
            this.academicPerformanceLWBindingSource.DataMember = "AcademicPerformanceLW";
            this.academicPerformanceLWBindingSource.DataSource = this.трухин_ТРЗБДDataSet;
            // 
            // academicPerformanceLWTableAdapter
            // 
            this.academicPerformanceLWTableAdapter.ClearBeforeFill = true;
            // 
            // aCRecordBookNumberDataGridViewTextBoxColumn
            // 
            this.aCRecordBookNumberDataGridViewTextBoxColumn.DataPropertyName = "ACRecordBookNumber";
            this.aCRecordBookNumberDataGridViewTextBoxColumn.HeaderText = "ACRecordBookNumber";
            this.aCRecordBookNumberDataGridViewTextBoxColumn.Name = "aCRecordBookNumberDataGridViewTextBoxColumn";
            // 
            // aCSemesterDataGridViewTextBoxColumn
            // 
            this.aCSemesterDataGridViewTextBoxColumn.DataPropertyName = "ACSemester";
            this.aCSemesterDataGridViewTextBoxColumn.HeaderText = "ACSemester";
            this.aCSemesterDataGridViewTextBoxColumn.Name = "aCSemesterDataGridViewTextBoxColumn";
            // 
            // aCSubjectDataGridViewTextBoxColumn
            // 
            this.aCSubjectDataGridViewTextBoxColumn.DataPropertyName = "ACSubject";
            this.aCSubjectDataGridViewTextBoxColumn.HeaderText = "ACSubject";
            this.aCSubjectDataGridViewTextBoxColumn.Name = "aCSubjectDataGridViewTextBoxColumn";
            // 
            // aCMarkDataGridViewTextBoxColumn
            // 
            this.aCMarkDataGridViewTextBoxColumn.DataPropertyName = "ACMark";
            this.aCMarkDataGridViewTextBoxColumn.HeaderText = "ACMark";
            this.aCMarkDataGridViewTextBoxColumn.Name = "aCMarkDataGridViewTextBoxColumn";
            // 
            // aCExamDateDataGridViewTextBoxColumn
            // 
            this.aCExamDateDataGridViewTextBoxColumn.DataPropertyName = "ACExamDate";
            this.aCExamDateDataGridViewTextBoxColumn.HeaderText = "ACExamDate";
            this.aCExamDateDataGridViewTextBoxColumn.Name = "aCExamDateDataGridViewTextBoxColumn";
            // 
            // aCLecturerNameDataGridViewTextBoxColumn
            // 
            this.aCLecturerNameDataGridViewTextBoxColumn.DataPropertyName = "ACLecturerName";
            this.aCLecturerNameDataGridViewTextBoxColumn.HeaderText = "ACLecturerName";
            this.aCLecturerNameDataGridViewTextBoxColumn.Name = "aCLecturerNameDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(666, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Студент";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(666, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Специальность";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(666, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 43);
            this.button3.TabIndex = 4;
            this.button3.Text = "Предмет и факультет";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(666, 415);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "обновить данные";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Успеваемость";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.трухин_ТРЗБДDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academicPerformanceLWBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Трухин_ТРЗБДDataSet трухин_ТРЗБДDataSet;
        private System.Windows.Forms.BindingSource academicPerformanceLWBindingSource;
        private Трухин_ТРЗБДDataSetTableAdapters.AcademicPerformanceLWTableAdapter academicPerformanceLWTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCRecordBookNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCSemesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCSubjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCMarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCExamDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCLecturerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}