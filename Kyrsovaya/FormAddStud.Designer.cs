namespace Kyrsovaya
{
    partial class FormAddStud
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tb_imya = new System.Windows.Forms.TextBox();
            this.tb_familia = new System.Windows.Forms.TextBox();
            this.tb_otchestvo = new System.Windows.Forms.TextBox();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.tb_adres = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "№";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата рождения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Адрес проживания";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(139, 30);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(128, 20);
            this.tbID.TabIndex = 6;
            // 
            // tb_imya
            // 
            this.tb_imya.Location = new System.Drawing.Point(139, 75);
            this.tb_imya.Name = "tb_imya";
            this.tb_imya.Size = new System.Drawing.Size(128, 20);
            this.tb_imya.TabIndex = 7;
            // 
            // tb_familia
            // 
            this.tb_familia.Location = new System.Drawing.Point(139, 130);
            this.tb_familia.Name = "tb_familia";
            this.tb_familia.Size = new System.Drawing.Size(128, 20);
            this.tb_familia.TabIndex = 8;
            // 
            // tb_otchestvo
            // 
            this.tb_otchestvo.Location = new System.Drawing.Point(139, 183);
            this.tb_otchestvo.Name = "tb_otchestvo";
            this.tb_otchestvo.Size = new System.Drawing.Size(128, 20);
            this.tb_otchestvo.TabIndex = 9;
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(139, 230);
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(128, 20);
            this.tb_data.TabIndex = 10;
            // 
            // tb_adres
            // 
            this.tb_adres.Location = new System.Drawing.Point(139, 277);
            this.tb_adres.Name = "tb_adres";
            this.tb_adres.Size = new System.Drawing.Size(128, 20);
            this.tb_adres.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 38);
            this.button2.TabIndex = 13;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormAddStud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 408);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_adres);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.tb_otchestvo);
            this.Controls.Add(this.tb_familia);
            this.Controls.Add(this.tb_imya);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddStud";
            this.Text = "Добавить данные студента";
            this.Load += new System.EventHandler(this.FormAddStud_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tb_imya;
        private System.Windows.Forms.TextBox tb_familia;
        private System.Windows.Forms.TextBox tb_otchestvo;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.TextBox tb_adres;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}