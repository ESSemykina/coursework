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

namespace coursework
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
          
            InitializeComponent();
            this.password.AutoSize = false;
            this.password.Size = new Size(this.password.Size.Width, 37);
            name.Text = "Введите имя";
            name.ForeColor = Color.Gray;
            surname.Text = "Введите фамилию";
            surname.ForeColor = Color.Gray;
            login.Text = "Придумайте логин";
            login.ForeColor = Color.Gray;
            password.Text = "Придумайте пароль";
            password.ForeColor = Color.Gray;

        }

        private void name_Enter(object sender, EventArgs e)
        {
            if (name.Text == "Введите имя")
            {
                name.Text = "";
                name.ForeColor = Color.Black;
            }
        }

        private void name_Leave(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                name.Text = "Введите имя";
                name.ForeColor = Color.Gray;
            }
        }

        private void surname_Enter(object sender, EventArgs e)
        {
            if (surname.Text == "Введите фамилию")
            {
                surname.Text = "";
                surname.ForeColor = Color.Black;
            }
        }

        private void surname_Leave(object sender, EventArgs e)
        {
            if (surname.Text == "")
            {
                surname.Text = "Введите фамилию";
                surname.ForeColor = Color.Gray;
            }
        }

        private void login_Enter(object sender, EventArgs e)
        {
            if (login.Text == "Придумайте логин")
            {
                login.Text = "";
                login.ForeColor = Color.Black;
            }
        }

        private void login_Leave(object sender, EventArgs e)
        {
            if (login.Text == "")
            {
                login.Text = "Придумайте логин";
                login.ForeColor = Color.Gray;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Придумайте пароль")
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
                password.Text = "Придумайте пароль";
                password.ForeColor = Color.Gray;
                password.UseSystemPasswordChar = false; // Отключаем зашифровку пароля
            }
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            if (name.Text == "Введите имя")
            {
                MessageBox.Show("Введите имя!","Ошибка регистрации");
                return;
            }
            if (surname.Text == "Введите фамилию")
            {
                MessageBox.Show("Введите фамилию!","Ошибка регистрации");
                return;
            }
            if (login.Text == "Придумайте логин")
            {
                MessageBox.Show("Введите логин!", "Ошибка регистрации");
                return;
            }
            if (password.Text == "Придумайте пароль")
            {
                MessageBox.Show("Введите пароль!", "Ошибка регистрации");
                return;
            }

            if (isUserExist())
                return;

            DB db = new DB();

            SqlCommand command = new SqlCommand("INSERT INTO [User] (Логин, Пароль, Имя, Фамилия) " +
                "VALUES (@login, @password, @name, @surname)", db.getConnection());

            command.Parameters.Add("@login", SqlDbType.VarChar).Value = login.Text;
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = password.Text;
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = name.Text;
            command.Parameters.Add("@surname", SqlDbType.VarChar).Value = surname.Text;

            db.openConnetion();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Пользователь зарегистрирован.");
                this.Hide();
                TrainsForm trainsForm = new TrainsForm();
                trainsForm.Show();
            }

            else
                MessageBox.Show("Что-то пошло не так!", "Ошибка регистрации");

            db.closeConnetion();
        }

        public Boolean isUserExist()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM [User] WHERE логин = @uL", db.getConnection());

            command.Parameters.Add("@uL", SqlDbType.VarChar).Value = login.Text;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким логином уже существует! Выберите другой.", "Ошибка регистрации");
                return true;
            }
            else
                return false;
            
            
        }


    }
}
