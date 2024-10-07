namespace Kyrsovaya
{
    partial class FormUspevaemost
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
            this.dataGridViewUspe = new System.Windows.Forms.DataGridView();
            this.iDUspevaemostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ochenkiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uspevaemostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchebnye_kursiDataSet18 = new Kyrsovaya.Uchebnye_kursiDataSet18();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.курсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записьНаКурсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.преподавателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оценкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экзаменыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbDelUspe = new System.Windows.Forms.TextBox();
            this.uspevaemostTableAdapter = new Kyrsovaya.Uchebnye_kursiDataSet18TableAdapters.UspevaemostTableAdapter();
            this.uchebnye_kursiDataSet36 = new Kyrsovaya.Uchebnye_kursiDataSet36();
            this.uspevaemostBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uspevaemostTableAdapter1 = new Kyrsovaya.Uchebnye_kursiDataSet36TableAdapters.UspevaemostTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUspe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspevaemostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet18)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspevaemostBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUspe
            // 
            this.dataGridViewUspe.AutoGenerateColumns = false;
            this.dataGridViewUspe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUspe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDUspevaemostDataGridViewTextBoxColumn,
            this.studentIDDataGridViewTextBoxColumn,
            this.ochenkiIDDataGridViewTextBoxColumn});
            this.dataGridViewUspe.DataSource = this.uspevaemostBindingSource1;
            this.dataGridViewUspe.Location = new System.Drawing.Point(56, 68);
            this.dataGridViewUspe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewUspe.Name = "dataGridViewUspe";
            this.dataGridViewUspe.RowHeadersWidth = 51;
            this.dataGridViewUspe.Size = new System.Drawing.Size(571, 286);
            this.dataGridViewUspe.TabIndex = 0;
            // 
            // iDUspevaemostDataGridViewTextBoxColumn
            // 
            this.iDUspevaemostDataGridViewTextBoxColumn.DataPropertyName = "ID_Uspevaemost";
            this.iDUspevaemostDataGridViewTextBoxColumn.HeaderText = "ID_Uspevaemost";
            this.iDUspevaemostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDUspevaemostDataGridViewTextBoxColumn.Name = "iDUspevaemostDataGridViewTextBoxColumn";
            this.iDUspevaemostDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "Student_ID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "Student_ID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ochenkiIDDataGridViewTextBoxColumn
            // 
            this.ochenkiIDDataGridViewTextBoxColumn.DataPropertyName = "Ochenki_ID";
            this.ochenkiIDDataGridViewTextBoxColumn.HeaderText = "Ochenki_ID";
            this.ochenkiIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ochenkiIDDataGridViewTextBoxColumn.Name = "ochenkiIDDataGridViewTextBoxColumn";
            this.ochenkiIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // uspevaemostBindingSource
            // 
            this.uspevaemostBindingSource.DataMember = "Uspevaemost";
            this.uspevaemostBindingSource.DataSource = this.uchebnye_kursiDataSet18;
            // 
            // uchebnye_kursiDataSet18
            // 
            this.uchebnye_kursiDataSet18.DataSetName = "Uchebnye_kursiDataSet18";
            this.uchebnye_kursiDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.таблицыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(692, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.курсToolStripMenuItem,
            this.записьНаКурсToolStripMenuItem,
            this.преподавателиToolStripMenuItem,
            this.студентыToolStripMenuItem,
            this.оценкиToolStripMenuItem,
            this.экзаменыToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // курсToolStripMenuItem
            // 
            this.курсToolStripMenuItem.Name = "курсToolStripMenuItem";
            this.курсToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.курсToolStripMenuItem.Text = "Курс";
            this.курсToolStripMenuItem.Click += new System.EventHandler(this.курсToolStripMenuItem_Click);
            // 
            // записьНаКурсToolStripMenuItem
            // 
            this.записьНаКурсToolStripMenuItem.Name = "записьНаКурсToolStripMenuItem";
            this.записьНаКурсToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.записьНаКурсToolStripMenuItem.Text = "Запись на курс ";
            this.записьНаКурсToolStripMenuItem.Click += new System.EventHandler(this.записьНаКурсToolStripMenuItem_Click);
            // 
            // преподавателиToolStripMenuItem
            // 
            this.преподавателиToolStripMenuItem.Name = "преподавателиToolStripMenuItem";
            this.преподавателиToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.преподавателиToolStripMenuItem.Text = "Преподаватели";
            this.преподавателиToolStripMenuItem.Click += new System.EventHandler(this.преподавателиToolStripMenuItem_Click);
            // 
            // студентыToolStripMenuItem
            // 
            this.студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
            this.студентыToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.студентыToolStripMenuItem.Text = "Студенты";
            this.студентыToolStripMenuItem.Click += new System.EventHandler(this.студентыToolStripMenuItem_Click);
            // 
            // оценкиToolStripMenuItem
            // 
            this.оценкиToolStripMenuItem.Name = "оценкиToolStripMenuItem";
            this.оценкиToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.оценкиToolStripMenuItem.Text = "Оценки";
            this.оценкиToolStripMenuItem.Click += new System.EventHandler(this.оценкиToolStripMenuItem_Click);
            // 
            // экзаменыToolStripMenuItem
            // 
            this.экзаменыToolStripMenuItem.Name = "экзаменыToolStripMenuItem";
            this.экзаменыToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.экзаменыToolStripMenuItem.Text = "Экзамены";
            this.экзаменыToolStripMenuItem.Click += new System.EventHandler(this.экзаменыToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 411);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 411);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 54);
            this.button2.TabIndex = 3;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(503, 411);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 54);
            this.button3.TabIndex = 4;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbDelUspe
            // 
            this.tbDelUspe.Location = new System.Drawing.Point(885, 228);
            this.tbDelUspe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDelUspe.Name = "tbDelUspe";
            this.tbDelUspe.Size = new System.Drawing.Size(132, 22);
            this.tbDelUspe.TabIndex = 5;
            // 
            // uspevaemostTableAdapter
            // 
            this.uspevaemostTableAdapter.ClearBeforeFill = true;
            // 
            // uchebnye_kursiDataSet36
            // 
            this.uchebnye_kursiDataSet36.DataSetName = "Uchebnye_kursiDataSet36";
            this.uchebnye_kursiDataSet36.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uspevaemostBindingSource1
            // 
            this.uspevaemostBindingSource1.DataMember = "Uspevaemost";
            this.uspevaemostBindingSource1.DataSource = this.uchebnye_kursiDataSet36;
            // 
            // uspevaemostTableAdapter1
            // 
            this.uspevaemostTableAdapter1.ClearBeforeFill = true;
            // 
            // FormUspevaemost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 554);
            this.Controls.Add(this.tbDelUspe);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewUspe);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormUspevaemost";
            this.Text = "Успеваемость";
            this.Load += new System.EventHandler(this.FormUspevaemost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUspe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspevaemostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet18)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspevaemostBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbDelUspe;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem курсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записьНаКурсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem преподавателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оценкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экзаменыToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridViewUspe;
        private Uchebnye_kursiDataSet18 uchebnye_kursiDataSet18;
        private System.Windows.Forms.BindingSource uspevaemostBindingSource;
        private Uchebnye_kursiDataSet18TableAdapters.UspevaemostTableAdapter uspevaemostTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUspevaemostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ochenkiIDDataGridViewTextBoxColumn;
        private Uchebnye_kursiDataSet36 uchebnye_kursiDataSet36;
        private System.Windows.Forms.BindingSource uspevaemostBindingSource1;
        private Uchebnye_kursiDataSet36TableAdapters.UspevaemostTableAdapter uspevaemostTableAdapter1;
    }
}