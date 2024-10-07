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
    public partial class FormOchenki : Form
    {
        private string ID_Ochenki;
        private string Ochenka;
        private string Examen_ID;


        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;


        public string PassID_Ochenki
        {
            get { return ID_Ochenki; }
            set { ID_Ochenki = value; }
        }

        public string PassOchenka
        {
            get { return Ochenka; }
            set { Ochenka = value; }
        }

        public string PassExamen_ID
        {
            get { return Examen_ID; }
            set { Examen_ID = value; }
        }

        public FormOchenki()
        {
            InitializeComponent();
        }

        private void FormOchenki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchebnye_kursiDataSet37.Ochenki". При необходимости она может быть перемещена или удалена.
            this.ochenkiTableAdapter1.Fill(this.uchebnye_kursiDataSet37.Ochenki);
            this.Activated += new System.EventHandler(this.Form_Activated);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddOchenki faddsotr = new FormAddOchenki();
            this.Hide();
            faddsotr.Owner = this;
            faddsotr.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormEditOchenki fedsotr = new FormEditOchenki();
            this.Hide();
            fedsotr.Owner = this;
            fedsotr.ShowDialog(this);
        }
        private void Form_Facultet_Activated(object sender, EventArgs e)
        {

            int n = dataGridViewOchenki.Rows.Add();
            dataGridViewOchenki.Rows[n].Cells[0].Value = ID_Ochenki;
            dataGridViewOchenki.Rows[n].Cells[1].Value = Ochenka;
            dataGridViewOchenki.Rows[n].Cells[2].Value = Examen_ID;
           
        }
        private void Form_Activated(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchebnye_kursiDataSet37.Ochenki". При необходимости она может быть перемещена или удалена.
            this.ochenkiTableAdapter1.Fill(this.uchebnye_kursiDataSet37.Ochenki);

            {
                connection = new SqlConnection(@"Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True");
                connection.Open();
                adapter = new SqlDataAdapter("select Ochenki.ID_Ochenki, Ochenki.Ochenka, Ochenki.Examen_ID from Ochenki, Examen where Ochenki.Examen_ID = Examen.ID_Examen", connection);
                table = new DataTable();
                adapter.Fill(table);
                dataGridViewOchenki.RowHeadersVisible = false;
                dataGridViewOchenki.DataSource = table;
                dataGridViewOchenki.Columns[0].HeaderCell.Value = "№";
                dataGridViewOchenki.Columns[0].Width = 100;
                dataGridViewOchenki.Columns[1].HeaderCell.Value = "Оценка";
                dataGridViewOchenki.Columns[1].Width = 100;
                dataGridViewOchenki.Columns[2].HeaderCell.Value = "Экзамен";
                dataGridViewOchenki.Columns[2].Width = 100;
                

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand mycommand = new SqlCommand($"DELETE FROM Ochenki WHERE ID_Ochenki = N'{tbDelOchenki.Text}'", connection);
                MessageBox.Show("Удалено записей: " + mycommand.ExecuteNonQuery().ToString());
                table.Clear();
                adapter.Fill(table);
                dataGridViewOchenki.DataSource = table;
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

        private void преподавательToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrepodavatel f2 = new FormPrepodavatel();
            f2.Show();
        }

        private void студентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStudent f2 = new FormStudent();
            f2.Show();
        }

        private void успеваемостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUspevaemost f2 = new FormUspevaemost();
            f2.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void экзаменToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExamen f2 = new FormExamen();
            f2.Show();
        }
    }
}
