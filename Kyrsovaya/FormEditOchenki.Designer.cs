﻿namespace Kyrsovaya
{
    partial class FormEditOchenki
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
            this.tb_ochenka = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_examen = new System.Windows.Forms.ComboBox();
            this.examenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchebnye_kursiDataSet26 = new Kyrsovaya.Uchebnye_kursiDataSet26();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.examenTableAdapter = new Kyrsovaya.Uchebnye_kursiDataSet26TableAdapters.ExamenTableAdapter();
            this.uchebnye_kursiDataSet51 = new Kyrsovaya.Uchebnye_kursiDataSet51();
            this.examenBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.examenTableAdapter1 = new Kyrsovaya.Uchebnye_kursiDataSet51TableAdapters.ExamenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.examenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_ochenka
            // 
            this.tb_ochenka.Location = new System.Drawing.Point(231, 100);
            this.tb_ochenka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_ochenka.Name = "tb_ochenka";
            this.tb_ochenka.Size = new System.Drawing.Size(160, 22);
            this.tb_ochenka.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(251, 271);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 49);
            this.button2.TabIndex = 15;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 271);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 49);
            this.button1.TabIndex = 14;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_examen
            // 
            this.cb_examen.DataSource = this.examenBindingSource1;
            this.cb_examen.DisplayMember = "ID_Examen";
            this.cb_examen.FormattingEnabled = true;
            this.cb_examen.Location = new System.Drawing.Point(231, 172);
            this.cb_examen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_examen.Name = "cb_examen";
            this.cb_examen.Size = new System.Drawing.Size(160, 24);
            this.cb_examen.TabIndex = 13;
            this.cb_examen.ValueMember = "ID_Examen";
            // 
            // examenBindingSource
            // 
            this.examenBindingSource.DataMember = "Examen";
            this.examenBindingSource.DataSource = this.uchebnye_kursiDataSet26;
            // 
            // uchebnye_kursiDataSet26
            // 
            this.uchebnye_kursiDataSet26.DataSetName = "Uchebnye_kursiDataSet26";
            this.uchebnye_kursiDataSet26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(231, 36);
            this.tbID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(160, 22);
            this.tbID.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Экзамен";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Оценка";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "№";
            // 
            // examenTableAdapter
            // 
            this.examenTableAdapter.ClearBeforeFill = true;
            // 
            // uchebnye_kursiDataSet51
            // 
            this.uchebnye_kursiDataSet51.DataSetName = "Uchebnye_kursiDataSet51";
            this.uchebnye_kursiDataSet51.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examenBindingSource1
            // 
            this.examenBindingSource1.DataMember = "Examen";
            this.examenBindingSource1.DataSource = this.uchebnye_kursiDataSet51;
            // 
            // examenTableAdapter1
            // 
            this.examenTableAdapter1.ClearBeforeFill = true;
            // 
            // FormEditOchenki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 359);
            this.Controls.Add(this.tb_ochenka);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_examen);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEditOchenki";
            this.Text = "Редактировать оценки";
            this.Load += new System.EventHandler(this.FormEditOchenki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.examenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ochenka;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_examen;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Uchebnye_kursiDataSet26 uchebnye_kursiDataSet26;
        private System.Windows.Forms.BindingSource examenBindingSource;
        private Uchebnye_kursiDataSet26TableAdapters.ExamenTableAdapter examenTableAdapter;
        private Uchebnye_kursiDataSet51 uchebnye_kursiDataSet51;
        private System.Windows.Forms.BindingSource examenBindingSource1;
        private Uchebnye_kursiDataSet51TableAdapters.ExamenTableAdapter examenTableAdapter1;
    }
}