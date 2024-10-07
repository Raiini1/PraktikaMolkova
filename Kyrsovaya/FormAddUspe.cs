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
    public partial class FormAddUspe : Form
    {
       
        private SqlConnection connection;
        private SqlDataAdapter adapter = null;
        private DataTable table;

        public FormAddUspe()
        {
            InitializeComponent();
        }
        public string get_cs()
        {
            return "Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True";
        }
        private void FillDataGridViev()
        {
            FormUspevaemost formadd = (FormUspevaemost)this.Owner;

            connection = new SqlConnection("Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True");
            connection.Open();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter = new SqlDataAdapter("(select Uspevaemost.ID_Uspevaemost, Uspevaemost.Student_ID, Uspevaemost.Ochenki_ID from Uspevaemost)", connection);
            table = new DataTable();
            adapter.Fill(table);
            formadd.dataGridViewUspe.DataSource = table;
            this.Close();
        }


        private void FormAddUspe_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchebnye_kursiDataSet42.Ochenki". При необходимости она может быть перемещена или удалена.
            this.ochenkiTableAdapter1.Fill(this.uchebnye_kursiDataSet42.Ochenki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchebnye_kursiDataSet41.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter1.Fill(this.uchebnye_kursiDataSet41.Student);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormUspevaemost f1 = (FormUspevaemost)this.Owner;
            f1.PassID_Uspevaemost = tbID.Text;
            f1.PassStudent_ID = cb_student.Text;
            f1.PassOchenki_ID = cb_ochenki.Text;
            f1.Show();
            this.Close();



            MessageBox.Show("Вы точно хотите добавить данные в таблицу Успеваемость?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (!string.IsNullOrEmpty(tbID.Text) && !string.IsNullOrWhiteSpace(tbID.Text) &&
               !string.IsNullOrEmpty(cb_student.Text) && !string.IsNullOrWhiteSpace(cb_student.Text) &&
               !string.IsNullOrEmpty(cb_ochenki.Text) && !string.IsNullOrWhiteSpace(cb_ochenki.Text))

            {
                using (var connection = new SqlConnection(get_cs()))
                {
                    connection.Open();

                    using (var cmd = new SqlCommand("INSERT INTO [Uspevaemost] (ID_Uspevaemost, Student_ID, Ochenki_ID) VALUES (@ID_Uspevaemost, @Student_ID, @Ochenki_ID)", connection))

                    {
                        cmd.Parameters.AddWithValue("ID_Uspevaemost", tbID.Text);
                        cmd.Parameters.AddWithValue("Student_ID", cb_student.SelectedIndex);
                        cmd.Parameters.AddWithValue("Ochenki_ID", cb_ochenki.SelectedIndex);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();
                    tbID.Clear();
                 
                    FillDataGridViev();

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUspevaemost main = new FormUspevaemost();
            main.ShowDialog();
            connection.Close();
        }
    }
}
