namespace Kyrsovaya
{
    partial class FormAddKurs
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
            this.lb_nazvanie = new System.Windows.Forms.Label();
            this.lb_prodoljitelnost = new System.Windows.Forms.Label();
            this.lb_tsena = new System.Windows.Forms.Label();
            this.lb_mesta = new System.Windows.Forms.Label();
            this.lb_prepodavatel = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tb_nazvanie = new System.Windows.Forms.TextBox();
            this.tb_prodoljitelnost = new System.Windows.Forms.TextBox();
            this.tb_tsena = new System.Windows.Forms.TextBox();
            this.tb_mesta = new System.Windows.Forms.TextBox();
            this.cb_prepodavatel = new System.Windows.Forms.ComboBox();
            this.prepodavatelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uchebnye_kursiDataSet1 = new Kyrsovaya.Uchebnye_kursiDataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.prepodavatelTableAdapter = new Kyrsovaya.Uchebnye_kursiDataSet1TableAdapters.PrepodavatelTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_skidka = new System.Windows.Forms.TextBox();
            this.tb_tsenaSkidka = new System.Windows.Forms.TextBox();
            this.uchebnye_kursiDataSet39 = new Kyrsovaya.Uchebnye_kursiDataSet39();
            this.prepodavatelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.prepodavatelTableAdapter1 = new Kyrsovaya.Uchebnye_kursiDataSet39TableAdapters.PrepodavatelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.prepodavatelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepodavatelBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(103, 34);
            this.lbID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 16);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "№";
            // 
            // lb_nazvanie
            // 
            this.lb_nazvanie.AutoSize = true;
            this.lb_nazvanie.Location = new System.Drawing.Point(64, 96);
            this.lb_nazvanie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_nazvanie.Name = "lb_nazvanie";
            this.lb_nazvanie.Size = new System.Drawing.Size(114, 16);
            this.lb_nazvanie.TabIndex = 1;
            this.lb_nazvanie.Text = "Название курса";
            // 
            // lb_prodoljitelnost
            // 
            this.lb_prodoljitelnost.AutoSize = true;
            this.lb_prodoljitelnost.Location = new System.Drawing.Point(29, 162);
            this.lb_prodoljitelnost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_prodoljitelnost.Name = "lb_prodoljitelnost";
            this.lb_prodoljitelnost.Size = new System.Drawing.Size(182, 16);
            this.lb_prodoljitelnost.TabIndex = 2;
            this.lb_prodoljitelnost.Text = "Продолжительность курса";
            // 
            // lb_tsena
            // 
            this.lb_tsena.AutoSize = true;
            this.lb_tsena.Location = new System.Drawing.Point(75, 226);
            this.lb_tsena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tsena.Name = "lb_tsena";
            this.lb_tsena.Size = new System.Drawing.Size(81, 16);
            this.lb_tsena.TabIndex = 3;
            this.lb_tsena.Text = "Цена курса";
            // 
            // lb_mesta
            // 
            this.lb_mesta.AutoSize = true;
            this.lb_mesta.Location = new System.Drawing.Point(56, 290);
            this.lb_mesta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_mesta.Name = "lb_mesta";
            this.lb_mesta.Size = new System.Drawing.Size(119, 16);
            this.lb_mesta.TabIndex = 4;
            this.lb_mesta.Text = "Количество мест";
            // 
            // lb_prepodavatel
            // 
            this.lb_prepodavatel.AutoSize = true;
            this.lb_prepodavatel.Location = new System.Drawing.Point(63, 359);
            this.lb_prepodavatel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_prepodavatel.Name = "lb_prepodavatel";
            this.lb_prepodavatel.Size = new System.Drawing.Size(111, 16);
            this.lb_prepodavatel.TabIndex = 5;
            this.lb_prepodavatel.Text = "Преподаватель";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(235, 34);
            this.tbID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(163, 22);
            this.tbID.TabIndex = 6;
            // 
            // tb_nazvanie
            // 
            this.tb_nazvanie.Location = new System.Drawing.Point(235, 96);
            this.tb_nazvanie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_nazvanie.Name = "tb_nazvanie";
            this.tb_nazvanie.Size = new System.Drawing.Size(163, 22);
            this.tb_nazvanie.TabIndex = 7;
            // 
            // tb_prodoljitelnost
            // 
            this.tb_prodoljitelnost.Location = new System.Drawing.Point(235, 162);
            this.tb_prodoljitelnost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_prodoljitelnost.Name = "tb_prodoljitelnost";
            this.tb_prodoljitelnost.Size = new System.Drawing.Size(163, 22);
            this.tb_prodoljitelnost.TabIndex = 8;
            // 
            // tb_tsena
            // 
            this.tb_tsena.Location = new System.Drawing.Point(235, 226);
            this.tb_tsena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_tsena.Name = "tb_tsena";
            this.tb_tsena.Size = new System.Drawing.Size(163, 22);
            this.tb_tsena.TabIndex = 9;
            // 
            // tb_mesta
            // 
            this.tb_mesta.Location = new System.Drawing.Point(235, 290);
            this.tb_mesta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_mesta.Name = "tb_mesta";
            this.tb_mesta.Size = new System.Drawing.Size(163, 22);
            this.tb_mesta.TabIndex = 10;
            // 
            // cb_prepodavatel
            // 
            this.cb_prepodavatel.DataSource = this.prepodavatelBindingSource1;
            this.cb_prepodavatel.DisplayMember = "Familia";
            this.cb_prepodavatel.FormattingEnabled = true;
            this.cb_prepodavatel.Location = new System.Drawing.Point(237, 359);
            this.cb_prepodavatel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_prepodavatel.Name = "cb_prepodavatel";
            this.cb_prepodavatel.Size = new System.Drawing.Size(160, 24);
            this.cb_prepodavatel.TabIndex = 11;
            this.cb_prepodavatel.ValueMember = "ID_Prepodavatel";
            // 
            // prepodavatelBindingSource
            // 
            this.prepodavatelBindingSource.DataMember = "Prepodavatel";
            this.prepodavatelBindingSource.DataSource = this.uchebnye_kursiDataSet1;
            // 
            // uchebnye_kursiDataSet1
            // 
            this.uchebnye_kursiDataSet1.DataSetName = "Uchebnye_kursiDataSet1";
            this.uchebnye_kursiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 560);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 44);
            this.button1.TabIndex = 12;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 560);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 44);
            this.button2.TabIndex = 13;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // prepodavatelTableAdapter
            // 
            this.prepodavatelTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 430);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Скидка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 487);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Цена со скидкой";
            // 
            // tb_skidka
            // 
            this.tb_skidka.Location = new System.Drawing.Point(237, 430);
            this.tb_skidka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_skidka.Name = "tb_skidka";
            this.tb_skidka.Size = new System.Drawing.Size(160, 22);
            this.tb_skidka.TabIndex = 16;
            // 
            // tb_tsenaSkidka
            // 
            this.tb_tsenaSkidka.Location = new System.Drawing.Point(237, 487);
            this.tb_tsenaSkidka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_tsenaSkidka.Name = "tb_tsenaSkidka";
            this.tb_tsenaSkidka.Size = new System.Drawing.Size(160, 22);
            this.tb_tsenaSkidka.TabIndex = 17;
            // 
            // uchebnye_kursiDataSet39
            // 
            this.uchebnye_kursiDataSet39.DataSetName = "Uchebnye_kursiDataSet39";
            this.uchebnye_kursiDataSet39.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prepodavatelBindingSource1
            // 
            this.prepodavatelBindingSource1.DataMember = "Prepodavatel";
            this.prepodavatelBindingSource1.DataSource = this.uchebnye_kursiDataSet39;
            // 
            // prepodavatelTableAdapter1
            // 
            this.prepodavatelTableAdapter1.ClearBeforeFill = true;
            // 
            // FormAddKurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 619);
            this.Controls.Add(this.tb_tsenaSkidka);
            this.Controls.Add(this.tb_skidka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_prepodavatel);
            this.Controls.Add(this.tb_mesta);
            this.Controls.Add(this.tb_tsena);
            this.Controls.Add(this.tb_prodoljitelnost);
            this.Controls.Add(this.tb_nazvanie);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lb_prepodavatel);
            this.Controls.Add(this.lb_mesta);
            this.Controls.Add(this.lb_tsena);
            this.Controls.Add(this.lb_prodoljitelnost);
            this.Controls.Add(this.lb_nazvanie);
            this.Controls.Add(this.lbID);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAddKurs";
            this.Text = "Добавить курс";
            this.Load += new System.EventHandler(this.FormAddKurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prepodavatelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepodavatelBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lb_nazvanie;
        private System.Windows.Forms.Label lb_prodoljitelnost;
        private System.Windows.Forms.Label lb_tsena;
        private System.Windows.Forms.Label lb_mesta;
        private System.Windows.Forms.Label lb_prepodavatel;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tb_nazvanie;
        private System.Windows.Forms.TextBox tb_prodoljitelnost;
        private System.Windows.Forms.TextBox tb_tsena;
        private System.Windows.Forms.TextBox tb_mesta;
        private System.Windows.Forms.ComboBox cb_prepodavatel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Uchebnye_kursiDataSet1 uchebnye_kursiDataSet1;
        private System.Windows.Forms.BindingSource prepodavatelBindingSource;
        private Uchebnye_kursiDataSet1TableAdapters.PrepodavatelTableAdapter prepodavatelTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_skidka;
        private System.Windows.Forms.TextBox tb_tsenaSkidka;
        private Uchebnye_kursiDataSet39 uchebnye_kursiDataSet39;
        private System.Windows.Forms.BindingSource prepodavatelBindingSource1;
        private Uchebnye_kursiDataSet39TableAdapters.PrepodavatelTableAdapter prepodavatelTableAdapter1;
    }
}