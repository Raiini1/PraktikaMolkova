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
    public partial class FormAddKurs : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter = null;
        private DataTable table;

        public FormAddKurs()
        {
            InitializeComponent();
        }
        public string get_cs()
        {
            return "Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True";
        }
        private void FillDataGridViev()
        {
            Form1 formadd = (Form1)this.Owner;

            connection = new SqlConnection("Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True");
            connection.Open();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter = new SqlDataAdapter("(select Kurs.ID_Kurs, Kurs.Nazvanie_kursa, Kurs.Prodoljitelnost_kursa, Kurs.Tsena_kursa, Kurs.Kolvo_mest, Prepodavatel.Familia, Kurs.Skidka, Kurs.Tsena_so_skidkoi from Kurs, Prepodavatel where Kurs.Prepodavatel_ID = Prepodavatel.ID_Prepodavatel)", connection);
            table = new DataTable();
            adapter.Fill(table);
            formadd.dataGridViewKurs.DataSource = table;
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = (Form1)this.Owner;
            f1.PassID_Kurs = tbID.Text;
            f1.PassNazvanie_kursa = tb_nazvanie.Text;
            f1.PassProdoljitelnost_kursa = tb_prodoljitelnost.Text;
            f1.PassTsena_kursa = tb_tsena.Text;
            f1.PassKolvo_mest = tb_mesta.Text;
            f1.PassPrepodavatel_ID = cb_prepodavatel.Text;
            f1.PassKolvo_mest = tb_skidka.Text;
            f1.PassKolvo_mest = tb_tsenaSkidka.Text;
            f1.Show();
            this.Close();



            MessageBox.Show("Вы точно хотите добавить данные в таблицу Курсы?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (!string.IsNullOrEmpty(tbID.Text) && !string.IsNullOrWhiteSpace(tbID.Text) &&
               !string.IsNullOrEmpty(tb_nazvanie.Text) && !string.IsNullOrWhiteSpace(tb_nazvanie.Text) &&
               !string.IsNullOrEmpty(tb_prodoljitelnost.Text) && !string.IsNullOrWhiteSpace(tb_prodoljitelnost.Text) &&
               !string.IsNullOrEmpty(tb_tsena.Text) && !string.IsNullOrWhiteSpace(tb_tsena.Text) &&
               !string.IsNullOrEmpty(tb_mesta.Text) && !string.IsNullOrWhiteSpace(tb_mesta.Text) &&
               !string.IsNullOrEmpty(cb_prepodavatel.Text) && !string.IsNullOrWhiteSpace(cb_prepodavatel.Text)&&
                !string.IsNullOrEmpty(tb_skidka.Text) && !string.IsNullOrWhiteSpace(tb_skidka.Text) &&
                !string.IsNullOrEmpty(tb_tsenaSkidka.Text) && !string.IsNullOrWhiteSpace(tb_tsenaSkidka.Text))

            {
                using (var connection = new SqlConnection(get_cs()))
                {
                    connection.Open();

                    using (var cmd = new SqlCommand("INSERT INTO [Kurs] (ID_Kurs, Nazvanie_kursa, Prodoljitelnost_kursa, Tsena_kursa, Kolvo_mest, Prepodavatel_ID, Skidka, Tsena_so_skidkoi) VALUES (@ID_Kurs, @Nazvanie_kursa, @Prodoljitelnost_kursa, @Tsena_kursa, @Kolvo_mest, @Prepodavatel_ID, @Skidka, @Tsena_so_skidkoi)", connection))

                    {
                        cmd.Parameters.AddWithValue("ID_Kurs", tbID.Text);
                        cmd.Parameters.AddWithValue("Nazvanie_kursa", tb_nazvanie.Text);
                        cmd.Parameters.AddWithValue("Prodoljitelnost_kursa", tb_prodoljitelnost.Text);
                        cmd.Parameters.AddWithValue("Tsena_kursa", tb_tsena.Text);
                        cmd.Parameters.AddWithValue("Kolvo_mest", tb_mesta.Text);
                        cmd.Parameters.AddWithValue("Prepodavatel_ID", cb_prepodavatel.SelectedIndex);
                        cmd.Parameters.AddWithValue("Skidka", tb_skidka.Text);
                        cmd.Parameters.AddWithValue("Tsena_so_skidkoi", tb_tsenaSkidka.Text);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                    tbID.Clear();
                    tb_nazvanie.Clear();
                    tb_prodoljitelnost.Clear();
                    tb_tsena.Clear();
                    tb_mesta.Clear();

                    tb_skidka.Clear();
                    tb_tsenaSkidka.Clear();
                    FillDataGridViev();

                }
            }
        }

        private void FormAddKurs_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchebnye_kursiDataSet39.Prepodavatel". При необходимости она может быть перемещена или удалена.
            this.prepodavatelTableAdapter1.Fill(this.uchebnye_kursiDataSet39.Prepodavatel);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 main = new Form1();
            main.ShowDialog();
            connection.Close();
        }
    }
}
