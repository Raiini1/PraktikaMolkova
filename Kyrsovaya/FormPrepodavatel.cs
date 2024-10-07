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
    public partial class FormPrepodavatel : Form
    {
        private string ID_Prepodavatel;
        private string Imya;
        private string Familia;
        private string Otchestvo;
        private string Doljnost;
        private string Data_rojdenia;
        private string Adres_projivania;


        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;


        public string PassID_Prepodavatel
        {
            get { return ID_Prepodavatel; }
            set { ID_Prepodavatel = value; }
        }

        public string PassImya
        {
            get { return Imya; }
            set { Imya = value; }
        }

        public string PassFamilia
        {
            get { return Familia; }
            set { Familia = value; }
        }

        public string PassOtchestvo
        {
            get { return Otchestvo; }
            set { Otchestvo = value; }
        }
        public string PassDoljnost
        {
            get { return Doljnost; }
            set { Doljnost = value; }
        }

        public string PassData_rojdenia
        {
            get { return Data_rojdenia; }
            set { Data_rojdenia = value; }
        }
        public string PassAdres_projivania
        {
            get { return Adres_projivania; }
            set { Adres_projivania = value; }
        }
        public FormPrepodavatel()
        {
            InitializeComponent();
        }

        private void FormPrepodavatel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchebnye_kursiDataSet34.Prepodavatel". При необходимости она может быть перемещена или удалена.
            this.prepodavatelTableAdapter4.Fill(this.uchebnye_kursiDataSet34.Prepodavatel);
            this.Activated += new System.EventHandler(this.Form_Activated);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormAddPrepod faddsotr = new FormAddPrepod();
            this.Hide();
            faddsotr.Owner = this;
            faddsotr.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormEditPrepod fedsotr = new FormEditPrepod();
            this.Hide();
            fedsotr.Owner = this;
            fedsotr.ShowDialog(this);
        }

        private void Form_Fakultet_Activated(object sender, EventArgs e)
        {

            int n = dataGridViewPrepod.Rows.Add();
            dataGridViewPrepod.Rows[n].Cells[0].Value = ID_Prepodavatel;
            dataGridViewPrepod.Rows[n].Cells[1].Value = Imya;
            dataGridViewPrepod.Rows[n].Cells[2].Value = Familia;
            dataGridViewPrepod.Rows[n].Cells[3].Value = Otchestvo;
            dataGridViewPrepod.Rows[n].Cells[4].Value = Doljnost;
            dataGridViewPrepod.Rows[n].Cells[5].Value = Data_rojdenia;
            dataGridViewPrepod.Rows[n].Cells[6].Value = Adres_projivania;
            
        }
        private void Form_Activated(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchebnye_kursiDataSet34.Prepodavatel". При необходимости она может быть перемещена или удалена.
            this.prepodavatelTableAdapter4.Fill(this.uchebnye_kursiDataSet34.Prepodavatel);

            {
                connection = new SqlConnection(@"Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True");
                connection.Open();
                adapter = new SqlDataAdapter("select Prepodavatel.ID_Prepodavatel, Prepodavatel.Imya, Prepodavatel.Familia, Prepodavatel.Otchestvo, Prepodavatel.Doljnost, Prepodavatel.Data_rojdenia, Prepodavatel.Adres_projivania from Prepodavatel", connection);
                table = new DataTable();
                adapter.Fill(table);
                dataGridViewPrepod.RowHeadersVisible = false;
                dataGridViewPrepod.DataSource = table;
                dataGridViewPrepod.Columns[0].HeaderCell.Value = "№";
                dataGridViewPrepod.Columns[0].Width = 100;
                dataGridViewPrepod.Columns[1].HeaderCell.Value = "Имя";
                dataGridViewPrepod.Columns[1].Width = 100;
                dataGridViewPrepod.Columns[2].HeaderCell.Value = "Фамилия";
                dataGridViewPrepod.Columns[2].Width = 100;
                dataGridViewPrepod.Columns[3].HeaderCell.Value = "Отчество";
                dataGridViewPrepod.Columns[3].Width = 100;
                dataGridViewPrepod.Columns[4].HeaderCell.Value = "Должность";
                dataGridViewPrepod.Columns[4].Width = 100;
                dataGridViewPrepod.Columns[5].HeaderCell.Value = "Дата рождения";
                dataGridViewPrepod.Columns[5].Width = 100;
                dataGridViewPrepod.Columns[6].HeaderCell.Value = "Адрес проживания";
                dataGridViewPrepod.Columns[6].Width = 100;
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand mycommand = new SqlCommand($"DELETE FROM Prepodavatel WHERE ID_Prepodavatel = N'{tbDelPrepod.Text}'", connection);
                MessageBox.Show("Удалено записей: " + mycommand.ExecuteNonQuery().ToString());
                table.Clear();
                adapter.Fill(table);
                dataGridViewPrepod.DataSource = table;
            }
        }

        private void курсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
        }

        private void записьНаКурсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormZapis f2 = new FormZapis();
            f2.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridViewPrepod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void студентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStudent f2 = new FormStudent();
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

       
