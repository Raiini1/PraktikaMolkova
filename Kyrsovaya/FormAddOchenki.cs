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
    public partial class FormAddOchenki : Form
    {
        
        private SqlConnection connection;
        private SqlDataAdapter adapter = null;
        private DataTable table;

        public FormAddOchenki()
        {
            InitializeComponent();
        }
        public string get_cs()
        {
            return "Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True";
        }
        private void FillDataGridViev()
        {
            FormOchenki formadd = (FormOchenki)this.Owner;

            connection = new SqlConnection("Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True");
            connection.Open();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter = new SqlDataAdapter("(select Ochenki.ID_Ochenki, Ochenki.Ochenka, Ochenki.Examen_ID from Ochenki, Examen where Ochenki.Examen_ID = Examen.ID_Examen)", connection);
            table = new DataTable();
            adapter.Fill(table);
            formadd.dataGridViewOchenki.DataSource = table;
            this.Close();
        }

        private void FormAddOchenki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchebnye_kursiDataSet50.Examen". При необходимости она может быть перемещена или удалена.
            this.examenTableAdapter1.Fill(this.uchebnye_kursiDataSet50.Examen);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchebnye_kursiDataSet25.Examen". При необходимости она может быть перемещена или удалена.
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormOchenki f1 = (FormOchenki)this.Owner;
            f1.PassID_Ochenki = tbID.Text;
            f1.PassOchenka = tb_ochenka.Text;
            f1.PassExamen_ID = cb_examen.Text;
            f1.Show();
            this.Close();



            MessageBox.Show("Вы точно хотите добавить данные в таблицу Оценки?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (!string.IsNullOrEmpty(tbID.Text) && !string.IsNullOrWhiteSpace(tbID.Text) &&
               !string.IsNullOrEmpty(tb_ochenka.Text) && !string.IsNullOrWhiteSpace(tb_ochenka.Text) &&
               !string.IsNullOrEmpty(cb_examen.Text) && !string.IsNullOrWhiteSpace(cb_examen.Text))

            {
                using (var connection = new SqlConnection(get_cs()))
                {
                    connection.Open();

                    using (var cmd = new SqlCommand("INSERT INTO [Ochenki] (ID_Ochenki, Ochenka, Examen_ID) VALUES (@ID_Ochenki, @Ochenka, @Examen_ID)", connection))

                    {
                        cmd.Parameters.AddWithValue("ID_Ochenki", tbID.Text);
                        cmd.Parameters.AddWithValue("Ochenka", tb_ochenka.Text);
                        cmd.Parameters.AddWithValue("Examen_ID", cb_examen.SelectedIndex);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                    tbID.Clear();
                    tb_ochenka.Clear();
                    
                    FillDataGridViev();

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOchenki main = new FormOchenki();
            main.ShowDialog();
            connection.Close();
        }
    }
}
