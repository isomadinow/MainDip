using Demo.bd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class RegisterForm : Form
    {
        private MyDbContext dbContext;
        public RegisterForm()
        {
            InitializeComponent();
         
        dbContext = new MyDbContext(DemoForm.connectionString);
    }
    
        private void clearButton_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtComPassword.Text = "";
            txtUsername.Focus();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtComPassword.Text == "")
            {
                // Вывод сообщения об ошибке при пустых полях ввода
                MessageBox.Show("Имя пользователя и пароль не могут быть пустыми", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
       
            }
            else if (txtPassword.Text == txtComPassword.Text)
            {
                try
                {
                    // Хешируем пароль перед сохранением в базу данных
                    string hashedPassword = PasswordHasher.HashPassword(txtPassword.Text);

                    // Создаем новый пользователь
                    User newUser = new User
                    {
                        Username = txtUsername.Text,
                        Password = hashedPassword
                    };

                    // Добавляем пользователя в DbSet и сохраняем изменения в базе данных
                    dbContext.Users.Add(newUser);
                    dbContext.SaveChanges();

                    MessageBox.Show("Регистрация выполнена успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Очищаем текстовые поля после успешной регистрации
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtComPassword.Text = "";
                    new LoginForm().Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Пароли не совпадают, пожалуйста, введите заново", "Регистрация не удалась", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtComPassword.Text = "";
                txtPassword.Text = "";
                txtPassword.Focus();
            }
        }


        private void checkboxShowPass_CheckedChanged(object sender, EventArgs e)
        {

            if (checkboxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';

            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtComPassword.PasswordChar = '*';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }
    }
    public static class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
    }
}
