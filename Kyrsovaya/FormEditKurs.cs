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
    public partial class FormEditKurs : Form
    {
        private SqlConnection connection;

        public FormEditKurs()
        {
            InitializeComponent();
        }
        public string get_cs()

        {
            return "Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True";
        }

        public FormEditKurs(Form1 f)
        {
            InitializeComponent();
            f.BackColor = Color.Yellow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = (Form1)this.Owner;

            int id = 0;
            //считывает выбранную строчку
            id = Convert.ToInt32(f1.dataGridViewKurs.Rows[f1.dataGridViewKurs.SelectedCells[0].RowIndex].Cells[0].Value);

            f1.PassID_Kurs = tbID.Text;
            f1.PassNazvanie_kursa = tb_nazvanie.Text;
            f1.PassProdoljitelnost_kursa = tb_prodoljitelnost.Text;
            f1.PassTsena_kursa = tb_tsena.Text;
            f1.PassKolvo_mest = tb_mesta.Text;
            f1.PassPrepodavatel_ID = cb_prepodavatel.Text;
            f1.PassSkidka = tb_skidka.Text;
            f1.PassTsena_so_skidkoi = tb_tsenaSkidka.Text;
            f1.Show();
            this.Close();



            MessageBox.Show("Вы точно хотите изменить данные таблицы Курсы?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (!string.IsNullOrEmpty(tbID.Text) && !string.IsNullOrWhiteSpace(tbID.Text) &&
               !string.IsNullOrEmpty(tb_nazvanie.Text) && !string.IsNullOrWhiteSpace(tb_nazvanie.Text) &&
               !string.IsNullOrEmpty(tb_prodoljitelnost.Text) && !string.IsNullOrWhiteSpace(tb_prodoljitelnost.Text) &&
               !string.IsNullOrEmpty(tb_tsena.Text) && !string.IsNullOrWhiteSpace(tb_tsena.Text) &&
               !string.IsNullOrEmpty(tb_mesta.Text) && !string.IsNullOrWhiteSpace(tb_mesta.Text) &&
               !string.IsNullOrEmpty(cb_prepodavatel.Text) && !string.IsNullOrWhiteSpace(cb_prepodavatel.Text) &&
               !string.IsNullOrEmpty(tb_skidka.Text) && !string.IsNullOrWhiteSpace(tb_skidka.Text) &&
               !string.IsNullOrEmpty(tb_tsenaSkidka.Text) && !string.IsNullOrWhiteSpace(tb_tsenaSkidka.Text))

            {
                using (var connection = new SqlConnection(get_cs()))
                {
                    connection.Open();

                    using (var cmd = new SqlCommand("UPDATE [Kurs] SET [ID_Kurs]=@ID, [Nazvanie_kursa]=@Nazvanie_kursa, [Prodoljitelnost_kursa]=@IProdoljitelnost_kursa, [Tsena_kursa]=@Tsena_kursa, [Kolvo_mest]=@Kolvo_mest, [Prepodavatel_ID]=@Prepodavatel_ID, [Skidka]=@Skidka, [Tsena_so_skidkoi]=@Tsena_so_skidkoi WHERE ID_Kurs = @ID", connection))

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
            if (tb_nazvanie.Text != null)
            {
                tb_nazvanie.Clear();
            }
            if (tb_prodoljitelnost.Text != null)
            {
                tb_prodoljitelnost.Clear();
            }

            if (tb_tsena.Text != null)
            {
                tb_tsena.Clear();
            }

            if (tb_mesta.Text != null)
            {
                tb_mesta.Clear();
            }
            if (tb_skidka.Text != null)
            {
                tb_skidka.Clear();
            }
            if (tb_tsenaSkidka.Text != null)
            {
                tb_tsenaSkidka.Clear();
            }
        }

        private void FillDataGridViev()
        {
            Form1 formeditfac = (Form1)this.Owner;

            connection = new SqlConnection("Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True");
            connection.Open();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter = new SqlDataAdapter("(select Kurs.ID_Kurs, Kurs.Nazvanie_kursa, Kurs.Prodoljitelnost_kursa, Kurs.Tsena_kursa, Kurs.Kolvo_mest, Prepodavatel.Familia, Kurs.Skidka, Kurs.Tsena_so_skidkoi from Kurs, Prepodavatel where Kurs.Prepodavatel_ID = Prepodavatel.ID_Prepodavatel)", connection);
            table = new DataTable();
            adapter.Fill(table);
            formeditfac.dataGridViewKurs.DataSource = table;
            this.Close();
        } 
           private void FormEditKurs_Load(object sender, EventArgs e)
            {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchebnye_kursiDataSet40.Prepodavatel". При необходимости она может быть перемещена или удалена.
            this.prepodavatelTableAdapter2.Fill(this.uchebnye_kursiDataSet40.Prepodavatel);
            connection = new SqlConnection(@"Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True");
            connection.Open();
            

            Form1 frm = (Form1)Application.OpenForms["Form1"];
            int row = frm.dataGridViewKurs.CurrentRow.Index;
            tbID.Text = Convert.ToString(frm.dataGridViewKurs[0, row].Value);
            tb_nazvanie.Text = Convert.ToString(frm.dataGridViewKurs[1, row].Value);
            tb_prodoljitelnost.Text = Convert.ToString(frm.dataGridViewKurs[2, row].Value);
            tb_tsena.Text = Convert.ToString(frm.dataGridViewKurs[3, row].Value);
            tb_mesta.Text = Convert.ToString(frm.dataGridViewKurs[4, row].Value);
            cb_prepodavatel.Text = Convert.ToString(frm.dataGridViewKurs[5, row].Value);
            tb_skidka.Text = Convert.ToString(frm.dataGridViewKurs[6, row].Value);
            tb_tsenaSkidka.Text = Convert.ToString(frm.dataGridViewKurs[7, row].Value);


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