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
    public partial class FormVhod : Form
    {
        public FormVhod()
        {
            InitializeComponent();
        }

        private void FormVhod_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Role;
            using (SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-72QVA3M\SQLEXPRESS;Initial Catalog=uchebnye_kursi;Integrated Security=True"))
            {
                sqlcon.Open();

                SqlCommand command = new SqlCommand("SELECT [User] FROM User WHERE Login = @Login and Parol = @Parol", sqlcon);
                command.Parameters.AddWithValue("@Login", tb_login.Text);
                command.Parameters.AddWithValue("@Password",tb_parol.Text);
                Role = (string)command.ExecuteScalar();
            }

            if (Role == "Администратор")
            {
                this.Hide();
                Form1 admf = new Form1();
                admf.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Предупреждение");
            }
        }
    }

}
