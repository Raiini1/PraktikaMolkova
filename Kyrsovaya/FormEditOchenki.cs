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
    public partial class FormEditOchenki : Form
    {
        public FormEditOchenki()
        {
            InitializeComponent();
        }
        private SqlConnection connection;

        public string get_cs()

        {
            return "Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True";
        }

        public FormEditOchenki(Form1 f)
        {
            InitializeComponent();
            f.BackColor = Color.Yellow;
        }


        private void FormEditOchenki_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchebnye_kursiDataSet51.Examen". При необходимости она может быть перемещена или удалена.
            this.examenTableAdapter1.Fill(this.uchebnye_kursiDataSet51.Examen);
            connection = new SqlConnection(@"Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True");
            connection.Open();


            FormOchenki frm = (FormOchenki)Application.OpenForms["FormOchenki"];
            int row = frm.dataGridViewOchenki.CurrentRow.Index;
            tbID.Text = Convert.ToString(frm.dataGridViewOchenki[0, row].Value);
            tb_ochenka.Text = Convert.ToString(frm.dataGridViewOchenki[1, row].Value);
            cb_examen.Text = Convert.ToString(frm.dataGridViewOchenki[2, row].Value);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormOchenki f1 = (FormOchenki)this.Owner;

            int id = 0;
            //считывает выбранную строчку
            id = Convert.ToInt32(f1.dataGridViewOchenki.Rows[f1.dataGridViewOchenki.SelectedCells[0].RowIndex].Cells[0].Value);

            f1.PassID_Ochenki = tbID.Text;
            f1.PassOchenka = tb_ochenka.Text;
            f1.PassExamen_ID = cb_examen.Text;
            f1.Show();
            this.Close();



            MessageBox.Show("Вы точно хотите изменить данные таблицы Оценки?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (!string.IsNullOrEmpty(tbID.Text) && !string.IsNullOrWhiteSpace(tbID.Text) &&
               !string.IsNullOrEmpty(tb_ochenka.Text) && !string.IsNullOrWhiteSpace(tb_ochenka.Text) &&
               !string.IsNullOrEmpty(cb_examen.Text) && !string.IsNullOrWhiteSpace(cb_examen.Text))
          

            {
                using (var connection = new SqlConnection(get_cs()))
                {
                    connection.Open();

                    using (var cmd = new SqlCommand("UPDATE [Ochenki] SET [ID_Ochenki]=@ID, [Ochenka]=@Ochenka, [Examen_ID]=@Examen_ID WHERE ID_Ochenki = @ID", connection))

                    {
                        cmd.Parameters.AddWithValue("ID_Ochenki", tbID.Text);
                        cmd.Parameters.AddWithValue("Ochenka", tb_ochenka.Text);
                        cmd.Parameters.AddWithValue("Examen_ID", cb_examen.SelectedIndex);

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
            if (tb_ochenka.Text != null)
            {
                tb_ochenka.Clear();
            }
        }

        private void FillDataGridViev()
        {
            FormOchenki formeditfac = (FormOchenki)this.Owner;

            connection = new SqlConnection("Data Source=DESKTOP-PIJC67J;Initial Catalog=uchebnye_kursi;Integrated Security=True");
            connection.Open();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter = new SqlDataAdapter("((select Ochenki.ID_Ochenki, Ochenki.Ochenka, Ochenki.Examen_ID from Ochenki, Examen where Ochenki.Examen_ID = Examen.ID_Examen)", connection);
            table = new DataTable();
            adapter.Fill(table);
            formeditfac.dataGridViewOchenki.DataSource = table;
            this.Close();
        }
    }
}
