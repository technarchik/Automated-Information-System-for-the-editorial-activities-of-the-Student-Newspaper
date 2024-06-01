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
    public partial class registrationForm : Form
    {
        //string connectionString = @"Data Source=VIKTORIA\SQLEXPRESS;Initial Catalog=RIS_PRIS_test;Integrated Security=True";
        string connectionString = @"Data Source=VIKTORIA\SQLEXPRESS;Initial Catalog=RIS_PRIS_Kurs;Integrated Security=True";
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        int ID_spec;
        int ID_position;

        public registrationForm()
        {
            InitializeComponent();
            dateOfTaking.MinDate = new DateTime(1999, 9, 1); // 01/09/1999

            // заполнение списка специализаций
            SqlConnection connection1 = new SqlConnection(connectionString);
            string query1 = "select ID_spec, Spec_name from Specialization";
            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(query1, connectionString);
            DataSet dataSet1 = new DataSet();
            sqlDataAdapter1.Fill(dataSet1);
            listSpec.DataSource = dataSet1.Tables[0];
            // сокрытие ID
            listSpec.Columns[0].Visible = false;
            // настройка 
            DataGridViewColumn column1 = listSpec.Columns[1];
            column1.Width = 167;
            listSpec.ColumnHeadersVisible = false;

            // заполнение списка позиций
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select ID_position, Position_name from Position";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connectionString);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            listPosition.DataSource = dataSet.Tables[0];
            // сокрытие ID
            listPosition.Columns[0].Visible = false;
            // настройка 
            DataGridViewColumn column = listPosition.Columns[1];
            column.Width = 160;
            listPosition.ColumnHeadersVisible = false;            
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            string Surname = textBoxSurname.Text;
            string Name = textBoxName.Text;
            string Patronymic = textBoxPatronymic.Text;
            string LinkVK = textBoxLinkVK.Text;
            string Scholarship = textBoxScholarship.Text;
            string Login = textBoxLogin.Text;
            string Pass = textBoxPass.Text;
            string PassConfirm = textBoxPassConfirm.Text;
            DateTime Birthday = dateBirthday.Value;
            DateTime Date_OfTaking = dateOfTaking.Value;

            if (textBoxSurname.Text == "" || textBoxName.Text == "" 
                || textBoxLinkVK.Text == "" || textBoxScholarship.Text == "" || textBoxLogin.Text == "" 
                || textBoxPass.Text == "" || textBoxPassConfirm.Text == "")
            {
                MessageBox.Show("Поля не заполнены!");
            }
            else
            {
                if (Pass != PassConfirm)
                {
                    MessageBox.Show("Введенные пароли не совпадают!");
                    textBoxPass.Text = "";
                    textBoxPassConfirm.Text = "";
                }
                else
                {
                    string sqlExpression = "insert into Member (ID_spec, ID_position, Surname, Name, Patronymic, Birthday, Link_VK, Date_of_taking, Scholarship, Login, Password) values (" +
                        ID_spec + "," + ID_position + ",'" + Surname + "','" + Name + "','" + Patronymic + "','" + Birthday + "','" + LinkVK + "','" + Date_OfTaking + "'," + Scholarship + ",'" + Login + "','" + Pass + "')";

                    using (SqlConnection cnn = new SqlConnection(connectionString))
                    {
                        cnn.Open();
                        SqlCommand cmd = new SqlCommand(sqlExpression, cnn);
                        int number = cmd.ExecuteNonQuery();
                    }
                    cnn.Close();

                    // переход к окну авторизации
                    this.Close();
                    authorizationForm authorizationForm = new authorizationForm();
                    authorizationForm.Show();
                }
            }
        }

        private void registrationForm_Load(object sender, EventArgs e)
        {
            // убирает дефолтные кнопки Windows
            this.ControlBox = false;
        }

        private void listSpec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (listSpec.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DataGridViewRow row = this.listSpec.Rows[e.RowIndex];
                    ID_spec = Convert.ToInt32(row.Cells[0].Value);
                }
            }
            catch
            {
                Console.WriteLine();
            }
        }

        private void listPosition_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (listPosition.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DataGridViewRow row = this.listPosition.Rows[e.RowIndex];
                    ID_position = Convert.ToInt32(row.Cells[0].Value);
                }
            }
            catch
            {
                Console.WriteLine();
            }
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            // выход из окна регистрации
            this.Close();
            authorizationForm authorizationForm = new authorizationForm();
            authorizationForm.Show();
        }
    }
}
