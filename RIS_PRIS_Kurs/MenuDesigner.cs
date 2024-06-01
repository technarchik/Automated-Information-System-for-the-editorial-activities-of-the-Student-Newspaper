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
    public partial class menuDesignerForm : Form
    {
        //string connectionString = @"Data Source=VIKTORIA\SQLEXPRESS;Initial Catalog=RIS_PRIS_test;Integrated Security=True";
        string connectionString = @"Data Source=VIKTORIA\SQLEXPRESS;Initial Catalog=RIS_PRIS_Kurs;Integrated Security=True";
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        int chosenID;
        int memberID;
        string link_resourse;

        public menuDesignerForm(String Login, String Name, String ID_member)
        {
            InitializeComponent();
            nameHello.Text = Name;
            memberID = Convert.ToInt32(ID_member);
            // вызов функции заполнения списка материалов
            fillMaterialList(memberID);
        }

        private void buttonResourse_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(link_resourse);
            }
            catch
            {
                MessageBox.Show("Не найден ресурс для этого материала!");
            }
        }

        private void menuDesignerForm_Load(object sender, EventArgs e)
        {
            // убирает дефолтные кнопки Windows
            this.ControlBox = false;
        }

        private void listBoxMaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (listBoxMaterial.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DataGridViewRow row = this.listBoxMaterial.Rows[e.RowIndex];
                    chosenID = Convert.ToInt32(row.Cells[0].Value);

                    // возврат ссылки
                    cnn = new SqlConnection(connectionString);
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "exec SelectLink @ID_material =" + chosenID;
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        link_resourse = reader["Link"].ToString();
                    }
                    reader.Close();
                    cnn.Close();

                    // возврат комментариев
                    cnn = new SqlConnection(connectionString);
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "exec SelectComments @ID_material = " + chosenID + ", @ID_member = " + memberID;
                    SqlDataReader reader1 = cmd.ExecuteReader();
                    string Short_descr = "";
                    string Long_descr = "";
                    while (reader1.Read())
                    {
                        Short_descr = reader1["Short_descr"].ToString();
                        Long_descr = reader1["Long_descr"].ToString();
                    }
                    reader1.Close();
                    cnn.Close();
                    shortDescription.Text = Short_descr;
                    longDescription.Text = Long_descr;

                    // возврат дедлайна
                    cnn = new SqlConnection(connectionString);
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "exec SelectDeadline @ID_material =" + chosenID + ", @ID_member=" + memberID;
                    SqlDataReader reader2 = cmd.ExecuteReader();
                    string deadline_material = "";
                    while (reader2.Read())
                    {
                        deadline_material = reader2[0].ToString();
                    }
                    reader2.Close();
                    cnn.Close();
                    deadline.Value = DateTime.Parse(deadline_material);

                    // TODO: цвет
                    //deadline.BackColor = System.Drawing.Color.Red;
                }
            }
            catch
            {
                Console.WriteLine();
            }
        }

        private void buttonEditMaterial_Click(object sender, EventArgs e)
        {
            //2 - режим неполного редактирования у формы
            editMaterialForm editMaterialForm = new editMaterialForm(chosenID, memberID, 2);
            editMaterialForm.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            // выход из учетной записи
            this.Close();
            authorizationForm authorizationForm = new authorizationForm();
            authorizationForm.Show();
        }

        private void buttonChangeStatus_Click(object sender, EventArgs e)
        {
            try
            {
                string short_descr = shortDescription.Text;
                string long_descr = longDescription.Text;

                string sqlExpression = "insert into Comment (ID_material, ID_author, Short_descr, Long_descr) values (" +
                    chosenID + "," + memberID + ",'" + short_descr + "','" + long_descr + "')";
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand(sqlExpression, cnn);
                    int number = cmd.ExecuteNonQuery();
                }
                cnn.Close();

                string sqlExpression1 = "exec ChangeStatus @ID_material = " + chosenID;
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand(sqlExpression1, cnn);
                    int number = cmd.ExecuteNonQuery();
                }
                cnn.Close();
                // вызов функции заполнения списка материалов
                fillMaterialList(memberID);
            }
            catch
            {
                MessageBox.Show("Чтобы передать материал, выберите его из списка материалов.");
            }
        }

        // функция заполнения списка материалов
        private void fillMaterialList(int memberID)
        {
            // заполнение списка материалов в зависимости от прав доступа
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "exec SelectHeaders @ID_member =" + memberID;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connectionString);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            listBoxMaterial.DataSource = dataSet.Tables[0];
            // сокрытие ID
            listBoxMaterial.Columns[0].Visible = false;
            // настройка ширины
            DataGridViewColumn column = listBoxMaterial.Columns[1];
            column.Width = 200;
            // название столбца
            listBoxMaterial.Columns[1].HeaderText = "Название статьи";
        }

        private void buttonChangeBack_Click(object sender, EventArgs e)
        {
            try
            {
                // не получится вернуть назад с комментарием, так как proc SelectComments работает только на чтение с нижнего уровня
                //string short_descr = shortDescription.Text;
                //string long_descr = longDescription.Text;

                //string sqlExpression = "insert into Comment (ID_material, ID_author, Short_descr, Long_descr) values (" +
                //    chosenID + "," + memberID + ",'" + short_descr + "','" + long_descr + "')";
                //using (SqlConnection cnn = new SqlConnection(connectionString))
                //{
                //    cnn.Open();
                //    SqlCommand cmd = new SqlCommand(sqlExpression, cnn);
                //    int number = cmd.ExecuteNonQuery();
                //}
                //cnn.Close();

                string sqlExpression1 = "exec ChangeStatusBack @ID_material = " + chosenID;
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand(sqlExpression1, cnn);
                    int number = cmd.ExecuteNonQuery();
                }
                cnn.Close();
                // вызов функции заполнения списка материалов
                fillMaterialList(memberID);
            }
            catch
            {
                MessageBox.Show("Чтобы вернуть материал, выберите его из списка материалов.");
            }
        }
    }
}
