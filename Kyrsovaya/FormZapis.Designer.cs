namespace Kyrsovaya
{
    partial class FormZapis
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
            this.dataGridViewZapis = new System.Windows.Forms.DataGridView();
            this.zapisnakursBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uchebnye_kursiDataSet3 = new Kyrsovaya.Uchebnye_kursiDataSet3();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.курсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.преподавателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.успеваемостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оценкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экзаменыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbDelZapis = new System.Windows.Forms.TextBox();
            this.uchebnye_kursiDataSet2 = new Kyrsovaya.Uchebnye_kursiDataSet2();
            this.zapisnakursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zapis_na_kursTableAdapter = new Kyrsovaya.Uchebnye_kursiDataSet2TableAdapters.Zapis_na_kursTableAdapter();
            this.zapis_na_kursTableAdapter1 = new Kyrsovaya.Uchebnye_kursiDataSet3TableAdapters.Zapis_na_kursTableAdapter();
            this.uchebnye_kursiDataSet33 = new Kyrsovaya.Uchebnye_kursiDataSet33();
            this.zapisnakursBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.zapis_na_kursTableAdapter2 = new Kyrsovaya.Uchebnye_kursiDataSet33TableAdapters.Zapis_na_kursTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZapis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapisnakursBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapisnakursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapisnakursBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewZapis
            // 
            this.dataGridViewZapis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZapis.Location = new System.Drawing.Point(28, 62);
            this.dataGridViewZapis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewZapis.Name = "dataGridViewZapis";
            this.dataGridViewZapis.RowHeadersWidth = 51;
            this.dataGridViewZapis.Size = new System.Drawing.Size(531, 228);
            this.dataGridViewZapis.TabIndex = 0;
            // 
            // zapisnakursBindingSource1
            // 
            this.zapisnakursBindingSource1.DataMember = "Zapis_na_kurs";
            this.zapisnakursBindingSource1.DataSource = this.uchebnye_kursiDataSet3;
            // 
            // uchebnye_kursiDataSet3
            // 
            this.uchebnye_kursiDataSet3.DataSetName = "Uchebnye_kursiDataSet3";
            this.uchebnye_kursiDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.таблицыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(589, 30);
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
            this.преподавателиToolStripMenuItem,
            this.студентыToolStripMenuItem});
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
            // преподавателиToolStripMenuItem
            // 
            this.преподавателиToolStripMenuItem.Name = "преподавателиToolStripMenuItem";
            this.преподавателиToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.преподавателиToolStripMenuItem.Text = "Преподаватели";
            this.преподавателиToolStripMenuItem.Click += new System.EventHandler(this.преподавателиToolStripMenuItem_Click);
            // 
            // студентыToolStripMenuItem
            // 
            this.студентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.успеваемостьToolStripMenuItem,
            this.оценкиToolStripMenuItem,
            this.экзаменыToolStripMenuItem});
            this.студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
            this.студентыToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.студентыToolStripMenuItem.Text = "Студенты";
            this.студентыToolStripMenuItem.Click += new System.EventHandler(this.студентыToolStripMenuItem_Click);
            // 
            // успеваемостьToolStripMenuItem
            // 
            this.успеваемостьToolStripMenuItem.Name = "успеваемостьToolStripMenuItem";
            this.успеваемостьToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.успеваемостьToolStripMenuItem.Text = "Успеваемость";
            this.успеваемостьToolStripMenuItem.Click += new System.EventHandler(this.успеваемостьToolStripMenuItem_Click);
            // 
            // оценкиToolStripMenuItem
            // 
            this.оценкиToolStripMenuItem.Name = "оценкиToolStripMenuItem";
            this.оценкиToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.оценкиToolStripMenuItem.Text = "Оценки";
            this.оценкиToolStripMenuItem.Click += new System.EventHandler(this.оценкиToolStripMenuItem_Click);
            // 
            // экзаменыToolStripMenuItem
            // 
            this.экзаменыToolStripMenuItem.Name = "экзаменыToolStripMenuItem";
            this.экзаменыToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.экзаменыToolStripMenuItem.Text = "Экзамены";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 361);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(219, 361);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(412, 361);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 41);
            this.button3.TabIndex = 4;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbDelZapis
            // 
            this.tbDelZapis.Location = new System.Drawing.Point(656, 164);
            this.tbDelZapis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDelZapis.Name = "tbDelZapis";
            this.tbDelZapis.Size = new System.Drawing.Size(132, 22);
            this.tbDelZapis.TabIndex = 5;
            // 
            // uchebnye_kursiDataSet2
            // 
            this.uchebnye_kursiDataSet2.DataSetName = "Uchebnye_kursiDataSet2";
            this.uchebnye_kursiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zapisnakursBindingSource
            // 
            this.zapisnakursBindingSource.DataMember = "Zapis_na_kurs";
            this.zapisnakursBindingSource.DataSource = this.uchebnye_kursiDataSet2;
            // 
            // zapis_na_kursTableAdapter
            // 
            this.zapis_na_kursTableAdapter.ClearBeforeFill = true;
            // 
            // zapis_na_kursTableAdapter1
            // 
            this.zapis_na_kursTableAdapter1.ClearBeforeFill = true;
            // 
            // uchebnye_kursiDataSet33
            // 
            this.uchebnye_kursiDataSet33.DataSetName = "Uchebnye_kursiDataSet33";
            this.uchebnye_kursiDataSet33.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zapisnakursBindingSource2
            // 
            this.zapisnakursBindingSource2.DataMember = "Zapis_na_kurs";
            this.zapisnakursBindingSource2.DataSource = this.uchebnye_kursiDataSet33;
            // 
            // zapis_na_kursTableAdapter2
            // 
            this.zapis_na_kursTableAdapter2.ClearBeforeFill = true;
            // 
            // FormZapis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.tbDelZapis);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewZapis);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormZapis";
            this.Text = "Запись на курс";
            this.Load += new System.EventHandler(this.FormZapis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZapis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapisnakursBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapisnakursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zapisnakursBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem курсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem преподавателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem успеваемостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оценкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экзаменыToolStripMenuItem;
        private System.Windows.Forms.TextBox tbDelZapis;
        public System.Windows.Forms.DataGridView dataGridViewZapis;
        private Uchebnye_kursiDataSet2 uchebnye_kursiDataSet2;
        private System.Windows.Forms.BindingSource zapisnakursBindingSource;
        private Uchebnye_kursiDataSet2TableAdapters.Zapis_na_kursTableAdapter zapis_na_kursTableAdapter;
        private Uchebnye_kursiDataSet3 uchebnye_kursiDataSet3;
        private System.Windows.Forms.BindingSource zapisnakursBindingSource1;
        private Uchebnye_kursiDataSet3TableAdapters.Zapis_na_kursTableAdapter zapis_na_kursTableAdapter1;
        private Uchebnye_kursiDataSet33 uchebnye_kursiDataSet33;
        private System.Windows.Forms.BindingSource zapisnakursBindingSource2;
        private Uchebnye_kursiDataSet33TableAdapters.Zapis_na_kursTableAdapter zapis_na_kursTableAdapter2;
    }
}