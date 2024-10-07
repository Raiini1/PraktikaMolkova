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
    public partial class FormEditExamen : Form
    {
        private SqlConnection connection;

        public FormEditExamen()
        {
            InitializeComponent();
        }
        public string get_cs()

        {
            return "Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True";
        }

        public FormEditExamen(Form1 f)
        {
            InitializeComponent();
            f.BackColor = Color.Yellow;
        }



        private void FormEditExamen_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchebnye_kursiDataSet55.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter1.Fill(this.uchebnye_kursiDataSet55.Student);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchebnye_kursiDataSet54.Kurs". При необходимости она может быть перемещена или удалена.
            this.kursTableAdapter1.Fill(this.uchebnye_kursiDataSet54.Kurs);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormExamen f1 = (FormExamen)this.Owner;

            int id = 0;
            //считывает выбранную строчку
            id = Convert.ToInt32(f1.dataGridViewExamen.Rows[f1.dataGridViewExamen.SelectedCells[0].RowIndex].Cells[0].Value);

            f1.PassID_Examen = tbID.Text;
            f1.PassData_examena = tb_data.Text;
            f1.PassKurs_ID = cb_kurs.Text;
            f1.PassStudent_ID = cb_student.Text;
            f1.Show();
            this.Close();



            MessageBox.Show("Вы точно хотите изменить данные таблицы Экзамены?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (!string.IsNullOrEmpty(tbID.Text) && !string.IsNullOrWhiteSpace(tbID.Text) &&
               !string.IsNullOrEmpty(tb_data.Text) && !string.IsNullOrWhiteSpace(tb_data.Text) &&
               !string.IsNullOrEmpty(cb_kurs.Text) && !string.IsNullOrWhiteSpace(cb_kurs.Text) &&
               !string.IsNullOrEmpty(cb_student.Text) && !string.IsNullOrWhiteSpace(cb_student.Text))

            {
                using (var connection = new SqlConnection(get_cs()))
                {
                    connection.Open();

                    using (var cmd = new SqlCommand("UPDATE [Examen] SET [ID_Examen]=@ID, [Data_examena]=@Data_examena, [Kurs_ID]=@Kurs_ID, [Student_ID]=@Student_ID WHERE ID_Examen = @ID", connection))

                    {
                        cmd.Parameters.AddWithValue("ID_Examen", tbID.Text);
                        cmd.Parameters.AddWithValue("Data_examena", tb_data.Text);
                        cmd.Parameters.AddWithValue("Kurs_ID", cb_kurs.SelectedIndex);
                        cmd.Parameters.AddWithValue("Student_ID", cb_student.SelectedIndex);



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
            FormExamen formeditfac = (FormExamen)this.Owner;

            connection = new SqlConnection("Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True");
            connection.Open();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter = new SqlDataAdapter("(select Examen.ID_Examen, Examen.Data_examena, Examen.Kurs_ID, Examen.Student_ID from Examen, Kurs, Student where Examen.Kurs_ID = Kurs.ID_Kurs and Examen.Student_ID = Student.ID_Student)", connection);
            table = new DataTable();
            adapter.Fill(table);
            formeditfac.dataGridViewExamen.DataSource = table;
            this.Close();
        }
    }
}

