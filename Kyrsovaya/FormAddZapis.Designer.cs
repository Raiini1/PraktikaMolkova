namespace Kyrsovaya
{
    partial class FormAddZapis
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
            this.lbID = new System.Windows.Forms.Label();
            this.lb_data = new System.Windows.Forms.Label();
            this.lb_student = new System.Windows.Forms.Label();
            this.lb_kurs = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.cb_student = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchebnye_kursiDataSet4 = new Kyrsovaya.Uchebnye_kursiDataSet4();
            this.cb_kurs = new System.Windows.Forms.ComboBox();
            this.kursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchebnye_kursiDataSet5 = new Kyrsovaya.Uchebnye_kursiDataSet5();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.studentTableAdapter = new Kyrsovaya.Uchebnye_kursiDataSet4TableAdapters.StudentTableAdapter();
            this.kursTableAdapter = new Kyrsovaya.Uchebnye_kursiDataSet5TableAdapters.KursTableAdapter();
            this.uchebnye_kursiDataSet46 = new Kyrsovaya.Uchebnye_kursiDataSet46();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter1 = new Kyrsovaya.Uchebnye_kursiDataSet46TableAdapters.StudentTableAdapter();
            this.uchebnye_kursiDataSet47 = new Kyrsovaya.Uchebnye_kursiDataSet47();
            this.kursBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kursTableAdapter1 = new Kyrsovaya.Uchebnye_kursiDataSet47TableAdapters.KursTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(109, 65);
            this.lbID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 16);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "№";
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.Location = new System.Drawing.Point(75, 117);
            this.lb_data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(89, 16);
            this.lb_data.TabIndex = 1;
            this.lb_data.Text = "Дата записи";
            // 
            // lb_student
            // 
            this.lb_student.AutoSize = true;
            this.lb_student.Location = new System.Drawing.Point(88, 182);
            this.lb_student.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_student.Name = "lb_student";
            this.lb_student.Size = new System.Drawing.Size(62, 16);
            this.lb_student.TabIndex = 2;
            this.lb_student.Text = "Студент";
            // 
            // lb_kurs
            // 
            this.lb_kurs.AutoSize = true;
            this.lb_kurs.Location = new System.Drawing.Point(99, 235);
            this.lb_kurs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_kurs.Name = "lb_kurs";
            this.lb_kurs.Size = new System.Drawing.Size(38, 16);
            this.lb_kurs.TabIndex = 3;
            this.lb_kurs.Text = "Курс";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(251, 65);
            this.tbID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(160, 22);
            this.tbID.TabIndex = 4;
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(251, 117);
            this.tb_data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(160, 22);
            this.tb_data.TabIndex = 5;
            // 
            // cb_student
            // 
            this.cb_student.DataSource = this.studentBindingSource1;
            this.cb_student.DisplayMember = "Familia";
            this.cb_student.FormattingEnabled = true;
            this.cb_student.Location = new System.Drawing.Point(251, 182);
            this.cb_student.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_student.Name = "cb_student";
            this.cb_student.Size = new System.Drawing.Size(160, 24);
            this.cb_student.TabIndex = 6;
            this.cb_student.ValueMember = "ID_Student";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.uchebnye_kursiDataSet4;
            // 
            // uchebnye_kursiDataSet4
            // 
            this.uchebnye_kursiDataSet4.DataSetName = "Uchebnye_kursiDataSet4";
            this.uchebnye_kursiDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cb_kurs
            // 
            this.cb_kurs.DataSource = this.kursBindingSource1;
            this.cb_kurs.DisplayMember = "Nazvanie_kursa";
            this.cb_kurs.FormattingEnabled = true;
            this.cb_kurs.Location = new System.Drawing.Point(251, 238);
            this.cb_kurs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_kurs.Name = "cb_kurs";
            this.cb_kurs.Size = new System.Drawing.Size(160, 24);
            this.cb_kurs.TabIndex = 7;
            this.cb_kurs.ValueMember = "ID_Kurs";
            // 
            // kursBindingSource
            // 
            this.kursBindingSource.DataMember = "Kurs";
            this.kursBindingSource.DataSource = this.uchebnye_kursiDataSet5;
            // 
            // uchebnye_kursiDataSet5
            // 
            this.uchebnye_kursiDataSet5.DataSetName = "Uchebnye_kursiDataSet5";
            this.uchebnye_kursiDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 326);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 52);
            this.button1.TabIndex = 8;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(273, 326);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 52);
            this.button2.TabIndex = 9;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // kursTableAdapter
            // 
            this.kursTableAdapter.ClearBeforeFill = true;
            // 
            // uchebnye_kursiDataSet46
            // 
            this.uchebnye_kursiDataSet46.DataSetName = "Uchebnye_kursiDataSet46";
            this.uchebnye_kursiDataSet46.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "Student";
            this.studentBindingSource1.DataSource = this.uchebnye_kursiDataSet46;
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // uchebnye_kursiDataSet47
            // 
            this.uchebnye_kursiDataSet47.DataSetName = "Uchebnye_kursiDataSet47";
            this.uchebnye_kursiDataSet47.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kursBindingSource1
            // 
            this.kursBindingSource1.DataMember = "Kurs";
            this.kursBindingSource1.DataSource = this.uchebnye_kursiDataSet47;
            // 
            // kursTableAdapter1
            // 
            this.kursTableAdapter1.ClearBeforeFill = true;
            // 
            // FormAddZapis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 415);
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
            this.Name = "FormAddZapis";
            this.Text = "Добавить запись на курс";
            this.Load += new System.EventHandler(this.FormAddZapis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.Label lb_student;
        private System.Windows.Forms.Label lb_kurs;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.ComboBox cb_student;
        private System.Windows.Forms.ComboBox cb_kurs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Uchebnye_kursiDataSet4 uchebnye_kursiDataSet4;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private Uchebnye_kursiDataSet4TableAdapters.StudentTableAdapter studentTableAdapter;
        private Uchebnye_kursiDataSet5 uchebnye_kursiDataSet5;
        private System.Windows.Forms.BindingSource kursBindingSource;
        private Uchebnye_kursiDataSet5TableAdapters.KursTableAdapter kursTableAdapter;
        private Uchebnye_kursiDataSet46 uchebnye_kursiDataSet46;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private Uchebnye_kursiDataSet46TableAdapters.StudentTableAdapter studentTableAdapter1;
        private Uchebnye_kursiDataSet47 uchebnye_kursiDataSet47;
        private System.Windows.Forms.BindingSource kursBindingSource1;
        private Uchebnye_kursiDataSet47TableAdapters.KursTableAdapter kursTableAdapter1;
    }
}