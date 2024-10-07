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
    public partial class FormZapis : Form
    {
        private string ID_Zapis_na_kurs;
        private string Data_zapisi;
        private string Student_ID;
        private string Kurs_ID;


        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;


        public string PassID_Zapis_na_kurs
        {
            get { return ID_Zapis_na_kurs; ; }
            set { ID_Zapis_na_kurs = value; }
        }

        public string PassData_zapisi
        {
            get { return Data_zapisi; }
            set { Data_zapisi = value; }
        }

        public string PassStudent_ID
        {
            get { return Student_ID; }
            set { Student_ID = value; }
        }
        public string PassKurs_ID
        {
            get { return Kurs_ID; }
            set { Kurs_ID = value; }
        }

        public FormZapis()
        {
            InitializeComponent();
        }

        private void FormZapis_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchebnye_kursiDataSet33.Zapis_na_kurs". При необходимости она может быть перемещена или удалена.
            this.zapis_na_kursTableAdapter2.Fill(this.uchebnye_kursiDataSet33.Zapis_na_kurs);
            this.Activated += new System.EventHandler(this.Form_Activated);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddZapis fadddolg = new FormAddZapis();
            this.Hide();
            fadddolg.Owner = this;
            fadddolg.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormEditZapis feddolg = new FormEditZapis();
            this.Hide();
            feddolg.Owner = this;
            feddolg.ShowDialog(this);
        }

        private void FormZapis_Activated(object sender, EventArgs e)
        {

            int n = dataGridViewZapis.Rows.Add();
            dataGridViewZapis.Rows[n].Cells[0].Value = ID_Zapis_na_kurs;
            dataGridViewZapis.Rows[n].Cells[1].Value = Data_zapisi;
            dataGridViewZapis.Rows[n].Cells[2].Value = Student_ID;
            dataGridViewZapis.Rows[n].Cells[3].Value = Kurs_ID;

        }


        private void Form_Activated(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchebnye_kursiDataSet33.Zapis_na_kurs". При необходимости она может быть перемещена или удалена.
            this.zapis_na_kursTableAdapter2.Fill(this.uchebnye_kursiDataSet33.Zapis_na_kurs);


            {
                connection = new SqlConnection(@"Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True");
                connection.Open();
                adapter = new SqlDataAdapter("select Zapis_na_kurs.ID_Zapis_na_kurs, Zapis_na_kurs.Data_zapisi, Zapis_na_kurs.Student_ID, Zapis_na_kurs.Kurs_ID from Zapis_na_kurs, Student, Kurs where Zapis_na_kurs.Student_ID = Student.ID_Student and Zapis_na_kurs.Kurs_ID = Kurs.ID_Kurs", connection);
                table = new DataTable();
                adapter.Fill(table);
                dataGridViewZapis.RowHeadersVisible = false;
                dataGridViewZapis.DataSource = table;
                dataGridViewZapis.Columns[0].HeaderCell.Value = "№";
                dataGridViewZapis.Columns[0].Width = 100;
                dataGridViewZapis.Columns[1].HeaderCell.Value = "Дата записи";
                dataGridViewZapis.Columns[1].Width = 100;
                dataGridViewZapis.Columns[2].HeaderCell.Value = "Студент";
                dataGridViewZapis.Columns[2].Width = 100;
                dataGridViewZapis.Columns[3].HeaderCell.Value = "Курс";
                dataGridViewZapis.Columns[3].Width = 100;

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand mycommand = new SqlCommand($"DELETE FROM Zapis_na_kurs WHERE ID_Zapis_na_kurs = N'{tbDelZapis.Text}'", connection);
                MessageBox.Show("Удалено записей: " + mycommand.ExecuteNonQuery().ToString());
                table.Clear();
                adapter.Fill(table);
                dataGridViewZapis.DataSource = table;
            }
        }

        private void курсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void преподавателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrepodavatel f2 = new FormPrepodavatel();
            f2.Show();
        }

        private void студентыToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
       
       
  

