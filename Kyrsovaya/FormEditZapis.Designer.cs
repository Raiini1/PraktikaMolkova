namespace Kyrsovaya
{
    partial class FormEditZapis
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_kurs = new System.Windows.Forms.ComboBox();
            this.kursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchebnye_kursiDataSet7 = new Kyrsovaya.Uchebnye_kursiDataSet7();
            this.cb_student = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchebnye_kursiDataSet6 = new Kyrsovaya.Uchebnye_kursiDataSet6();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lb_kurs = new System.Windows.Forms.Label();
            this.lb_student = new System.Windows.Forms.Label();
            this.lb_data = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.studentTableAdapter = new Kyrsovaya.Uchebnye_kursiDataSet6TableAdapters.StudentTableAdapter();
            this.kursTableAdapter = new Kyrsovaya.Uchebnye_kursiDataSet7TableAdapters.KursTableAdapter();
            this.uchebnye_kursiDataSet48 = new Kyrsovaya.Uchebnye_kursiDataSet48();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter1 = new Kyrsovaya.Uchebnye_kursiDataSet48TableAdapters.StudentTableAdapter();
            this.uchebnye_kursiDataSet49 = new Kyrsovaya.Uchebnye_kursiDataSet49();
            this.kursBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kursTableAdapter1 = new Kyrsovaya.Uchebnye_kursiDataSet49TableAdapters.KursTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(285, 311);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 52);
            this.button2.TabIndex = 19;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 311);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 52);
            this.button1.TabIndex = 18;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_kurs
            // 
            this.cb_kurs.DataSource = this.kursBindingSource1;
            this.cb_kurs.DisplayMember = "Nazvanie_kursa";
            this.cb_kurs.FormattingEnabled = true;
            this.cb_kurs.Location = new System.Drawing.Point(263, 223);
            this.cb_kurs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_kurs.Name = "cb_kurs";
            this.cb_kurs.Size = new System.Drawing.Size(160, 24);
            this.cb_kurs.TabIndex = 17;
            this.cb_kurs.ValueMember = "ID_Kurs";
            // 
            // kursBindingSource
            // 
            this.kursBindingSource.DataMember = "Kurs";
            this.kursBindingSource.DataSource = this.uchebnye_kursiDataSet7;
            // 
            // uchebnye_kursiDataSet7
            // 
            this.uchebnye_kursiDataSet7.DataSetName = "Uchebnye_kursiDataSet7";
            this.uchebnye_kursiDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cb_student
            // 
            this.cb_student.DataSource = this.studentBindingSource1;
            this.cb_student.DisplayMember = "Familia";
            this.cb_student.FormattingEnabled = true;
            this.cb_student.Location = new System.Drawing.Point(263, 167);
            this.cb_student.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_student.Name = "cb_student";
            this.cb_student.Size = new System.Drawing.Size(160, 24);
            this.cb_student.TabIndex = 16;
            this.cb_student.ValueMember = "ID_Student";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.uchebnye_kursiDataSet6;
            // 
            // uchebnye_kursiDataSet6
            // 
            this.uchebnye_kursiDataSet6.DataSetName = "Uchebnye_kursiDataSet6";
            this.uchebnye_kursiDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(263, 102);
            this.tb_data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(160, 22);
            this.tb_data.TabIndex = 15;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(263, 50);
            this.tbID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(160, 22);
            this.tbID.TabIndex = 14;
            // 
            // lb_kurs
            // 
            this.lb_kurs.AutoSize = true;
            this.lb_kurs.Location = new System.Drawing.Point(109, 222);
            this.lb_kurs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_kurs.Name = "lb_kurs";
            this.lb_kurs.Size = new System.Drawing.Size(38, 16);
            this.lb_kurs.TabIndex = 13;
            this.lb_kurs.Text = "Курс";
            // 
            // lb_student
            // 
            this.lb_student.AutoSize = true;
            this.lb_student.Location = new System.Drawing.Point(100, 167);
            this.lb_student.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_student.Name = "lb_student";
            this.lb_student.Size = new System.Drawing.Size(62, 16);
            this.lb_student.TabIndex = 12;
            this.lb_student.Text = "Студент";
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.Location = new System.Drawing.Point(87, 102);
            this.lb_data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(89, 16);
            this.lb_data.TabIndex = 11;
            this.lb_data.Text = "Дата записи";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(121, 50);
            this.lbID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 16);
            this.lbID.TabIndex = 10;
            this.lbID.Text = "№";
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // kursTableAdapter
            // 
            this.kursTableAdapter.ClearBeforeFill = true;
            // 
            // uchebnye_kursiDataSet48
            // 
            this.uchebnye_kursiDataSet48.DataSetName = "Uchebnye_kursiDataSet48";
            this.uchebnye_kursiDataSet48.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "Student";
            this.studentBindingSource1.DataSource = this.uchebnye_kursiDataSet48;
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // uchebnye_kursiDataSet49
            // 
            this.uchebnye_kursiDataSet49.DataSetName = "Uchebnye_kursiDataSet49";
            this.uchebnye_kursiDataSet49.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kursBindingSource1
            // 
            this.kursBindingSource1.DataMember = "Kurs";
            this.kursBindingSource1.DataSource = this.uchebnye_kursiDataSet49;
            // 
            // kursTableAdapter1
            // 
            this.kursTableAdapter1.ClearBeforeFill = true;
            // 
            // FormEditZapis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 401);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_kurs);
            this.Controls.Add(this.cb_student);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lb_kurs);
            this.Controls.Add(this.lb_student);
            this.Controls.Add(this.lb_data);
            this.Controls.Add(this.lbID);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEditZapis";
            this.Text = "Редактировать запись на курс";
            this.Load += new System.EventHandler(this.FormEditZapis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_kurs;
        private System.Windows.Forms.ComboBox cb_student;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lb_kurs;
        private System.Windows.Forms.Label lb_student;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.Label lbID;
        private Uchebnye_kursiDataSet6 uchebnye_kursiDataSet6;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private Uchebnye_kursiDataSet6TableAdapters.StudentTableAdapter studentTableAdapter;
        private Uchebnye_kursiDataSet7 uchebnye_kursiDataSet7;
        private System.Windows.Forms.BindingSource kursBindingSource;
        private Uchebnye_kursiDataSet7TableAdapters.KursTableAdapter kursTableAdapter;
        private Uchebnye_kursiDataSet48 uchebnye_kursiDataSet48;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private Uchebnye_kursiDataSet48TableAdapters.StudentTableAdapter studentTableAdapter1;
        private Uchebnye_kursiDataSet49 uchebnye_kursiDataSet49;
        private System.Windows.Forms.BindingSource kursBindingSource1;
        private Uchebnye_kursiDataSet49TableAdapters.KursTableAdapter kursTableAdapter1;
    }
}