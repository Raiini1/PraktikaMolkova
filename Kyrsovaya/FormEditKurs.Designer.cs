namespace Kyrsovaya
{
    partial class FormEditKurs
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
            this.lb_skidka = new System.Windows.Forms.Label();
            this.lb_tsenaSkidka = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tb_nazvanie = new System.Windows.Forms.TextBox();
            this.tb_tsena = new System.Windows.Forms.TextBox();
            this.tb_mesta = new System.Windows.Forms.TextBox();
            this.tb_skidka = new System.Windows.Forms.TextBox();
            this.tb_tsenaSkidka = new System.Windows.Forms.TextBox();
            this.cb_prepodavatel = new System.Windows.Forms.ComboBox();
            this.prepodavatelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uchebnye_kursiDataSet12 = new Kyrsovaya.Uchebnye_kursiDataSet12();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_prodoljitelnost = new System.Windows.Forms.TextBox();
            this.uchebnye_kursiDataSet8 = new Kyrsovaya.Uchebnye_kursiDataSet8();
            this.kursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kursTableAdapter = new Kyrsovaya.Uchebnye_kursiDataSet8TableAdapters.KursTableAdapter();
            this.uchebnye_kursiDataSet9 = new Kyrsovaya.Uchebnye_kursiDataSet9();
            this.prepodavatelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prepodavatelTableAdapter = new Kyrsovaya.Uchebnye_kursiDataSet9TableAdapters.PrepodavatelTableAdapter();
            this.uchebnye_kursiDataSet11 = new Kyrsovaya.Uchebnye_kursiDataSet11();
            this.kursBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kursTableAdapter1 = new Kyrsovaya.Uchebnye_kursiDataSet11TableAdapters.KursTableAdapter();
            this.prepodavatelTableAdapter1 = new Kyrsovaya.Uchebnye_kursiDataSet12TableAdapters.PrepodavatelTableAdapter();
            this.uchebnye_kursiDataSet40 = new Kyrsovaya.Uchebnye_kursiDataSet40();
            this.prepodavatelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.prepodavatelTableAdapter2 = new Kyrsovaya.Uchebnye_kursiDataSet40TableAdapters.PrepodavatelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.prepodavatelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepodavatelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepodavatelBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(113, 30);
            this.lbID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 16);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "№";
            // 
            // lb_nazvanie
            // 
            this.lb_nazvanie.AutoSize = true;
            this.lb_nazvanie.Location = new System.Drawing.Point(76, 94);
            this.lb_nazvanie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_nazvanie.Name = "lb_nazvanie";
            this.lb_nazvanie.Size = new System.Drawing.Size(114, 16);
            this.lb_nazvanie.TabIndex = 1;
            this.lb_nazvanie.Text = "Название курса";
            // 
            // lb_prodoljitelnost
            // 
            this.lb_prodoljitelnost.AutoSize = true;
            this.lb_prodoljitelnost.Location = new System.Drawing.Point(47, 142);
            this.lb_prodoljitelnost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_prodoljitelnost.Name = "lb_prodoljitelnost";
            this.lb_prodoljitelnost.Size = new System.Drawing.Size(182, 16);
            this.lb_prodoljitelnost.TabIndex = 2;
            this.lb_prodoljitelnost.Text = "Продолжительность курса";
            // 
            // lb_tsena
            // 
            this.lb_tsena.AutoSize = true;
            this.lb_tsena.Location = new System.Drawing.Point(87, 193);
            this.lb_tsena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tsena.Name = "lb_tsena";
            this.lb_tsena.Size = new System.Drawing.Size(81, 16);
            this.lb_tsena.TabIndex = 3;
            this.lb_tsena.Text = "Цена курса";
            // 
            // lb_mesta
            // 
            this.lb_mesta.AutoSize = true;
            this.lb_mesta.Location = new System.Drawing.Point(69, 250);
            this.lb_mesta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_mesta.Name = "lb_mesta";
            this.lb_mesta.Size = new System.Drawing.Size(119, 16);
            this.lb_mesta.TabIndex = 4;
            this.lb_mesta.Text = "Количество мест";
            // 
            // lb_prepodavatel
            // 
            this.lb_prepodavatel.AutoSize = true;
            this.lb_prepodavatel.Location = new System.Drawing.Point(76, 302);
            this.lb_prepodavatel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_prepodavatel.Name = "lb_prepodavatel";
            this.lb_prepodavatel.Size = new System.Drawing.Size(111, 16);
            this.lb_prepodavatel.TabIndex = 5;
            this.lb_prepodavatel.Text = "Преподаватель";
            // 
            // lb_skidka
            // 
            this.lb_skidka.AutoSize = true;
            this.lb_skidka.Location = new System.Drawing.Point(100, 364);
            this.lb_skidka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_skidka.Name = "lb_skidka";
            this.lb_skidka.Size = new System.Drawing.Size(54, 16);
            this.lb_skidka.TabIndex = 6;
            this.lb_skidka.Text = "Скидка";
            // 
            // lb_tsenaSkidka
            // 
            this.lb_tsenaSkidka.AutoSize = true;
            this.lb_tsenaSkidka.Location = new System.Drawing.Point(76, 425);
            this.lb_tsenaSkidka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tsenaSkidka.Name = "lb_tsenaSkidka";
            this.lb_tsenaSkidka.Size = new System.Drawing.Size(114, 16);
            this.lb_tsenaSkidka.TabIndex = 7;
            this.lb_tsenaSkidka.Text = "Цена со скидкой";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(264, 30);
            this.tbID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(176, 22);
            this.tbID.TabIndex = 8;
            // 
            // tb_nazvanie
            // 
            this.tb_nazvanie.Location = new System.Drawing.Point(264, 90);
            this.tb_nazvanie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_nazvanie.Name = "tb_nazvanie";
            this.tb_nazvanie.Size = new System.Drawing.Size(176, 22);
            this.tb_nazvanie.TabIndex = 9;
            // 
            // tb_tsena
            // 
            this.tb_tsena.Location = new System.Drawing.Point(264, 193);
            this.tb_tsena.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_tsena.Name = "tb_tsena";
            this.tb_tsena.Size = new System.Drawing.Size(176, 22);
            this.tb_tsena.TabIndex = 10;
            // 
            // tb_mesta
            // 
            this.tb_mesta.Location = new System.Drawing.Point(264, 250);
            this.tb_mesta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_mesta.Name = "tb_mesta";
            this.tb_mesta.Size = new System.Drawing.Size(176, 22);
            this.tb_mesta.TabIndex = 11;
            // 
            // tb_skidka
            // 
            this.tb_skidka.Location = new System.Drawing.Point(264, 364);
            this.tb_skidka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_skidka.Name = "tb_skidka";
            this.tb_skidka.Size = new System.Drawing.Size(176, 22);
            this.tb_skidka.TabIndex = 13;
            // 
            // tb_tsenaSkidka
            // 
            this.tb_tsenaSkidka.Location = new System.Drawing.Point(264, 425);
            this.tb_tsenaSkidka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_tsenaSkidka.Name = "tb_tsenaSkidka";
            this.tb_tsenaSkidka.Size = new System.Drawing.Size(176, 22);
            this.tb_tsenaSkidka.TabIndex = 14;
            // 
            // cb_prepodavatel
            // 
            this.cb_prepodavatel.DataSource = this.prepodavatelBindingSource2;
            this.cb_prepodavatel.DisplayMember = "Familia";
            this.cb_prepodavatel.FormattingEnabled = true;
            this.cb_prepodavatel.Location = new System.Drawing.Point(264, 302);
            this.cb_prepodavatel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_prepodavatel.Name = "cb_prepodavatel";
            this.cb_prepodavatel.Size = new System.Drawing.Size(176, 24);
            this.cb_prepodavatel.TabIndex = 16;
            this.cb_prepodavatel.ValueMember = "ID_Prepodavatel";
            // 
            // prepodavatelBindingSource1
            // 
            this.prepodavatelBindingSource1.DataMember = "Prepodavatel";
            this.prepodavatelBindingSource1.DataSource = this.uchebnye_kursiDataSet12;
            // 
            // uchebnye_kursiDataSet12
            // 
            this.uchebnye_kursiDataSet12.DataSetName = "Uchebnye_kursiDataSet12";
            this.uchebnye_kursiDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 486);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 42);
            this.button1.TabIndex = 17;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(301, 486);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 42);
            this.button2.TabIndex = 18;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_prodoljitelnost
            // 
            this.tb_prodoljitelnost.Location = new System.Drawing.Point(264, 142);
            this.tb_prodoljitelnost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_prodoljitelnost.Name = "tb_prodoljitelnost";
            this.tb_prodoljitelnost.Size = new System.Drawing.Size(176, 22);
            this.tb_prodoljitelnost.TabIndex = 19;
            // 
            // uchebnye_kursiDataSet8
            // 
            this.uchebnye_kursiDataSet8.DataSetName = "Uchebnye_kursiDataSet8";
            this.uchebnye_kursiDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kursBindingSource
            // 
            this.kursBindingSource.DataMember = "Kurs";
            this.kursBindingSource.DataSource = this.uchebnye_kursiDataSet8;
            // 
            // kursTableAdapter
            // 
            this.kursTableAdapter.ClearBeforeFill = true;
            // 
            // uchebnye_kursiDataSet9
            // 
            this.uchebnye_kursiDataSet9.DataSetName = "Uchebnye_kursiDataSet9";
            this.uchebnye_kursiDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prepodavatelBindingSource
            // 
            this.prepodavatelBindingSource.DataMember = "Prepodavatel";
            this.prepodavatelBindingSource.DataSource = this.uchebnye_kursiDataSet9;
            // 
            // prepodavatelTableAdapter
            // 
            this.prepodavatelTableAdapter.ClearBeforeFill = true;
            // 
            // uchebnye_kursiDataSet11
            // 
            this.uchebnye_kursiDataSet11.DataSetName = "Uchebnye_kursiDataSet11";
            this.uchebnye_kursiDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kursBindingSource1
            // 
            this.kursBindingSource1.DataMember = "Kurs";
            this.kursBindingSource1.DataSource = this.uchebnye_kursiDataSet11;
            // 
            // kursTableAdapter1
            // 
            this.kursTableAdapter1.ClearBeforeFill = true;
            // 
            // prepodavatelTableAdapter1
            // 
            this.prepodavatelTableAdapter1.ClearBeforeFill = true;
            // 
            // uchebnye_kursiDataSet40
            // 
            this.uchebnye_kursiDataSet40.DataSetName = "Uchebnye_kursiDataSet40";
            this.uchebnye_kursiDataSet40.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prepodavatelBindingSource2
            // 
            this.prepodavatelBindingSource2.DataMember = "Prepodavatel";
            this.prepodavatelBindingSource2.DataSource = this.uchebnye_kursiDataSet40;
            // 
            // prepodavatelTableAdapter2
            // 
            this.prepodavatelTableAdapter2.ClearBeforeFill = true;
            // 
            // FormEditKurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 554);
            this.Controls.Add(this.tb_prodoljitelnost);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_prepodavatel);
            this.Controls.Add(this.tb_tsenaSkidka);
            this.Controls.Add(this.tb_skidka);
            this.Controls.Add(this.tb_mesta);
            this.Controls.Add(this.tb_tsena);
            this.Controls.Add(this.tb_nazvanie);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lb_tsenaSkidka);
            this.Controls.Add(this.lb_skidka);
            this.Controls.Add(this.lb_prepodavatel);
            this.Controls.Add(this.lb_mesta);
            this.Controls.Add(this.lb_tsena);
            this.Controls.Add(this.lb_prodoljitelnost);
            this.Controls.Add(this.lb_nazvanie);
            this.Controls.Add(this.lbID);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEditKurs";
            this.Text = "Редактировать курс";
            this.Load += new System.EventHandler(this.FormEditKurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prepodavatelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepodavatelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kursBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uchebnye_kursiDataSet40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prepodavatelBindingSource2)).EndInit();
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
        private System.Windows.Forms.Label lb_skidka;
        private System.Windows.Forms.Label lb_tsenaSkidka;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tb_nazvanie;
        private System.Windows.Forms.TextBox tb_tsena;
        private System.Windows.Forms.TextBox tb_mesta;
        private System.Windows.Forms.TextBox tb_skidka;
        private System.Windows.Forms.TextBox tb_tsenaSkidka;
        private System.Windows.Forms.ComboBox cb_prepodavatel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_prodoljitelnost;
        private Uchebnye_kursiDataSet8 uchebnye_kursiDataSet8;
        private System.Windows.Forms.BindingSource kursBindingSource;
        private Uchebnye_kursiDataSet8TableAdapters.KursTableAdapter kursTableAdapter;
        private Uchebnye_kursiDataSet9 uchebnye_kursiDataSet9;
        private System.Windows.Forms.BindingSource prepodavatelBindingSource;
        private Uchebnye_kursiDataSet9TableAdapters.PrepodavatelTableAdapter prepodavatelTableAdapter;
        private Uchebnye_kursiDataSet11 uchebnye_kursiDataSet11;
        private System.Windows.Forms.BindingSource kursBindingSource1;
        private Uchebnye_kursiDataSet11TableAdapters.KursTableAdapter kursTableAdapter1;
        private Uchebnye_kursiDataSet12 uchebnye_kursiDataSet12;
        private System.Windows.Forms.BindingSource prepodavatelBindingSource1;
        private Uchebnye_kursiDataSet12TableAdapters.PrepodavatelTableAdapter prepodavatelTableAdapter1;
        private Uchebnye_kursiDataSet40 uchebnye_kursiDataSet40;
        private System.Windows.Forms.BindingSource prepodavatelBindingSource2;
        private Uchebnye_kursiDataSet40TableAdapters.PrepodavatelTableAdapter prepodavatelTableAdapter2;
    }
}