namespace Kyrsovaya
{
    partial class FormOchenki
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
            this.dataGridViewOchenki = new System.Windows.Forms.DataGridView();
            this.iDOchenkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ochenkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examenIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ochenkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchebnye_kursiDataSet23 = new Kyrsovaya.Uchebnye_kursiDataSet23();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.курсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.записьНаКурсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.преподавательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.успеваемостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экзаменToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbDelOchenki = new System.Windows.Forms.TextBox();
            this.ochenkiTableAdapter = new Kyrsovaya.Uchebnye_kursiDataSet23TableAdapters.OchenkiTableAdapter();
            this.uchebnye_kursiDataSet37 = new Kyrsovaya.Uchebnye_kursiDataSet37();
            this.ochenkiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ochenkiTableAdapter1 = new Kyrsovaya.Uchebnye_kursiDataSet37TableAdapters.OchenkiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOchenki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ochenkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet23)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ochenkiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOchenki
            // 
            this.dataGridViewOchenki.AutoGenerateColumns = false;
            this.dataGridViewOchenki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOchenki.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDOchenkiDataGridViewTextBoxColumn,
            this.ochenkaDataGridViewTextBoxColumn,
            this.examenIDDataGridViewTextBoxColumn});
            this.dataGridViewOchenki.DataSource = this.ochenkiBindingSource1;
            this.dataGridViewOchenki.Location = new System.Drawing.Point(36, 78);
            this.dataGridViewOchenki.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewOchenki.Name = "dataGridViewOchenki";
            this.dataGridViewOchenki.RowHeadersWidth = 51;
            this.dataGridViewOchenki.Size = new System.Drawing.Size(469, 244);
            this.dataGridViewOchenki.TabIndex = 0;
            // 
            // iDOchenkiDataGridViewTextBoxColumn
            // 
            this.iDOchenkiDataGridViewTextBoxColumn.DataPropertyName = "ID_Ochenki";
            this.iDOchenkiDataGridViewTextBoxColumn.HeaderText = "ID_Ochenki";
            this.iDOchenkiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDOchenkiDataGridViewTextBoxColumn.Name = "iDOchenkiDataGridViewTextBoxColumn";
            this.iDOchenkiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ochenkaDataGridViewTextBoxColumn
            // 
            this.ochenkaDataGridViewTextBoxColumn.DataPropertyName = "Ochenka";
            this.ochenkaDataGridViewTextBoxColumn.HeaderText = "Ochenka";
            this.ochenkaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ochenkaDataGridViewTextBoxColumn.Name = "ochenkaDataGridViewTextBoxColumn";
            this.ochenkaDataGridViewTextBoxColumn.Width = 125;
            // 
            // examenIDDataGridViewTextBoxColumn
            // 
            this.examenIDDataGridViewTextBoxColumn.DataPropertyName = "Examen_ID";
            this.examenIDDataGridViewTextBoxColumn.HeaderText = "Examen_ID";
            this.examenIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.examenIDDataGridViewTextBoxColumn.Name = "examenIDDataGridViewTextBoxColumn";
            this.examenIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ochenkiBindingSource
            // 
            this.ochenkiBindingSource.DataMember = "Ochenki";
            this.ochenkiBindingSource.DataSource = this.uchebnye_kursiDataSet23;
            // 
            // uchebnye_kursiDataSet23
            // 
            this.uchebnye_kursiDataSet23.DataSetName = "Uchebnye_kursiDataSet23";
            this.uchebnye_kursiDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 378);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(208, 379);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(379, 378);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 43);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.таблицыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(548, 28);
            this.menuStrip1.TabIndex = 4;
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
            this.экзаменToolStripMenuItem});
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
            // экзаменToolStripMenuItem
            // 
            this.экзаменToolStripMenuItem.Name = "экзаменToolStripMenuItem";
            this.экзаменToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.экзаменToolStripMenuItem.Text = "Экзамен";
            this.экзаменToolStripMenuItem.Click += new System.EventHandler(this.экзаменToolStripMenuItem_Click);
            // 
            // tbDelOchenki
            // 
            this.tbDelOchenki.Location = new System.Drawing.Point(620, 215);
            this.tbDelOchenki.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDelOchenki.Name = "tbDelOchenki";
            this.tbDelOchenki.Size = new System.Drawing.Size(132, 22);
            this.tbDelOchenki.TabIndex = 5;
            // 
            // ochenkiTableAdapter
            // 
            this.ochenkiTableAdapter.ClearBeforeFill = true;
            // 
            // uchebnye_kursiDataSet37
            // 
            this.uchebnye_kursiDataSet37.DataSetName = "Uchebnye_kursiDataSet37";
            this.uchebnye_kursiDataSet37.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ochenkiBindingSource1
            // 
            this.ochenkiBindingSource1.DataMember = "Ochenki";
            this.ochenkiBindingSource1.DataSource = this.uchebnye_kursiDataSet37;
            // 
            // ochenkiTableAdapter1
            // 
            this.ochenkiTableAdapter1.ClearBeforeFill = true;
            // 
            // FormOchenki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 457);
            this.Controls.Add(this.tbDelOchenki);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewOchenki);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormOchenki";
            this.Text = "Оценки";
            this.Load += new System.EventHandler(this.FormOchenki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOchenki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ochenkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet23)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ochenkiBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem курсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem записьНаКурсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem преподавательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem успеваемостьToolStripMenuItem;
        private System.Windows.Forms.TextBox tbDelOchenki;
        private System.Windows.Forms.ToolStripMenuItem экзаменToolStripMenuItem;
        private Uchebnye_kursiDataSet23 uchebnye_kursiDataSet23;
        private System.Windows.Forms.BindingSource ochenkiBindingSource;
        private Uchebnye_kursiDataSet23TableAdapters.OchenkiTableAdapter ochenkiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDOchenkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ochenkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn examenIDDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridViewOchenki;
        private Uchebnye_kursiDataSet37 uchebnye_kursiDataSet37;
        private System.Windows.Forms.BindingSource ochenkiBindingSource1;
        private Uchebnye_kursiDataSet37TableAdapters.OchenkiTableAdapter ochenkiTableAdapter1;
    }
}