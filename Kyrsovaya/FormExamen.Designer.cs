namespace Kyrsovaya
{
    partial class FormExamen
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.курсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записьНаКурсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.преподавательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.успеваемостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оценкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewExamen = new System.Windows.Forms.DataGridView();
            this.iDExamenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataexamenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kursIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchebnye_kursiDataSet27 = new Kyrsovaya.Uchebnye_kursiDataSet27();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbDelExamen = new System.Windows.Forms.TextBox();
            this.examenTableAdapter = new Kyrsovaya.Uchebnye_kursiDataSet27TableAdapters.ExamenTableAdapter();
            this.uchebnye_kursiDataSet38 = new Kyrsovaya.Uchebnye_kursiDataSet38();
            this.examenBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.examenTableAdapter1 = new Kyrsovaya.Uchebnye_kursiDataSet38TableAdapters.ExamenTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExamen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.таблицыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(649, 28);
            this.menuStrip1.TabIndex = 0;
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
            this.преподавательToolStripMenuItem,
            this.студентToolStripMenuItem,
            this.успеваемостьToolStripMenuItem,
            this.оценкиToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // курсToolStripMenuItem
            // 
            this.курсToolStripMenuItem.Name = "курсToolStripMenuItem";
            this.курсToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.курсToolStripMenuItem.Text = "Курс";
            this.курсToolStripMenuItem.Click += new System.EventHandler(this.курсToolStripMenuItem_Click);
            // 
            // записьНаКурсToolStripMenuItem
            // 
            this.записьНаКурсToolStripMenuItem.Name = "записьНаКурсToolStripMenuItem";
            this.записьНаКурсToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.записьНаКурсToolStripMenuItem.Text = "Запись на курс";
            this.записьНаКурсToolStripMenuItem.Click += new System.EventHandler(this.записьНаКурсToolStripMenuItem_Click);
            // 
            // преподавательToolStripMenuItem
            // 
            this.преподавательToolStripMenuItem.Name = "преподавательToolStripMenuItem";
            this.преподавательToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.преподавательToolStripMenuItem.Text = "Преподаватель";
            this.преподавательToolStripMenuItem.Click += new System.EventHandler(this.преподавательToolStripMenuItem_Click);
            // 
            // студентToolStripMenuItem
            // 
            this.студентToolStripMenuItem.Name = "студентToolStripMenuItem";
            this.студентToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.студентToolStripMenuItem.Text = "Студент";
            this.студентToolStripMenuItem.Click += new System.EventHandler(this.студентToolStripMenuItem_Click);
            // 
            // успеваемостьToolStripMenuItem
            // 
            this.успеваемостьToolStripMenuItem.Name = "успеваемостьToolStripMenuItem";
            this.успеваемостьToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.успеваемостьToolStripMenuItem.Text = "Успеваемость";
            this.успеваемостьToolStripMenuItem.Click += new System.EventHandler(this.успеваемостьToolStripMenuItem_Click);
            // 
            // оценкиToolStripMenuItem
            // 
            this.оценкиToolStripMenuItem.Name = "оценкиToolStripMenuItem";
            this.оценкиToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.оценкиToolStripMenuItem.Text = "Оценки";
            this.оценкиToolStripMenuItem.Click += new System.EventHandler(this.оценкиToolStripMenuItem_Click);
            // 
            // dataGridViewExamen
            // 
            this.dataGridViewExamen.AutoGenerateColumns = false;
            this.dataGridViewExamen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExamen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDExamenDataGridViewTextBoxColumn,
            this.dataexamenaDataGridViewTextBoxColumn,
            this.kursIDDataGridViewTextBoxColumn,
            this.studentIDDataGridViewTextBoxColumn});
            this.dataGridViewExamen.DataSource = this.examenBindingSource1;
            this.dataGridViewExamen.Location = new System.Drawing.Point(28, 79);
            this.dataGridViewExamen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewExamen.Name = "dataGridViewExamen";
            this.dataGridViewExamen.RowHeadersWidth = 51;
            this.dataGridViewExamen.Size = new System.Drawing.Size(599, 261);
            this.dataGridViewExamen.TabIndex = 1;
            // 
            // iDExamenDataGridViewTextBoxColumn
            // 
            this.iDExamenDataGridViewTextBoxColumn.DataPropertyName = "ID_Examen";
            this.iDExamenDataGridViewTextBoxColumn.HeaderText = "ID_Examen";
            this.iDExamenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDExamenDataGridViewTextBoxColumn.Name = "iDExamenDataGridViewTextBoxColumn";
            this.iDExamenDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataexamenaDataGridViewTextBoxColumn
            // 
            this.dataexamenaDataGridViewTextBoxColumn.DataPropertyName = "Data_examena";
            this.dataexamenaDataGridViewTextBoxColumn.HeaderText = "Data_examena";
            this.dataexamenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataexamenaDataGridViewTextBoxColumn.Name = "dataexamenaDataGridViewTextBoxColumn";
            this.dataexamenaDataGridViewTextBoxColumn.Width = 125;
            // 
            // kursIDDataGridViewTextBoxColumn
            // 
            this.kursIDDataGridViewTextBoxColumn.DataPropertyName = "Kurs_ID";
            this.kursIDDataGridViewTextBoxColumn.HeaderText = "Kurs_ID";
            this.kursIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kursIDDataGridViewTextBoxColumn.Name = "kursIDDataGridViewTextBoxColumn";
            this.kursIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "Student_ID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "Student_ID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // examenBindingSource
            // 
            this.examenBindingSource.DataMember = "Examen";
            this.examenBindingSource.DataSource = this.uchebnye_kursiDataSet27;
            // 
            // uchebnye_kursiDataSet27
            // 
            this.uchebnye_kursiDataSet27.DataSetName = "Uchebnye_kursiDataSet27";
            this.uchebnye_kursiDataSet27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 401);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 401);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 52);
            this.button2.TabIndex = 3;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(503, 401);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 52);
            this.button3.TabIndex = 4;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbDelExamen
            // 
            this.tbDelExamen.Location = new System.Drawing.Point(687, 222);
            this.tbDelExamen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDelExamen.Name = "tbDelExamen";
            this.tbDelExamen.Size = new System.Drawing.Size(132, 22);
            this.tbDelExamen.TabIndex = 5;
            // 
            // examenTableAdapter
            // 
            this.examenTableAdapter.ClearBeforeFill = true;
            // 
            // uchebnye_kursiDataSet38
            // 
            this.uchebnye_kursiDataSet38.DataSetName = "Uchebnye_kursiDataSet38";
            this.uchebnye_kursiDataSet38.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examenBindingSource1
            // 
            this.examenBindingSource1.DataMember = "Examen";
            this.examenBindingSource1.DataSource = this.uchebnye_kursiDataSet38;
            // 
            // examenTableAdapter1
            // 
            this.examenTableAdapter1.ClearBeforeFill = true;
            // 
            // FormExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 487);
            this.Controls.Add(this.tbDelExamen);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewExamen);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormExamen";
            this.Text = "Экзамены";
            this.Load += new System.EventHandler(this.FormExamen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExamen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem курсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записьНаКурсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem преподавательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem успеваемостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оценкиToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbDelExamen;
        private Uchebnye_kursiDataSet27 uchebnye_kursiDataSet27;
        private System.Windows.Forms.BindingSource examenBindingSource;
        private Uchebnye_kursiDataSet27TableAdapters.ExamenTableAdapter examenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDExamenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataexamenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kursIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridViewExamen;
        private Uchebnye_kursiDataSet38 uchebnye_kursiDataSet38;
        private System.Windows.Forms.BindingSource examenBindingSource1;
        private Uchebnye_kursiDataSet38TableAdapters.ExamenTableAdapter examenTableAdapter1;
    }
}