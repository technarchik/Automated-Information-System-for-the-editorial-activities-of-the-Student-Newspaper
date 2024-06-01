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

namespace RIS_PRIS_Kurs
{
    public partial class authorizationForm : Form
    {
        //string connectionString = @"Data Source=VIKTORIA\SQLEXPRESS;Initial Catalog=RIS_PRIS_test;Integrated Security=True";
        string connectionString = @"Data Source=VIKTORIA\SQLEXPRESS;Initial Catalog=RIS_PRIS_Kurs;Integrated Security=True";
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        string ID_spec = "";
        string Login = "";
        string Password = "";
        string Name = "";
        string ID_member;

        public authorizationForm()
        {
            InitializeComponent();
            // Создание подключения
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                // Открываем подключение
                connection.Open();
                Console.WriteLine("Подключение открыто");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //ПОТОМ УБРАТЬ!!!
            textBoxLogin.Text = "Nastya";
            textBoxPass.Text = "123";
        }

        private void authorizationForm_Load(object sender, EventArgs e)
        {
            
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            // переход к меню
            string login = textBoxLogin.Text;
            string pass = textBoxPass.Text;
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            cmd.Connection = cnn;
            //команды
            cmd.CommandText = "SELECT * FROM Member WHERE Login = '" + login + "'";
            //вставляем команду и получаем объект DataReader
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ID_spec = reader["ID_spec"].ToString();
                Login = reader["Login"].ToString();
                Password = reader["Password"].ToString();
                Name = reader["Name"].ToString();
                ID_member = reader["ID_member"].ToString();
            }
            //закрыть DataReader
            reader.Close();
            cnn.Close();
            pass = pass.Replace(" ", "");
            Password = Password.Replace(" ", "");
            if (textBoxPass.Text != Password && textBoxLogin.Text == Login)
            {
                MessageBox.Show("Пароль введен неверно!");
                textBoxPass.Text = "";
                
            }
            else if (textBoxLogin.Text != Login)
            {
                MessageBox.Show("Убедитесь, что логин введен верно, либо зарегистрируйтесь в системе.");
                textBoxPass.Text = "";
                registrationLink.ForeColor = Color.Green;
            }
            else if (textBoxPass.Text == Password && textBoxLogin.Text == Login)
            {
                // определяем формат ЛК
                if (ID_spec == "2")
                {
                    menuDesignerForm menuDesignerForm = new menuDesignerForm(Login, Name, ID_member);
                    menuDesignerForm.Show();
                    this.Visible = false;
                }
                else
                {
                    menuWriterForm menuWriterForm = new menuWriterForm(Login, Name, ID_member);
                    menuWriterForm.Show();
                    this.Visible = false;
                }
            }
        }

        private void registrationLink_Click(object sender, EventArgs e)
        {
            // переход к регистрации DONE
            registrationForm registrationForm = new registrationForm();
            registrationForm.Show();
            this.Visible = false;
        }

        private void authorizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // чтобы из-за Visible=false самой первой формы прога не повисла
            Application.Exit();
        }
    }
}
