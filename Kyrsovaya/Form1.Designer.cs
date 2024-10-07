namespace Kyrsovaya
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
            this.dataGridViewKurs = new System.Windows.Forms.DataGridView();
            this.kursBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uchebnye_kursiDataSet10 = new Kyrsovaya.Uchebnye_kursiDataSet10();
            this.kursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchebnye_kursiDataSet = new Kyrsovaya.Uchebnye_kursiDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.преподавателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентыToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.успеваемостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оценкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экзаменыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kursTableAdapter = new Kyrsovaya.Uchebnye_kursiDataSetTableAdapters.KursTableAdapter();
            this.tbDelKurs = new System.Windows.Forms.TextBox();
            this.kursTableAdapter1 = new Kyrsovaya.Uchebnye_kursiDataSet10TableAdapters.KursTableAdapter();
            this.uchebnye_kursiDataSet32 = new Kyrsovaya.Uchebnye_kursiDataSet32();
            this.kursBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kursTableAdapter2 = new Kyrsovaya.Uchebnye_kursiDataSet32TableAdapters.KursTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKurs
            // 
            this.dataGridViewKurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKurs.Location = new System.Drawing.Point(16, 44);
            this.dataGridViewKurs.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewKurs.Name = "dataGridViewKurs";
            this.dataGridViewKurs.RowHeadersWidth = 51;
            this.dataGridViewKurs.Size = new System.Drawing.Size(1141, 354);
            this.dataGridViewKurs.TabIndex = 0;
            // 
            // kursBindingSource1
            // 
            this.kursBindingSource1.DataMember = "Kurs";
            this.kursBindingSource1.DataSource = this.uchebnye_kursiDataSet10;
            // 
            // uchebnye_kursiDataSet10
            // 
            this.uchebnye_kursiDataSet10.DataSetName = "Uchebnye_kursiDataSet10";
            this.uchebnye_kursiDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kursBindingSource
            // 
            this.kursBindingSource.DataMember = "Kurs";
            this.kursBindingSource.DataSource = this.uchebnye_kursiDataSet;
            // 
            // uchebnye_kursiDataSet
            // 
            this.uchebnye_kursiDataSet.DataSetName = "Uchebnye_kursiDataSet";
            this.uchebnye_kursiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 428);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(519, 428);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(872, 428);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 52);
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
            this.menuStrip1.Size = new System.Drawing.Size(1189, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.студентыToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // студентыToolStripMenuItem
            // 
            this.студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
            this.студентыToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.студентыToolStripMenuItem.Text = "Выход";
            this.студентыToolStripMenuItem.Click += new System.EventHandler(this.студентыToolStripMenuItem_Click);
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.студентыToolStripMenuItem1,
            this.преподавателиToolStripMenuItem,
            this.студентыToolStripMenuItem2});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // студентыToolStripMenuItem1
            // 
            this.студентыToolStripMenuItem1.Name = "студентыToolStripMenuItem1";
            this.студентыToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.студентыToolStripMenuItem1.Text = "Запись на курс";
            this.студентыToolStripMenuItem1.Click += new System.EventHandler(this.студентыToolStripMenuItem1_Click);
            // 
            // преподавателиToolStripMenuItem
            // 
            this.преподавателиToolStripMenuItem.Name = "преподавателиToolStripMenuItem";
            this.преподавателиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.преподавателиToolStripMenuItem.Text = "Преподаватели";
            this.преподавателиToolStripMenuItem.Click += new System.EventHandler(this.преподавателиToolStripMenuItem_Click);
            // 
            // студентыToolStripMenuItem2
            // 
            this.студентыToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.успеваемостьToolStripMenuItem,
            this.оценкиToolStripMenuItem,
            this.экзаменыToolStripMenuItem});
            this.студентыToolStripMenuItem2.Name = "студентыToolStripMenuItem2";
            this.студентыToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.студентыToolStripMenuItem2.Text = "Студенты";
            this.студентыToolStripMenuItem2.Click += new System.EventHandler(this.студентыToolStripMenuItem2_Click);
            // 
            // успеваемостьToolStripMenuItem
            // 
            this.успеваемостьToolStripMenuItem.Name = "успеваемостьToolStripMenuItem";
            this.успеваемостьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.успеваемостьToolStripMenuItem.Text = "Успеваемость";
            this.успеваемостьToolStripMenuItem.Click += new System.EventHandler(this.успеваемостьToolStripMenuItem_Click);
            // 
            // оценкиToolStripMenuItem
            // 
            this.оценкиToolStripMenuItem.Name = "оценкиToolStripMenuItem";
            this.оценкиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            // kursTableAdapter
            // 
            this.kursTableAdapter.ClearBeforeFill = true;
            // 
            // tbDelKurs
            // 
            this.tbDelKurs.Location = new System.Drawing.Point(1315, 226);
            this.tbDelKurs.Margin = new System.Windows.Forms.Padding(4);
            this.tbDelKurs.Name = "tbDelKurs";
            this.tbDelKurs.Size = new System.Drawing.Size(132, 22);
            this.tbDelKurs.TabIndex = 5;
            // 
            // kursTableAdapter1
            // 
            this.kursTableAdapter1.ClearBeforeFill = true;
            // 
            // uchebnye_kursiDataSet32
            // 
            this.uchebnye_kursiDataSet32.DataSetName = "Uchebnye_kursiDataSet32";
            this.uchebnye_kursiDataSet32.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kursBindingSource2
            // 
            this.kursBindingSource2.DataMember = "Kurs";
            this.kursBindingSource2.DataSource = this.uchebnye_kursiDataSet32;
            // 
            // kursTableAdapter2
            // 
            this.kursTableAdapter2.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 511);
            this.Controls.Add(this.tbDelKurs);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewKurs);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Курсы";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem преподавателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентыToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem успеваемостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оценкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экзаменыToolStripMenuItem;
        private Uchebnye_kursiDataSet uchebnye_kursiDataSet;
        private System.Windows.Forms.BindingSource kursBindingSource;
        private Uchebnye_kursiDataSetTableAdapters.KursTableAdapter kursTableAdapter;
        public System.Windows.Forms.DataGridView dataGridViewKurs;
        private System.Windows.Forms.TextBox tbDelKurs;
        private Uchebnye_kursiDataSet10 uchebnye_kursiDataSet10;
        private System.Windows.Forms.BindingSource kursBindingSource1;
        private Uchebnye_kursiDataSet10TableAdapters.KursTableAdapter kursTableAdapter1;
        private Uchebnye_kursiDataSet32 uchebnye_kursiDataSet32;
        private System.Windows.Forms.BindingSource kursBindingSource2;
        private Uchebnye_kursiDataSet32TableAdapters.KursTableAdapter kursTableAdapter2;
    }
}

