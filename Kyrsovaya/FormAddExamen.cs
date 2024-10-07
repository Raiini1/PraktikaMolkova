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
    public partial class FormAddExamen : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter = null;
        private DataTable table;
        public FormAddExamen()
        {
            InitializeComponent();
        }
        public string get_cs()
        {
            return "Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True";
        }
        private void FillDataGridViev()
        {
            FormExamen formadd = (FormExamen)this.Owner;

            connection = new SqlConnection("Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True");
            connection.Open();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter = new SqlDataAdapter("(select Examen.ID_Examen, Examen.Data_examena, Examen.Kurs_ID, Examen.Student_ID from Examen, Kurs, Student where Examen.Kurs_ID = Kurs.ID_Kurs and Examen.Student_ID = Student.ID_Student", connection);
            table = new DataTable();
            adapter.Fill(table);
            formadd.dataGridViewExamen.DataSource = table;
            this.Close();
        }


        private void FormAddExamen_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchebnye_kursiDataSet53.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter1.Fill(this.uchebnye_kursiDataSet53.Student);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchebnye_kursiDataSet52.Kurs". При необходимости она может быть перемещена или удалена.
            this.kursTableAdapter1.Fill(this.uchebnye_kursiDataSet52.Kurs);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormExamen f1 = (FormExamen)this.Owner;
            f1.PassID_Examen = tbID.Text;
            f1.PassData_examena = tb_data.Text;
            f1.PassKurs_ID = cb_kurs.Text;
            f1.PassStudent_ID = cb_student.Text;
            f1.Show();
            this.Close();



            MessageBox.Show("Вы точно хотите добавить данные в таблицу Экзамены?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (!string.IsNullOrEmpty(tbID.Text) && !string.IsNullOrWhiteSpace(tbID.Text) &&
               !string.IsNullOrEmpty(tb_data.Text) && !string.IsNullOrWhiteSpace(tb_data.Text) &&
               !string.IsNullOrEmpty(cb_student.Text) && !string.IsNullOrWhiteSpace(cb_kurs.Text) &&
               !string.IsNullOrEmpty(cb_student.Text) && !string.IsNullOrWhiteSpace(cb_student.Text))

            {
                using (var connection = new SqlConnection(get_cs()))
                {
                    connection.Open();

                    using (var cmd = new SqlCommand("INSERT INTO [Examen] (ID_Examen, Data_examena, Kurs_ID, Student_ID) VALUES (@ID_Examen, @Data_examena, @Kurs_ID, @Student_ID)", connection))

                    {
                        cmd.Parameters.AddWithValue("ID_Examen", tbID.Text);
                        cmd.Parameters.AddWithValue("Data_examena", tb_data.Text);
                        cmd.Parameters.AddWithValue("Kurs_ID", cb_kurs.SelectedIndex);
                        cmd.Parameters.AddWithValue("Student_ID", cb_student.SelectedIndex);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                    tbID.Clear();
                    tb_data.Clear();

                    FillDataGridViev();

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormExamen main = new FormExamen();
            main.ShowDialog();
            connection.Close();
        }
    }
}
