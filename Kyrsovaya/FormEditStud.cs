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
    public partial class FormEditStud : Form
    {
        public FormEditStud()
        {
            InitializeComponent();
        }
        private SqlConnection connection;

        public string get_cs()

        {
            return "Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True";
        }

        public FormEditStud(FormStudent f)
        {
            InitializeComponent();
            f.BackColor = Color.Yellow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormStudent f1 = (FormStudent)this.Owner;

            int id = 0;
            //считывает выбранную строчку
            id = Convert.ToInt32(f1.dataGridViewStud.Rows[f1.dataGridViewStud.SelectedCells[0].RowIndex].Cells[0].Value);

            f1.PassID_Student = tbID.Text;
            f1.PassImya = tb_imya.Text;
            f1.PassFamilia = tb_familia.Text;
            f1.PassOtchestvo = tb_otchestvo.Text;
            f1.PassData_rojdenia = tb_data.Text;
            f1.PassAdres_projivania = tb_adres.Text;
            f1.Show();
            this.Close();



            MessageBox.Show("Вы точно хотите изменить данные таблицы Студенты?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (!string.IsNullOrEmpty(tbID.Text) && !string.IsNullOrWhiteSpace(tbID.Text) &&
               !string.IsNullOrEmpty(tb_imya.Text) && !string.IsNullOrWhiteSpace(tb_imya.Text) &&
               !string.IsNullOrEmpty(tb_familia.Text) && !string.IsNullOrWhiteSpace(tb_familia.Text) &&
               !string.IsNullOrEmpty(tb_otchestvo.Text) && !string.IsNullOrWhiteSpace(tb_otchestvo.Text) &&
               !string.IsNullOrEmpty(tb_data.Text) && !string.IsNullOrWhiteSpace(tb_data.Text) &&
               !string.IsNullOrEmpty(tb_adres.Text) && !string.IsNullOrWhiteSpace(tb_adres.Text))
               

            {
                using (var connection = new SqlConnection(get_cs()))
                {
                    connection.Open();

                    using (var cmd = new SqlCommand("UPDATE [Student] SET [ID_Student]=@ID, [Imya]=@Imya, [Familia]=@Familia, [Otchestvo]=@Otchestvo, [Data_rojdenia]=@Data_rojdenia, [Adres_projivania]=@Adres_projivania WHERE ID_Student = @ID", connection))

                    {
                        cmd.Parameters.AddWithValue("ID_Kurs", tbID.Text);
                        cmd.Parameters.AddWithValue("Nazvanie_kursa", tb_imya.Text);
                        cmd.Parameters.AddWithValue("Prodoljitelnost_kursa", tb_familia.Text);
                        cmd.Parameters.AddWithValue("Tsena_kursa", tb_otchestvo.Text);
                        cmd.Parameters.AddWithValue("Kolvo_mest", tb_data.Text);
                        cmd.Parameters.AddWithValue("Prepodavatel_ID", tb_adres.Text);


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
            if (tb_imya.Text != null)
            {
                tb_imya.Clear();
            }
            if (tb_familia.Text != null)
            {
                tb_familia.Clear();
            }

            if (tb_otchestvo.Text != null)
            {
                tb_otchestvo.Clear();
            }

            if (tb_data.Text != null)
            {
                tb_data.Clear();
            }
            if (tb_adres.Text != null)
            {
                tb_adres.Clear();
            }
        }

        private void FillDataGridViev()
        {
            FormStudent formeditfac = (FormStudent)this.Owner;

            connection = new SqlConnection("Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True");
            connection.Open();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter = new SqlDataAdapter("(select Student.ID_Student, Student.Imya, Student.Familia, Student.Otchestvo, Student.Data_rojdenia, Student.Adres_projivania from Student)", connection);
            table = new DataTable();
            adapter.Fill(table);
            formeditfac.dataGridViewStud.DataSource = table;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStudent main = new FormStudent();
            main.ShowDialog();
            connection.Close();
        }

        private void FormEditStud_Load(object sender, EventArgs e)
        {

        }
    }
}
