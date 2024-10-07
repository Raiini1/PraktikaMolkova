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
    public partial class FormAddStud : Form
    {

        private SqlConnection connection;
        private SqlDataAdapter adapter = null;
        private DataTable table;

        public FormAddStud()
        {
            InitializeComponent();
        }
        public string get_cs()
        {
            return "Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True";
        }
        private void FillDataGridViev()
        {
            FormStudent formadd = (FormStudent)this.Owner;

            connection = new SqlConnection("Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True");
            connection.Open();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter = new SqlDataAdapter("(select Student.ID_Student, Student.Imya, Student.Familia, Student.Otchestvo, Student.Data_rojdenia, Student.Adres_projivania from Student)", connection);
            table = new DataTable();
            adapter.Fill(table);
            formadd.dataGridViewStud.DataSource = table;
            this.Close();
        }

        private void FormAddStud_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormStudent f1 = (FormStudent)this.Owner;
            f1.PassID_Student = tbID.Text;
            f1.PassImya = tb_imya.Text;
            f1.PassFamilia = tb_familia.Text;
            f1.PassOtchestvo = tb_otchestvo.Text;
            f1.PassData_rojdenia = tb_data.Text;
            f1.PassAdres_projivania = tb_adres.Text;
            f1.Show();
            this.Close();



            MessageBox.Show("Вы точно хотите добавить данные в таблицу Студенты?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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

                    using (var cmd = new SqlCommand("INSERT INTO [Student] (ID_Student, Imya, Familia, Otchestvo, Data_rojdenia, Adres_projivania) VALUES (@ID_Student, @Imya, @Familia, @Otchestvo, @Data_rojdenia, @Adres_projivania)", connection))
                    {
                        cmd.Parameters.AddWithValue("ID_Student", tbID.Text);
                        cmd.Parameters.AddWithValue("Imya", tb_imya.Text);
                        cmd.Parameters.AddWithValue("Familia", tb_familia.Text);
                        cmd.Parameters.AddWithValue("Otchestvo", tb_otchestvo.Text);
                        cmd.Parameters.AddWithValue("Data_rojdenia", tb_data.Text);
                        cmd.Parameters.AddWithValue("Adres_projivania", tb_adres.Text);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                    tbID.Clear();
                    tb_imya.Clear();
                    tb_familia.Clear();
                    tb_otchestvo.Clear();
                    tb_data.Clear();
                    tb_adres.Clear();

                    FillDataGridViev();

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStudent main = new FormStudent();
            main.ShowDialog();
            connection.Close();
        }
    }
}
