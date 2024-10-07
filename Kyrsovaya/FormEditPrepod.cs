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
    public partial class FormEditPrepod : Form
    {
        private SqlConnection connection = null;
        private SqlDataAdapter adapter = null;
        private DataTable table;

        public FormEditPrepod()
        {
            InitializeComponent();
        }
        public string get_cs()
        {
            return "Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True";
        }

        public FormEditPrepod(FormPrepodavatel f)
        {
            InitializeComponent();
            f.BackColor = Color.Yellow;
        }

        private void FormEditPrepod_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPrepodavatel f1 = (FormPrepodavatel)this.Owner;

            int id = 0;
            //считывает выбранную строчку
            id = Convert.ToInt32(f1.dataGridViewPrepod.Rows[f1.dataGridViewPrepod.SelectedCells[0].RowIndex].Cells[0].Value);

            f1.PassID_Prepodavatel = tbID.Text;
            f1.PassImya = tb_imya.Text;
            f1.PassFamilia = tb_familia.Text;
            f1.PassOtchestvo = tb_otchestvo.Text;
            f1.PassDoljnost = tb_doljnost.Text;
            f1.PassData_rojdenia = tb_data.Text;
            f1.PassAdres_projivania = tb_adres.Text;
            f1.Show();
            this.Close();



            MessageBox.Show("Вы точно хотите изменить данные таблицы Преподаватели?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (!string.IsNullOrEmpty(tbID.Text) && !string.IsNullOrWhiteSpace(tbID.Text) &&
               !string.IsNullOrEmpty(tb_imya.Text) && !string.IsNullOrWhiteSpace(tb_imya.Text) &&
               !string.IsNullOrEmpty(tb_familia.Text) && !string.IsNullOrWhiteSpace(tb_familia.Text) &&
               !string.IsNullOrEmpty(tb_otchestvo.Text) && !string.IsNullOrWhiteSpace(tb_otchestvo.Text) &&
               !string.IsNullOrEmpty(tb_data.Text) && !string.IsNullOrWhiteSpace(tb_doljnost.Text) &&
               !string.IsNullOrEmpty(tb_adres.Text) && !string.IsNullOrWhiteSpace(tb_data.Text) &&
               !string.IsNullOrEmpty(tb_adres.Text) && !string.IsNullOrWhiteSpace(tb_adres.Text))

            {
                using (var connection = new SqlConnection(get_cs()))
                {
                    connection.Open();

                    using (var cmd = new SqlCommand("UPDATE [Prepodavatel] SET [ID_Prepodavatel]=@ID, [Imya]=@Imya,  [Familia]=@Familia, [Otchestvo]=@Otchestvo, [Doljnost]=@Doljnost, [Data_rojdenia]=@Data_rojdenia, [Adres_projivania]=@Adres_projivania WHERE ID = @ID", connection))

                    {
                        cmd.Parameters.AddWithValue("ID_Prepodavatel", tbID.Text);
                        cmd.Parameters.AddWithValue("Imya", tb_imya.Text);
                        cmd.Parameters.AddWithValue("Familia", tb_familia.Text);
                        cmd.Parameters.AddWithValue("Otchestvo", tb_otchestvo.Text);
                        cmd.Parameters.AddWithValue("Doljnost", tb_doljnost.Text);
                        cmd.Parameters.AddWithValue("Data_rojdenia", tb_data.Text);
                        cmd.Parameters.AddWithValue("Adres_projivania", tb_adres.Text);


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
           
            if (tb_otchestvo.Text != null)
            {
                tb_otchestvo.Clear();
            }
            if (tb_familia.Text != null)
            {
                tb_familia.Clear();
            }
            if (tb_doljnost.Text != null)
            {
                tb_doljnost.Clear();
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
            FormPrepodavatel formeditfac = (FormPrepodavatel)this.Owner;

            connection = new SqlConnection("Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True");
            connection.Open();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter = new SqlDataAdapter("(select Prepodavatel.ID_Prepodavatel, Prepodavatel.Imya, Prepodavatel.Familia,  Prepodavatel.Otchestvo, Prepodavatel.Doljnost, Prepodavatel.Data_rojdenia, Prepodavatel.Adres_projivania from Prepodavatel)", connection);
            table = new DataTable();
            adapter.Fill(table);
            formeditfac.dataGridViewPrepod.DataSource = table;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrepodavatel main = new FormPrepodavatel();
            main.ShowDialog();
            connection.Close();
        }
    }
}