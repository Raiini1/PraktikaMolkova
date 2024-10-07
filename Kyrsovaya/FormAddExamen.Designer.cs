namespace Kyrsovaya
{
    partial class FormAddExamen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.cb_kurs = new System.Windows.Forms.ComboBox();
            this.kursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchebnye_kursiDataSet28 = new Kyrsovaya.Uchebnye_kursiDataSet28();
            this.cb_student = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchebnye_kursiDataSet29 = new Kyrsovaya.Uchebnye_kursiDataSet29();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.kursTableAdapter = new Kyrsovaya.Uchebnye_kursiDataSet28TableAdapters.KursTableAdapter();
            this.studentTableAdapter = new Kyrsovaya.Uchebnye_kursiDataSet29TableAdapters.StudentTableAdapter();
            this.uchebnye_kursiDataSet52 = new Kyrsovaya.Uchebnye_kursiDataSet52();
            this.kursBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kursTableAdapter1 = new Kyrsovaya.Uchebnye_kursiDataSet52TableAdapters.KursTableAdapter();
            this.uchebnye_kursiDataSet53 = new Kyrsovaya.Uchebnye_kursiDataSet53();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter1 = new Kyrsovaya.Uchebnye_kursiDataSet53TableAdapters.StudentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet53)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "№";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата записи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Курс";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Студент";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(185, 48);
            this.tbID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(160, 22);
            this.tbID.TabIndex = 4;
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(185, 105);
            this.tb_data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(160, 22);
            this.tb_data.TabIndex = 5;
            // 
            // cb_kurs
            // 
            this.cb_kurs.DataSource = this.kursBindingSource1;
            this.cb_kurs.DisplayMember = "Nazvanie_kursa";
            this.cb_kurs.FormattingEnabled = true;
            this.cb_kurs.Location = new System.Drawing.Point(185, 166);
            this.cb_kurs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_kurs.Name = "cb_kurs";
            this.cb_kurs.Size = new System.Drawing.Size(160, 24);
            this.cb_kurs.TabIndex = 6;
            this.cb_kurs.ValueMember = "ID_Kurs";
            // 
            // kursBindingSource
            // 
            this.kursBindingSource.DataMember = "Kurs";
            this.kursBindingSource.DataSource = this.uchebnye_kursiDataSet28;
            // 
            // uchebnye_kursiDataSet28
            // 
            this.uchebnye_kursiDataSet28.DataSetName = "Uchebnye_kursiDataSet28";
            this.uchebnye_kursiDataSet28.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cb_student
            // 
            this.cb_student.DataSource = this.studentBindingSource1;
            this.cb_student.DisplayMember = "Familia";
            this.cb_student.FormattingEnabled = true;
            this.cb_student.Location = new System.Drawing.Point(185, 228);
            this.cb_student.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_student.Name = "cb_student";
            this.cb_student.Size = new System.Drawing.Size(160, 24);
            this.cb_student.TabIndex = 7;
            this.cb_student.ValueMember = "ID_Student";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.uchebnye_kursiDataSet29;
            // 
            // uchebnye_kursiDataSet29
            // 
            this.uchebnye_kursiDataSet29.DataSetName = "Uchebnye_kursiDataSet29";
            this.uchebnye_kursiDataSet29.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 319);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 319);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 48);
            this.button2.TabIndex = 9;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kursTableAdapter
            // 
            this.kursTableAdapter.ClearBeforeFill = true;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // uchebnye_kursiDataSet52
            // 
            this.uchebnye_kursiDataSet52.DataSetName = "Uchebnye_kursiDataSet52";
            this.uchebnye_kursiDataSet52.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kursBindingSource1
            // 
            this.kursBindingSource1.DataMember = "Kurs";
            this.kursBindingSource1.DataSource = this.uchebnye_kursiDataSet52;
            // 
            // kursTableAdapter1
            // 
            this.kursTableAdapter1.ClearBeforeFill = true;
            // 
            // uchebnye_kursiDataSet53
            // 
            this.uchebnye_kursiDataSet53.DataSetName = "Uchebnye_kursiDataSet53";
            this.uchebnye_kursiDataSet53.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "Student";
            this.studentBindingSource1.DataSource = this.uchebnye_kursiDataSet53;
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // FormAddExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 407);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_student);
            this.Controls.Add(this.cb_kurs);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAddExamen";
            this.Text = "Добавить экзамен";
            this.Load += new System.EventHandler(this.FormAddExamen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet53)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.ComboBox cb_kurs;
        private System.Windows.Forms.ComboBox cb_student;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Uchebnye_kursiDataSet28 uchebnye_kursiDataSet28;
        private System.Windows.Forms.BindingSource kursBindingSource;
        private Uchebnye_kursiDataSet28TableAdapters.KursTableAdapter kursTableAdapter;
        private Uchebnye_kursiDataSet29 uchebnye_kursiDataSet29;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private Uchebnye_kursiDataSet29TableAdapters.StudentTableAdapter studentTableAdapter;
        private Uchebnye_kursiDataSet52 uchebnye_kursiDataSet52;
        private System.Windows.Forms.BindingSource kursBindingSource1;
        private Uchebnye_kursiDataSet52TableAdapters.KursTableAdapter kursTableAdapter1;
        private Uchebnye_kursiDataSet53 uchebnye_kursiDataSet53;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private Uchebnye_kursiDataSet53TableAdapters.StudentTableAdapter studentTableAdapter1;
    }
}