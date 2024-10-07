namespace Kyrsovaya
{
    partial class FormAddUspe
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cb_student = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchebnye_kursiDataSet19 = new Kyrsovaya.Uchebnye_kursiDataSet19();
            this.cb_ochenki = new System.Windows.Forms.ComboBox();
            this.ochenkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchebnye_kursiDataSet20 = new Kyrsovaya.Uchebnye_kursiDataSet20();
            this.studentTableAdapter = new Kyrsovaya.Uchebnye_kursiDataSet19TableAdapters.StudentTableAdapter();
            this.ochenkiTableAdapter = new Kyrsovaya.Uchebnye_kursiDataSet20TableAdapters.OchenkiTableAdapter();
            this.uchebnye_kursiDataSet41 = new Kyrsovaya.Uchebnye_kursiDataSet41();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter1 = new Kyrsovaya.Uchebnye_kursiDataSet41TableAdapters.StudentTableAdapter();
            this.uchebnye_kursiDataSet42 = new Kyrsovaya.Uchebnye_kursiDataSet42();
            this.ochenkiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ochenkiTableAdapter1 = new Kyrsovaya.Uchebnye_kursiDataSet42TableAdapters.OchenkiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ochenkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ochenkiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "№";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Студент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Оценки";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(165, 39);
            this.tbID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(157, 22);
            this.tbID.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 257);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(196, 257);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 49);
            this.button2.TabIndex = 7;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cb_student
            // 
            this.cb_student.DataSource = this.studentBindingSource1;
            this.cb_student.DisplayMember = "Familia";
            this.cb_student.FormattingEnabled = true;
            this.cb_student.Location = new System.Drawing.Point(165, 100);
            this.cb_student.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_student.Name = "cb_student";
            this.cb_student.Size = new System.Drawing.Size(160, 24);
            this.cb_student.TabIndex = 8;
            this.cb_student.ValueMember = "ID_Student";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.uchebnye_kursiDataSet19;
            // 
            // uchebnye_kursiDataSet19
            // 
            this.uchebnye_kursiDataSet19.DataSetName = "Uchebnye_kursiDataSet19";
            this.uchebnye_kursiDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cb_ochenki
            // 
            this.cb_ochenki.DataSource = this.ochenkiBindingSource1;
            this.cb_ochenki.DisplayMember = "Ochenka";
            this.cb_ochenki.FormattingEnabled = true;
            this.cb_ochenki.Location = new System.Drawing.Point(165, 167);
            this.cb_ochenki.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_ochenki.Name = "cb_ochenki";
            this.cb_ochenki.Size = new System.Drawing.Size(160, 24);
            this.cb_ochenki.TabIndex = 9;
            this.cb_ochenki.ValueMember = "ID_Ochenki";
            // 
            // ochenkiBindingSource
            // 
            this.ochenkiBindingSource.DataMember = "Ochenki";
            this.ochenkiBindingSource.DataSource = this.uchebnye_kursiDataSet20;
            // 
            // uchebnye_kursiDataSet20
            // 
            this.uchebnye_kursiDataSet20.DataSetName = "Uchebnye_kursiDataSet20";
            this.uchebnye_kursiDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // ochenkiTableAdapter
            // 
            this.ochenkiTableAdapter.ClearBeforeFill = true;
            // 
            // uchebnye_kursiDataSet41
            // 
            this.uchebnye_kursiDataSet41.DataSetName = "Uchebnye_kursiDataSet41";
            this.uchebnye_kursiDataSet41.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "Student";
            this.studentBindingSource1.DataSource = this.uchebnye_kursiDataSet41;
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // uchebnye_kursiDataSet42
            // 
            this.uchebnye_kursiDataSet42.DataSetName = "Uchebnye_kursiDataSet42";
            this.uchebnye_kursiDataSet42.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ochenkiBindingSource1
            // 
            this.ochenkiBindingSource1.DataMember = "Ochenki";
            this.ochenkiBindingSource1.DataSource = this.uchebnye_kursiDataSet42;
            // 
            // ochenkiTableAdapter1
            // 
            this.ochenkiTableAdapter1.ClearBeforeFill = true;
            // 
            // FormAddUspe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 345);
            this.Controls.Add(this.cb_ochenki);
            this.Controls.Add(this.cb_student);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAddUspe";
            this.Text = "Добавление успеваемости";
            this.Load += new System.EventHandler(this.FormAddUspe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ochenkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ochenkiBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cb_student;
        private System.Windows.Forms.ComboBox cb_ochenki;
        private Uchebnye_kursiDataSet19 uchebnye_kursiDataSet19;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private Uchebnye_kursiDataSet19TableAdapters.StudentTableAdapter studentTableAdapter;
        private Uchebnye_kursiDataSet20 uchebnye_kursiDataSet20;
        private System.Windows.Forms.BindingSource ochenkiBindingSource;
        private Uchebnye_kursiDataSet20TableAdapters.OchenkiTableAdapter ochenkiTableAdapter;
        private Uchebnye_kursiDataSet41 uchebnye_kursiDataSet41;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private Uchebnye_kursiDataSet41TableAdapters.StudentTableAdapter studentTableAdapter1;
        private Uchebnye_kursiDataSet42 uchebnye_kursiDataSet42;
        private System.Windows.Forms.BindingSource ochenkiBindingSource1;
        private Uchebnye_kursiDataSet42TableAdapters.OchenkiTableAdapter ochenkiTableAdapter1;
    }
}