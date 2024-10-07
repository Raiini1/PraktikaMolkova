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
    public partial class FormEditUspe : Form
    {
        public FormEditUspe()
        {
            InitializeComponent();
        }
        private SqlConnection connection;

        public string get_cs()

        {
            return "Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True";
        }

        public FormEditUspe(Form1 f)
        {
            InitializeComponent();
            f.BackColor = Color.Yellow;
        }



        private void FormEditUspe_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchebnye_kursiDataSet45.Ochenki". При необходимости она может быть перемещена или удалена.
            this.ochenkiTableAdapter1.Fill(this.uchebnye_kursiDataSet45.Ochenki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchebnye_kursiDataSet44.Student". При необходимости она может быть перемещена или удалена.
            this.studentTableAdapter1.Fill(this.uchebnye_kursiDataSet44.Student);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchebnye_kursiDataSet43.Uspevaemost". При необходимости она может быть перемещена или удалена.
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormUspevaemost f1 = (FormUspevaemost)this.Owner;

            int id = 0;
            //считывает выбранную строчку
            id = Convert.ToInt32(f1.dataGridViewUspe.Rows[f1.dataGridViewUspe.SelectedCells[0].RowIndex].Cells[0].Value);

            f1.PassID_Uspevaemost = tbID.Text;
            f1.PassStudent_ID = cb_student.Text;
            f1.PassOchenki_ID = cb_ochenki.Text;
            f1.Show();
            this.Close();



            MessageBox.Show("Вы точно хотите изменить данные таблицы Успеваемость?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (!string.IsNullOrEmpty(tbID.Text) && !string.IsNullOrWhiteSpace(tbID.Text) &&
               !string.IsNullOrEmpty(cb_student.Text) && !string.IsNullOrWhiteSpace(cb_student.Text) &&
               !string.IsNullOrEmpty(cb_ochenki.Text) && !string.IsNullOrWhiteSpace(cb_ochenki.Text))

            {
                using (var connection = new SqlConnection(get_cs()))
                {
                    connection.Open();

                    using (var cmd = new SqlCommand("UPDATE [Uspevaemost] SET [ID_Uspevaemost]=@ID, [Student_ID]=@Student_ID, [Ochenki_ID]=@Ochenki_ID WHERE ID_Uspevaemost = @ID", connection))

                    {
                        cmd.Parameters.AddWithValue("ID_Uspevaemost", tbID.Text);
                        cmd.Parameters.AddWithValue("Student_ID", cb_ochenki.SelectedIndex);
                        cmd.Parameters.AddWithValue("Ochenki_ID", cb_ochenki.SelectedIndex);

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
           
        }

        private void FillDataGridViev()
        {
            FormUspevaemost formeditfac = (FormUspevaemost)this.Owner;

            connection = new SqlConnection("Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True");
            connection.Open();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter = new SqlDataAdapter("(select Uspevaemost.ID_Uspevaemost, Uspevaemost.Student_ID, Uspevaemost.Ochenki_ID from Uspevaemost)", connection);
            table = new DataTable();
            adapter.Fill(table);
            formeditfac.dataGridViewUspe.DataSource = table;
            this.Close();
        }
    }
    
}
