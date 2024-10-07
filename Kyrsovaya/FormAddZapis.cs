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
    public partial class FormAddZapis : Form
    {
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;

        public FormAddZapis()
        {
            InitializeComponent();
        }

        public string get_cs()
        {
            return "Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True";
        }
        private void FillDataGridViev()
        {
            FormZapis formadd = (FormZapis)this.Owner;

            connection = new SqlConnection("Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True");
            connection.Open();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter = new SqlDataAdapter("(select Zapis_na_kurs.ID_Zapis_na_kurs, Zapis_na_kurs.Data_zapisi, Zapis_na_kurs.Student_ID, Zapis_na_kurs.Kurs_ID from Zapis_na_kurs, Student, Kurs where Zapis_na_kurs.Student_ID = Student.ID_Student and Zapis_na_kurs.Kurs_ID = Kurs.ID_Kurs)", connection);
            table = new DataTable();
            adapter.Fill(table);
            formadd.dataGridViewZapis.DataSource = table;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormZapis f1 = (FormZapis)this.Owner;
            f1.PassID_Zapis_na_kurs = tbID.Text;
            f1.PassData_zapisi = tb_data.Text;
            f1.PassStudent_ID = cb_student.Text;
            f1.PassStudent_ID = cb_kurs.Text;
            f1.Show();
            this.Close();



            MessageBox.Show("Вы точно хотите добавить данные в таблицу Запись на курс?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (!string.IsNullOrEmpty(tbID.Text) && !string.IsNullOrWhiteSpace(tbID.Text) &&
               !string.IsNullOrEmpty(tb_data.Text) && !string.IsNullOrWhiteSpace(tb_data.Text) &&
               !string.IsNullOrEmpty(cb_student.Text) && !string.IsNullOrWhiteSpace(cb_student.Text) &&
               !string.IsNullOrEmpty(cb_kurs.Text) && !string.IsNullOrWhiteSpace(cb_kurs.Text))
            {
                using (var connection = new SqlConnection(get_cs()))
                {
                    connection.Open();

                    using (var cmd = new SqlCommand("INSERT INTO [Zapis_na_kurs] (ID_Zapis_na_kurs, Data_zapisi, Student_ID, Kurs_ID) VALUES (@ID, @Data_zapisi, @Student_ID, @Kurs_ID)", connection))

                    {
                        cmd.Parameters.AddWithValue("ID_Zapis_na_kurs", tbID.Text);
                        cmd.Parameters.AddWithValue("Data_zapisi", tb_data.Text);
                        cmd.Parameters.AddWithValue("Oklad", cb_student.SelectedIndex);
                        cmd.Parameters.AddWithValue("Oklad", cb_kurs.SelectedIndex);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                    tbID.Clear();
                    tb_data.Clear();
                    FillDataGridViev();

                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!!!", "Предупреждение");
            }

        }

        private void FormAddZapis_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchebnye_kursiDataSet47.Kurs". При необходимости она может быть перемещена или удалена.
            this.kursTableAdapter1.Fill(this.uchebnye_kursiDataSet47.Kurs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchebnye_kursiDataSet46.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter1.Fill(this.uchebnye_kursiDataSet46.Student);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormZapis main = new FormZapis();
            main.ShowDialog();
            connection.Close();
        }
    }
}