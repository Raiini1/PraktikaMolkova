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
    public partial class FormUspevaemost : Form
    {
        private string ID_Uspevaemost;
        private string Student_ID;
        private string Ochenki_ID;


        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;


        public string PassID_Uspevaemost
        {
            get { return ID_Uspevaemost; }
            set { ID_Uspevaemost = value; }
        }

        public string PassStudent_ID
        {
            get { return Student_ID; }
            set { Student_ID = value; }
        }

        public string PassOchenki_ID
        {
            get { return Ochenki_ID; }
            set { Ochenki_ID = value; }
        }

        public FormUspevaemost()
        {
            InitializeComponent();
        }

        private void FormUspevaemost_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchebnye_kursiDataSet36.Uspevaemost". При необходимости она может быть перемещена или удалена.
            this.uspevaemostTableAdapter1.Fill(this.uchebnye_kursiDataSet36.Uspevaemost);
            this.Activated += new System.EventHandler(this.Form_Activated);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddUspe faddsotr = new FormAddUspe();
            this.Hide();
            faddsotr.Owner = this;
            faddsotr.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormEditUspe fedsotr = new FormEditUspe();
            this.Hide();
            fedsotr.Owner = this;
            fedsotr.ShowDialog(this);
        }
        private void Form_Facultet_Activated(object sender, EventArgs e)
        {

            int n = dataGridViewUspe.Rows.Add();
            dataGridViewUspe.Rows[n].Cells[0].Value = ID_Uspevaemost;
            dataGridViewUspe.Rows[n].Cells[1].Value = Student_ID;
            dataGridViewUspe.Rows[n].Cells[2].Value = Ochenki_ID;
            
        }
        private void Form_Activated(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchebnye_kursiDataSet36.Uspevaemost". При необходимости она может быть перемещена или удалена.
            this.uspevaemostTableAdapter1.Fill(this.uchebnye_kursiDataSet36.Uspevaemost);

            {
                connection = new SqlConnection(@"Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True");
                connection.Open();
                adapter = new SqlDataAdapter("select Uspevaemost.ID_Uspevaemost, Uspevaemost.Student_ID, Uspevaemost.Ochenki_ID from Uspevaemost, Student, Ochenki where Uspevaemost.Student_ID = Student.ID_Student and Uspevaemost.Ochenki_ID = Ochenki.ID_Ochenki", connection);
                table = new DataTable();
                adapter.Fill(table);
                dataGridViewUspe.RowHeadersVisible = false;
                dataGridViewUspe.DataSource = table;
                dataGridViewUspe.Columns[0].HeaderCell.Value = "№";
                dataGridViewUspe.Columns[0].Width = 100;
                dataGridViewUspe.Columns[1].HeaderCell.Value = "Студент";
                dataGridViewUspe.Columns[1].Width = 100;
                dataGridViewUspe.Columns[2].HeaderCell.Value = "Оценки";
                dataGridViewUspe.Columns[2].Width = 100;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand mycommand = new SqlCommand($"DELETE FROM Uspevaemost WHERE ID_Uspevaemost = N'{tbDelUspe.Text}'", connection);
                MessageBox.Show("Удалено записей: " + mycommand.ExecuteNonQuery().ToString());
                table.Clear();
                adapter.Fill(table);
                dataGridViewUspe.DataSource = table;
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

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
