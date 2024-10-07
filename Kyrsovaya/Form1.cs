using Kyrsovaya;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrsovaya
{
    public partial class Form1 : Form
    {
        private string ID_Kurs;
        private string Nazvanie_kursa;
        private string Prodoljitelnost_kursa;
        private string Tsena_kursa;
        private string Kolvo_mest;
        private string Prepodavatel_ID;
        private string Skidka;
        private string Tsena_so_skidkoi;


        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;


        public string PassID_Kurs
        {
            get { return ID_Kurs; }
            set { ID_Kurs = value; }
        }

        public string PassNazvanie_kursa
        {
            get { return Nazvanie_kursa; }
            set { Nazvanie_kursa = value; }
        }

        public string PassProdoljitelnost_kursa
        {
            get { return Prodoljitelnost_kursa; }
            set { Prodoljitelnost_kursa = value; }
        }

        public string PassTsena_kursa
        {
            get { return Tsena_kursa; }
            set { Tsena_kursa = value; }
        }
        public string PassKolvo_mest
        {
            get { return Kolvo_mest; }
            set { Kolvo_mest = value; }
        }

        public string PassPrepodavatel_ID
        {
            get { return Prepodavatel_ID; }
            set { Prepodavatel_ID = value; }
        }
        public string PassSkidka
        {
            get { return Skidka; }
            set { Skidka = value; }
        }
        public string PassTsena_so_skidkoi
        {
            get { return Tsena_so_skidkoi; }
            set { Tsena_so_skidkoi = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchebnye_kursiDataSet32.Kurs". При необходимости она может быть перемещена или удалена.
            this.kursTableAdapter2.Fill(this.uchebnye_kursiDataSet32.Kurs);
            this.Activated += new System.EventHandler(this.Form_Activated);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormAddKurs faddsotr = new FormAddKurs();
            this.Hide();
            faddsotr.Owner = this;
            faddsotr.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormEditKurs fedsotr = new FormEditKurs();
            this.Hide();
            fedsotr.Owner = this;
            fedsotr.ShowDialog(this);
        }

        private void Form_Facultet_Activated(object sender, EventArgs e)
        {

            int n = dataGridViewKurs.Rows.Add();
            dataGridViewKurs.Rows[n].Cells[0].Value = ID_Kurs;
            dataGridViewKurs.Rows[n].Cells[1].Value = Nazvanie_kursa;
            dataGridViewKurs.Rows[n].Cells[2].Value = Prodoljitelnost_kursa;
            dataGridViewKurs.Rows[n].Cells[3].Value = Tsena_kursa;
            dataGridViewKurs.Rows[n].Cells[4].Value = Kolvo_mest;
            dataGridViewKurs.Rows[n].Cells[5].Value = Prepodavatel_ID;
            dataGridViewKurs.Rows[n].Cells[6].Value = Skidka;
            dataGridViewKurs.Rows[n].Cells[7].Value = Tsena_so_skidkoi;
        }
        private void Form_Activated(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchebnye_kursiDataSet32.Kurs". При необходимости она может быть перемещена или удалена.
            this.kursTableAdapter2.Fill(this.uchebnye_kursiDataSet32.Kurs);

            {
                connection = new SqlConnection(@"Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True");
                connection.Open();
                adapter = new SqlDataAdapter("select Kurs.ID_Kurs, Kurs.Nazvanie_kursa, Kurs.Prodoljitelnost_kursa, Kurs.Tsena_kursa, Kurs.Kolvo_mest, Prepodavatel.Familia, Kurs.Skidka, Kurs.Tsena_so_skidkoi from Kurs, Prepodavatel where Kurs.Prepodavatel_ID = Prepodavatel.ID_Prepodavatel", connection);
                table = new DataTable();
                adapter.Fill(table);
                dataGridViewKurs.RowHeadersVisible = false;
                dataGridViewKurs.DataSource = table;
                dataGridViewKurs.Columns[0].HeaderCell.Value = "№";
                dataGridViewKurs.Columns[0].Width = 50;
                dataGridViewKurs.Columns[1].HeaderCell.Value = "Название курса";
                dataGridViewKurs.Columns[1].Width = 100;
                dataGridViewKurs.Columns[2].HeaderCell.Value = "Продолжительность курса";
                dataGridViewKurs.Columns[2].Width = 120;
                dataGridViewKurs.Columns[3].HeaderCell.Value = "Цена курса";
                dataGridViewKurs.Columns[3].Width = 80;
                dataGridViewKurs.Columns[4].HeaderCell.Value = "Количество мест";
                dataGridViewKurs.Columns[4].Width = 80;
                dataGridViewKurs.Columns[5].HeaderCell.Value = "Преподаватель";
                dataGridViewKurs.Columns[5].Width = 100;
                dataGridViewKurs.Columns[6].HeaderCell.Value = "Скидка";
                dataGridViewKurs.Columns[6].Width = 80;
                dataGridViewKurs.Columns[7].HeaderCell.Value = "Цена со скидкой";
                dataGridViewKurs.Columns[7].Width = 100;

            }
        }
   
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand mycommand = new SqlCommand($"DELETE FROM Kurs WHERE ID_Kurs = N'{tbDelKurs.Text}'", connection);
                MessageBox.Show("Удалено записей: " + mycommand.ExecuteNonQuery().ToString());
                table.Clear();
                adapter.Fill(table);
                dataGridViewKurs.DataSource = table;
            }    
        }

        private void студентыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormZapis f2 = new FormZapis();
            f2.Show();
        }

        private void преподавателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrepodavatel f2 = new FormPrepodavatel();
            f2.Show();
        }
        private void студентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void студентыToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormStudent f2 = new FormStudent();
            f2.Show();
        }

        private void успеваемостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUspevaemost f2 = new FormUspevaemost();
            f2.Show();
        }

        private void оценкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOchenki f2 = new FormOchenki();
            f2.Show();
        }

        private void экзаменыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExamen f2 = new FormExamen();
            f2.Show();
        }
    }
}
