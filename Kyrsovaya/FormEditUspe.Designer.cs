namespace Kyrsovaya
{
    partial class FormEditUspe
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
            this.cb_ochenki = new System.Windows.Forms.ComboBox();
            this.ochenkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchebnye_kursiDataSet22 = new Kyrsovaya.Uchebnye_kursiDataSet22();
            this.cb_student = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchebnye_kursiDataSet21 = new Kyrsovaya.Uchebnye_kursiDataSet21();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.studentTableAdapter = new Kyrsovaya.Uchebnye_kursiDataSet21TableAdapters.StudentTableAdapter();
            this.ochenkiTableAdapter = new Kyrsovaya.Uchebnye_kursiDataSet22TableAdapters.OchenkiTableAdapter();
            this.uchebnye_kursiDataSet43 = new Kyrsovaya.Uchebnye_kursiDataSet43();
            this.uspevaemostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uspevaemostTableAdapter = new Kyrsovaya.Uchebnye_kursiDataSet43TableAdapters.UspevaemostTableAdapter();
            this.uchebnye_kursiDataSet44 = new Kyrsovaya.Uchebnye_kursiDataSet44();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter1 = new Kyrsovaya.Uchebnye_kursiDataSet44TableAdapters.StudentTableAdapter();
            this.uchebnye_kursiDataSet45 = new Kyrsovaya.Uchebnye_kursiDataSet45();
            this.ochenkiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ochenkiTableAdapter1 = new Kyrsovaya.Uchebnye_kursiDataSet45TableAdapters.OchenkiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ochenkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspevaemostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ochenkiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_ochenki
            // 
            this.cb_ochenki.DataSource = this.ochenkiBindingSource1;
            this.cb_ochenki.DisplayMember = "Ochenka";
            this.cb_ochenki.FormattingEnabled = true;
            this.cb_ochenki.Location = new System.Drawing.Point(177, 161);
            this.cb_ochenki.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_ochenki.Name = "cb_ochenki";
            this.cb_ochenki.Size = new System.Drawing.Size(160, 24);
            this.cb_ochenki.TabIndex = 17;
            this.cb_ochenki.ValueMember = "ID_Ochenki";
            // 
            // ochenkiBindingSource
            // 
            this.ochenkiBindingSource.DataMember = "Ochenki";
            this.ochenkiBindingSource.DataSource = this.uchebnye_kursiDataSet22;
            // 
            // uchebnye_kursiDataSet22
            // 
            this.uchebnye_kursiDataSet22.DataSetName = "Uchebnye_kursiDataSet22";
            this.uchebnye_kursiDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cb_student
            // 
            this.cb_student.DataSource = this.studentBindingSource1;
            this.cb_student.DisplayMember = "Familia";
            this.cb_student.FormattingEnabled = true;
            this.cb_student.Location = new System.Drawing.Point(177, 94);
            this.cb_student.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_student.Name = "cb_student";
            this.cb_student.Size = new System.Drawing.Size(160, 24);
            this.cb_student.TabIndex = 16;
            this.cb_student.ValueMember = "ID_Student";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.uchebnye_kursiDataSet21;
            // 
            // uchebnye_kursiDataSet21
            // 
            this.uchebnye_kursiDataSet21.DataSetName = "Uchebnye_kursiDataSet21";
            this.uchebnye_kursiDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(208, 251);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 49);
            this.button2.TabIndex = 15;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 251);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 49);
            this.button1.TabIndex = 14;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(177, 33);
            this.tbID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(157, 22);
            this.tbID.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Оценки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Студент";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "№";
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // ochenkiTableAdapter
            // 
            this.ochenkiTableAdapter.ClearBeforeFill = true;
            // 
            // uchebnye_kursiDataSet43
            // 
            this.uchebnye_kursiDataSet43.DataSetName = "Uchebnye_kursiDataSet43";
            this.uchebnye_kursiDataSet43.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uspevaemostBindingSource
            // 
            this.uspevaemostBindingSource.DataMember = "Uspevaemost";
            this.uspevaemostBindingSource.DataSource = this.uchebnye_kursiDataSet43;
            // 
            // uspevaemostTableAdapter
            // 
            this.uspevaemostTableAdapter.ClearBeforeFill = true;
            // 
            // uchebnye_kursiDataSet44
            // 
            this.uchebnye_kursiDataSet44.DataSetName = "Uchebnye_kursiDataSet44";
            this.uchebnye_kursiDataSet44.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "Student";
            this.studentBindingSource1.DataSource = this.uchebnye_kursiDataSet44;
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // uchebnye_kursiDataSet45
            // 
            this.uchebnye_kursiDataSet45.DataSetName = "Uchebnye_kursiDataSet45";
            this.uchebnye_kursiDataSet45.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ochenkiBindingSource1
            // 
            this.ochenkiBindingSource1.DataMember = "Ochenki";
            this.ochenkiBindingSource1.DataSource = this.uchebnye_kursiDataSet45;
            // 
            // ochenkiTableAdapter1
            // 
            this.ochenkiTableAdapter1.ClearBeforeFill = true;
            // 
            // FormEditUspe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 336);
            this.Controls.Add(this.cb_ochenki);
            this.Controls.Add(this.cb_student);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEditUspe";
            this.Text = "Редактировать успеваемость";
            this.Load += new System.EventHandler(this.FormEditUspe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ochenkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspevaemostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ochenkiBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_ochenki;
        private System.Windows.Forms.ComboBox cb_student;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Uchebnye_kursiDataSet21 uchebnye_kursiDataSet21;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private Uchebnye_kursiDataSet21TableAdapters.StudentTableAdapter studentTableAdapter;
        private Uchebnye_kursiDataSet22 uchebnye_kursiDataSet22;
        private System.Windows.Forms.BindingSource ochenkiBindingSource;
        private Uchebnye_kursiDataSet22TableAdapters.OchenkiTableAdapter ochenkiTableAdapter;
        private Uchebnye_kursiDataSet43 uchebnye_kursiDataSet43;
        private System.Windows.Forms.BindingSource uspevaemostBindingSource;
        private Uchebnye_kursiDataSet43TableAdapters.UspevaemostTableAdapter uspevaemostTableAdapter;
        private Uchebnye_kursiDataSet44 uchebnye_kursiDataSet44;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private Uchebnye_kursiDataSet44TableAdapters.StudentTableAdapter studentTableAdapter1;
        private Uchebnye_kursiDataSet45 uchebnye_kursiDataSet45;
        private System.Windows.Forms.BindingSource ochenkiBindingSource1;
        private Uchebnye_kursiDataSet45TableAdapters.OchenkiTableAdapter ochenkiTableAdapter1;
    }
}