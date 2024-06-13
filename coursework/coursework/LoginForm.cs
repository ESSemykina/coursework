using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.password.AutoSize = false;
            this.password.Size = new Size(this.password.Size.Width, 37);
            login.Text = "Введите логин";
            login.ForeColor = Color.Gray;
            password.Text = "Введите пароль";
            password.ForeColor = Color.Gray;
        }

        private void login_Enter(object sender, EventArgs e)
        {
            if (login.Text == "Введите логин")
            {
                login.Text = "";
                login.ForeColor = Color.Black;
            }
        }

        private void login_Leave(object sender, EventArgs e)
        {
            if (login.Text == "")
            {
                login.Text = "Введите логин";
                login.ForeColor = Color.Gray;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Введите пароль")
            {
                password.Text = "";
                password.ForeColor = Color.Black;
                password.UseSystemPasswordChar = true; // Включаем зашифровку пароля
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
          
            if (password.Text == "")
            {
                password.Text = "Введите пароль";
                password.ForeColor = Color.Gray;
                password.UseSystemPasswordChar = false; // Отключаем зашифровку пароля

            }
        }

        private void registration_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            String loginUser = login.Text;
            String passwordUser = password.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM [User] WHERE логин = @uL AND пароль = @uP", 
                db.getConnection());

            command.Parameters.Add("@uL", SqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", SqlDbType.VarChar).Value = passwordUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                TrainsForm trainsForm = new TrainsForm();
                trainsForm.Show();
            }
            else
                MessageBox.Show("Неверный логин или пароль", "Ошибка входа");
            
        }

       
    }
}
