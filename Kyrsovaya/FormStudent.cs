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
    public partial class FormStudent : Form
    {
        private string ID_Student;
        private string Imya;
        private string Familia;
        private string Otchestvo;
        private string Data_rojdenia;
        private string Adres_projivania;
     

        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;


        public string PassID_Student
        {
            get { return ID_Student; }
            set { ID_Student = value; }
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

        public FormStudent()
        {
            InitializeComponent();
        }


        private void оценкиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchebnye_kursiDataSet35.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter1.Fill(this.uchebnye_kursiDataSet35.Student);
            this.Activated += new System.EventHandler(this.Form_Activated);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddStud faddsotr = new FormAddStud();
            this.Hide();
            faddsotr.Owner = this;
            faddsotr.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormEditStud fedsotr = new FormEditStud();
            this.Hide();
            fedsotr.Owner = this;
            fedsotr.ShowDialog(this);
        }
        private void Form_Facultet_Activated(object sender, EventArgs e)
        {

            int n = dataGridViewStud.Rows.Add();
            dataGridViewStud.Rows[n].Cells[0].Value = ID_Student;
            dataGridViewStud.Rows[n].Cells[1].Value = Imya;
            dataGridViewStud.Rows[n].Cells[2].Value = Familia;
            dataGridViewStud.Rows[n].Cells[3].Value = Otchestvo;
            dataGridViewStud.Rows[n].Cells[4].Value = Data_rojdenia;
            dataGridViewStud.Rows[n].Cells[5].Value = Adres_projivania;
       
        }
        private void Form_Activated(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchebnye_kursiDataSet35.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter1.Fill(this.uchebnye_kursiDataSet35.Student);

            {
                connection = new SqlConnection(@"Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True");
                connection.Open();
                adapter = new SqlDataAdapter("select Student.ID_Student, Student.Imya, Student.Familia, Student.Otchestvo, Student.Data_rojdenia, Student.Adres_projivania from Student", connection);
                table = new DataTable();
                adapter.Fill(table);
                dataGridViewStud.RowHeadersVisible = false;
                dataGridViewStud.DataSource = table;
                dataGridViewStud.Columns[0].HeaderCell.Value = "№";
                dataGridViewStud.Columns[0].Width = 50;
                dataGridViewStud.Columns[1].HeaderCell.Value = "Имя";
                dataGridViewStud.Columns[1].Width = 100;
                dataGridViewStud.Columns[2].HeaderCell.Value = "Фамилия";
                dataGridViewStud.Columns[2].Width = 120;
                dataGridViewStud.Columns[3].HeaderCell.Value = "Отчество";
                dataGridViewStud.Columns[3].Width = 80;
                dataGridViewStud.Columns[4].HeaderCell.Value = "Дата рождения";
                dataGridViewStud.Columns[4].Width = 80;
                dataGridViewStud.Columns[5].HeaderCell.Value = "Адрес проживания";
                dataGridViewStud.Columns[5].Width = 100;
  
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand mycommand = new SqlCommand($"DELETE FROM Kurs WHERE ID_Kurs = N'{tbDelStud.Text}'", connection);
                MessageBox.Show("Удалено записей: " + mycommand.ExecuteNonQuery().ToString());
                table.Clear();
                adapter.Fill(table);
                dataGridViewStud.DataSource = table;
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

        private void экзаменыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUspevaemost f2 = new FormUspevaemost();
            f2.Show();
        }

        private void оценкиToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormOchenki f2 = new FormOchenki();
            f2.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void экзаменыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormExamen f2 = new FormExamen();
            f2.Show();
        }
    }
}
