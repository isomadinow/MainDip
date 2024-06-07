using Demo.bd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class LoginForm : Form
    {
        private MyDbContext dbContext;
        public LoginForm()
        {
            InitializeComponent();
            dbContext = new MyDbContext(DemoForm.connectionString);
        }
      
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            new RegisterForm().Show();
            this.Hide();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Проверка наличия данных в полях ввода
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                // Вывод сообщения об ошибке при пустых полях ввода
                MessageBox.Show("Имя пользователя и пароль не могут быть пустыми", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Поиск пользователя по имени пользователя (логину)
                User user = dbContext.Users.FirstOrDefault(u => u.Username == username);

                if (user != null)
                {
                    // Сверка введенного пароля с хешированным паролем из базы данных
                    string hashedPassword = PasswordHasher.HashPassword(password);

                    if (user.Password == hashedPassword)
                    {
                        // Если пароль верный, вывод сообщения об успешном входе
                        MessageBox.Show("Вход выполнен успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new DemoForm().Show();
                        this.Hide();
                    }
                    else
                    {
                        // Вывод сообщения об ошибке при неверном пароле
                        MessageBox.Show("Неверный пароль, попробуйте снова", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Вывод сообщения об ошибке при отсутствии пользователя
                    MessageBox.Show("Пользователь не найден, проверьте имя пользователя", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Вывод сообщения об ошибке в случае исключения
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkboxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';

            }
        }
    }
}
