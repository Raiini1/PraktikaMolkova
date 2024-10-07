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
    public partial class FormExamen : Form
    {
        private string ID_Examen;
        private string Data_examena;
        private string Kurs_ID;
        private string Student_ID;


        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;


        public string PassID_Examen
        {
            get { return ID_Examen; }
            set { ID_Examen = value; }
        }

        public string PassData_examena
        {
            get { return Data_examena; }
            set { Data_examena = value; }
        }

        public string PassKurs_ID
        {
            get { return Kurs_ID; }
            set { Kurs_ID = value; }
        }

        public string PassStudent_ID
        {
            get { return Student_ID; }
            set { Student_ID = value; }
        }

        public FormExamen()
        {
            InitializeComponent();
        }

        private void FormExamen_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchebnye_kursiDataSet38.Examen". При необходимости она может быть перемещена или удалена.
            this.examenTableAdapter1.Fill(this.uchebnye_kursiDataSet38.Examen);
            this.Activated += new System.EventHandler(this.Form_Activated);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddExamen faddsotr = new FormAddExamen();
            this.Hide();
            faddsotr.Owner = this;
            faddsotr.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormEditExamen fedsotr = new FormEditExamen();
            this.Hide();
            fedsotr.Owner = this;
            fedsotr.ShowDialog(this);
        }
        private void Form_Facultet_Activated(object sender, EventArgs e)
        {

            int n = dataGridViewExamen.Rows.Add();
            dataGridViewExamen.Rows[n].Cells[0].Value = ID_Examen;
            dataGridViewExamen.Rows[n].Cells[1].Value = Data_examena;
            dataGridViewExamen.Rows[n].Cells[2].Value = Kurs_ID;
            dataGridViewExamen.Rows[n].Cells[3].Value = Student_ID;
        }

        private void Form_Activated(object sender, EventArgs e)
            {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchebnye_kursiDataSet38.Examen". При необходимости она может быть перемещена или удалена.
            this.examenTableAdapter1.Fill(this.uchebnye_kursiDataSet38.Examen);

            {
                    connection = new SqlConnection(@"Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True");
                    connection.Open();
                    adapter = new SqlDataAdapter("select Examen.ID_Examen, Examen.Data_examena, Examen.Kurs_ID, Examen.Student_ID from Examen, Kurs, Student where Examen.Kurs_ID = Kurs.ID_Kurs and Examen.Student_ID = Student.ID_Student", connection);
                    table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewExamen.RowHeadersVisible = false;
                    dataGridViewExamen.DataSource = table;
                    dataGridViewExamen.Columns[0].HeaderCell.Value = "№";
                    dataGridViewExamen.Columns[0].Width = 100;
                    dataGridViewExamen.Columns[1].HeaderCell.Value = "Дата экзамена";
                    dataGridViewExamen.Columns[1].Width = 100;
                    dataGridViewExamen.Columns[2].HeaderCell.Value = "Курс";
                    dataGridViewExamen.Columns[2].Width = 100;
                    dataGridViewExamen.Columns[3].HeaderCell.Value = "Студент";
                    dataGridViewExamen.Columns[3].Width = 100;


                }
            }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand mycommand = new SqlCommand($"DELETE FROM Examen WHERE ID_Examen = N'{tbDelExamen.Text}'", connection);
                MessageBox.Show("Удалено записей: " + mycommand.ExecuteNonQuery().ToString());
                table.Clear();
                adapter.Fill(table);
                dataGridViewExamen.DataSource = table;
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

        private void оценкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOchenki f2 = new FormOchenki();
            f2.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
