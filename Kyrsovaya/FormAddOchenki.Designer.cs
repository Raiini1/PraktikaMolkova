namespace Kyrsovaya
{
    partial class FormAddOchenki
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
            this.cb_examen = new System.Windows.Forms.ComboBox();
            this.examenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchebnye_kursiDataSet25 = new Kyrsovaya.Uchebnye_kursiDataSet25();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_ochenka = new System.Windows.Forms.TextBox();
            this.uchebnye_kursiDataSet24 = new Kyrsovaya.Uchebnye_kursiDataSet24();
            this.ochenkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ochenkiTableAdapter = new Kyrsovaya.Uchebnye_kursiDataSet24TableAdapters.OchenkiTableAdapter();
            this.examenTableAdapter = new Kyrsovaya.Uchebnye_kursiDataSet25TableAdapters.ExamenTableAdapter();
            this.uchebnye_kursiDataSet50 = new Kyrsovaya.Uchebnye_kursiDataSet50();
            this.examenBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.examenTableAdapter1 = new Kyrsovaya.Uchebnye_kursiDataSet50TableAdapters.ExamenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.examenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ochenkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "№";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Оценка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Экзамен";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(241, 50);
            this.tbID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(160, 22);
            this.tbID.TabIndex = 3;
            // 
            // cb_examen
            // 
            this.cb_examen.DataSource = this.examenBindingSource1;
            this.cb_examen.DisplayMember = "ID_Examen";
            this.cb_examen.FormattingEnabled = true;
            this.cb_examen.Location = new System.Drawing.Point(241, 187);
            this.cb_examen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_examen.Name = "cb_examen";
            this.cb_examen.Size = new System.Drawing.Size(160, 24);
            this.cb_examen.TabIndex = 5;
            this.cb_examen.ValueMember = "ID_Examen";
            // 
            // examenBindingSource
            // 
            this.examenBindingSource.DataMember = "Examen";
            this.examenBindingSource.DataSource = this.uchebnye_kursiDataSet25;
            // 
            // uchebnye_kursiDataSet25
            // 
            this.uchebnye_kursiDataSet25.DataSetName = "Uchebnye_kursiDataSet25";
            this.uchebnye_kursiDataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 286);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(261, 286);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 49);
            this.button2.TabIndex = 7;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_ochenka
            // 
            this.tb_ochenka.Location = new System.Drawing.Point(241, 114);
            this.tb_ochenka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_ochenka.Name = "tb_ochenka";
            this.tb_ochenka.Size = new System.Drawing.Size(160, 22);
            this.tb_ochenka.TabIndex = 8;
            // 
            // uchebnye_kursiDataSet24
            // 
            this.uchebnye_kursiDataSet24.DataSetName = "Uchebnye_kursiDataSet24";
            this.uchebnye_kursiDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ochenkiBindingSource
            // 
            this.ochenkiBindingSource.DataMember = "Ochenki";
            this.ochenkiBindingSource.DataSource = this.uchebnye_kursiDataSet24;
            // 
            // ochenkiTableAdapter
            // 
            this.ochenkiTableAdapter.ClearBeforeFill = true;
            // 
            // examenTableAdapter
            // 
            this.examenTableAdapter.ClearBeforeFill = true;
            // 
            // uchebnye_kursiDataSet50
            // 
            this.uchebnye_kursiDataSet50.DataSetName = "Uchebnye_kursiDataSet50";
            this.uchebnye_kursiDataSet50.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examenBindingSource1
            // 
            this.examenBindingSource1.DataMember = "Examen";
            this.examenBindingSource1.DataSource = this.uchebnye_kursiDataSet50;
            // 
            // examenTableAdapter1
            // 
            this.examenTableAdapter1.ClearBeforeFill = true;
            // 
            // FormAddOchenki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 372);
            this.Controls.Add(this.tb_ochenka);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_examen);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAddOchenki";
            this.Text = "Добавление оценки";
            this.Load += new System.EventHandler(this.FormAddOchenki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.examenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ochenkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.ComboBox cb_examen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_ochenka;
        private Uchebnye_kursiDataSet24 uchebnye_kursiDataSet24;
        private System.Windows.Forms.BindingSource ochenkiBindingSource;
        private Uchebnye_kursiDataSet24TableAdapters.OchenkiTableAdapter ochenkiTableAdapter;
        private Uchebnye_kursiDataSet25 uchebnye_kursiDataSet25;
        private System.Windows.Forms.BindingSource examenBindingSource;
        private Uchebnye_kursiDataSet25TableAdapters.ExamenTableAdapter examenTableAdapter;
        private Uchebnye_kursiDataSet50 uchebnye_kursiDataSet50;
        private System.Windows.Forms.BindingSource examenBindingSource1;
        private Uchebnye_kursiDataSet50TableAdapters.ExamenTableAdapter examenTableAdapter1;
    }
}