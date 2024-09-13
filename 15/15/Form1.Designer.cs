namespace _15
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.трухин_ТРЗБДDataSet = new _15.Трухин_ТРЗБДDataSet();
            this.studentLWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentLWTableAdapter = new _15.Трухин_ТРЗБДDataSetTableAdapters.StudentLWTableAdapter();
            this.studentRecordBookNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentPatronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentEnrolmentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentFacultyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentSpecialtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentUndergraduateYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentGroupNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.трухин_ТРЗБДDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentLWBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentRecordBookNumberDataGridViewTextBoxColumn,
            this.studentFullNameDataGridViewTextBoxColumn,
            this.studentPatronymicDataGridViewTextBoxColumn,
            this.studentEnrolmentDateDataGridViewTextBoxColumn,
            this.studentFacultyDataGridViewTextBoxColumn,
            this.studentSpecialtyDataGridViewTextBoxColumn,
            this.studentUndergraduateYearDataGridViewTextBoxColumn,
            this.studentGroupNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentLWBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // трухин_ТРЗБДDataSet
            // 
            this.трухин_ТРЗБДDataSet.DataSetName = "Трухин_ТРЗБДDataSet";
            this.трухин_ТРЗБДDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentLWBindingSource
            // 
            this.studentLWBindingSource.DataMember = "StudentLW";
            this.studentLWBindingSource.DataSource = this.трухин_ТРЗБДDataSet;
            // 
            // studentLWTableAdapter
            // 
            this.studentLWTableAdapter.ClearBeforeFill = true;
            // 
            // studentRecordBookNumberDataGridViewTextBoxColumn
            // 
            this.studentRecordBookNumberDataGridViewTextBoxColumn.DataPropertyName = "StudentRecordBookNumber";
            this.studentRecordBookNumberDataGridViewTextBoxColumn.HeaderText = "StudentRecordBookNumber";
            this.studentRecordBookNumberDataGridViewTextBoxColumn.Name = "studentRecordBookNumberDataGridViewTextBoxColumn";
            // 
            // studentFullNameDataGridViewTextBoxColumn
            // 
            this.studentFullNameDataGridViewTextBoxColumn.DataPropertyName = "StudentFullName";
            this.studentFullNameDataGridViewTextBoxColumn.HeaderText = "StudentFullName";
            this.studentFullNameDataGridViewTextBoxColumn.Name = "studentFullNameDataGridViewTextBoxColumn";
            // 
            // studentPatronymicDataGridViewTextBoxColumn
            // 
            this.studentPatronymicDataGridViewTextBoxColumn.DataPropertyName = "StudentPatronymic";
            this.studentPatronymicDataGridViewTextBoxColumn.HeaderText = "StudentPatronymic";
            this.studentPatronymicDataGridViewTextBoxColumn.Name = "studentPatronymicDataGridViewTextBoxColumn";
            // 
            // studentEnrolmentDateDataGridViewTextBoxColumn
            // 
            this.studentEnrolmentDateDataGridViewTextBoxColumn.DataPropertyName = "StudentEnrolmentDate";
            this.studentEnrolmentDateDataGridViewTextBoxColumn.HeaderText = "StudentEnrolmentDate";
            this.studentEnrolmentDateDataGridViewTextBoxColumn.Name = "studentEnrolmentDateDataGridViewTextBoxColumn";
            // 
            // studentFacultyDataGridViewTextBoxColumn
            // 
            this.studentFacultyDataGridViewTextBoxColumn.DataPropertyName = "StudentFaculty";
            this.studentFacultyDataGridViewTextBoxColumn.HeaderText = "StudentFaculty";
            this.studentFacultyDataGridViewTextBoxColumn.Name = "studentFacultyDataGridViewTextBoxColumn";
            // 
            // studentSpecialtyDataGridViewTextBoxColumn
            // 
            this.studentSpecialtyDataGridViewTextBoxColumn.DataPropertyName = "StudentSpecialty";
            this.studentSpecialtyDataGridViewTextBoxColumn.HeaderText = "StudentSpecialty";
            this.studentSpecialtyDataGridViewTextBoxColumn.Name = "studentSpecialtyDataGridViewTextBoxColumn";
            // 
            // studentUndergraduateYearDataGridViewTextBoxColumn
            // 
            this.studentUndergraduateYearDataGridViewTextBoxColumn.DataPropertyName = "StudentUndergraduateYear";
            this.studentUndergraduateYearDataGridViewTextBoxColumn.HeaderText = "StudentUndergraduateYear";
            this.studentUndergraduateYearDataGridViewTextBoxColumn.Name = "studentUndergraduateYearDataGridViewTextBoxColumn";
            // 
            // studentGroupNumberDataGridViewTextBoxColumn
            // 
            this.studentGroupNumberDataGridViewTextBoxColumn.DataPropertyName = "StudentGroupNumber";
            this.studentGroupNumberDataGridViewTextBoxColumn.HeaderText = "StudentGroupNumber";
            this.studentGroupNumberDataGridViewTextBoxColumn.Name = "studentGroupNumberDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(863, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Успеваемость";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(863, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Специальность";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(863, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 43);
            this.button3.TabIndex = 3;
            this.button3.Text = "Предмет и факультет";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(863, 415);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "обновить данные";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(992, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Студент";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.трухин_ТРЗБДDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentLWBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Трухин_ТРЗБДDataSet трухин_ТРЗБДDataSet;
        private System.Windows.Forms.BindingSource studentLWBindingSource;
        private Трухин_ТРЗБДDataSetTableAdapters.StudentLWTableAdapter studentLWTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentRecordBookNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentPatronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentEnrolmentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentFacultyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentSpecialtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentUndergraduateYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentGroupNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

