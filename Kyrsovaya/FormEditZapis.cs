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
    public partial class FormEditZapis : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter = null;
        private DataTable table;

        public FormEditZapis()
        {
            InitializeComponent();
        }
        public string get_cs()

        {
            return "Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True";
        }

        public FormEditZapis(FormZapis f)
        {
            InitializeComponent();
            f.BackColor = Color.Yellow;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FormZapis f1 = (FormZapis)this.Owner;

            int id = 0;
            //считывает выбранную строчку
            id = Convert.ToInt32(f1.dataGridViewZapis.Rows[f1.dataGridViewZapis.SelectedCells[0].RowIndex].Cells[0].Value);

            f1.PassID_Zapis_na_kurs = tbID.Text;
            f1.PassData_zapisi = tb_data.Text;
            f1.PassStudent_ID = cb_student.Text;
            f1.PassKurs_ID = cb_kurs.Text;
            f1.Show();
            this.Close();



            MessageBox.Show("Вы точно хотите изменить данные таблицы Запись на курс?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (!string.IsNullOrEmpty(tbID.Text) && !string.IsNullOrWhiteSpace(tbID.Text) &&
               !string.IsNullOrEmpty(tb_data.Text) && !string.IsNullOrWhiteSpace(tb_data.Text) &&
               !string.IsNullOrEmpty(cb_student.Text) && !string.IsNullOrWhiteSpace(cb_student.Text) &&
               !string.IsNullOrEmpty(cb_kurs.Text) && !string.IsNullOrWhiteSpace(cb_kurs.Text))

            {
                using (var connection = new SqlConnection(get_cs()))
                {
                    connection.Open();

                    using (var cmd = new SqlCommand("UPDATE [Zapis_na_kurs] SET [ID_Zapis_na_kurs]=@ID, [Data_zapisi]=@Data_zapisi, [Student_ID]=@Student_ID, [Kurs_ID]=@Kurs_ID WHERE ID_Kurs = @ID", connection))

                    {
                        cmd.Parameters.AddWithValue("ID_Zapis_na_kurs", tbID.Text);
                        cmd.Parameters.AddWithValue("Nazvanie_kursa", tb_data.Text);
                        cmd.Parameters.AddWithValue("Prodoljitelnost_kursa", cb_student.SelectedIndex);
                        cmd.Parameters.AddWithValue("Tsena_kursa", cb_kurs.SelectedIndex);


                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                    FillDataGridViev();

                }


            }
            else
            {
                MessageBox.Show("Заполните все поля.", "Ошибка");
            }
            if (tbID.Text != null)
            {
                tbID.Clear();
            }
            if (tb_data.Text != null)
            {
                tb_data.Clear();
            }
        }

        private void FillDataGridViev()
        {
            FormZapis formeditfac = (FormZapis)this.Owner;

            connection = new SqlConnection("Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True");
            connection.Open();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter = new SqlDataAdapter("(select Zapis_na_kurs.ID_Zapis_na_kurs, Zapis_na_kurs.Data_zapisi, Zapis_na_kurs.Student_ID, Zapis_na_kurs.Kurs_ID from Zapis_na_kurs, Student, Kurs where Zapis_na_kurs.Student_ID = Student.ID_Student and Zapis_na_kurs.Kurs_ID = Kurs.ID_Kurs)", connection);
            table = new DataTable();
            adapter.Fill(table);
            formeditfac.dataGridViewZapis.DataSource = table;
            this.Close();
        }

        private void FormEditZapis_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchebnye_kursiDataSet49.Kurs". При необходимости она может быть перемещена или удалена.
            this.kursTableAdapter1.Fill(this.uchebnye_kursiDataSet49.Kurs);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchebnye_kursiDataSet48.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter1.Fill(this.uchebnye_kursiDataSet48.Student);
            connection = new SqlConnection(@"Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True");
            connection.Open();


            FormZapis frm = (FormZapis)Application.OpenForms["FormZapis"];
            int row = frm.dataGridViewZapis.CurrentRow.Index;
            tbID.Text = Convert.ToString(frm.dataGridViewZapis[0, row].Value);
            tb_data.Text = Convert.ToString(frm.dataGridViewZapis[1, row].Value);
            cb_student.Text = Convert.ToString(frm.dataGridViewZapis[2, row].Value);
            cb_kurs.Text = Convert.ToString(frm.dataGridViewZapis[3, row].Value);

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