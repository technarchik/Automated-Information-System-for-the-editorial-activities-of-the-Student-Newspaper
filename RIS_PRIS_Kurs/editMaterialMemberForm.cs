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
    public partial class editMaterialMemberForm : Form
    {
        //string connectionString = @"Data Source=VIKTORIA\SQLEXPRESS;Initial Catalog=RIS_PRIS_test;Integrated Security=True";
        string connectionString = @"Data Source=VIKTORIA\SQLEXPRESS;Initial Catalog=RIS_PRIS_Kurs;Integrated Security=True";
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        int chosenID;
        int memberID;
        int typeForm;
        int idLastMaterial;
        int chosenWriter;
        int chosenDesigner;

        public editMaterialMemberForm(int chosenID_param, int ID_member, int Type, int LastMaterialID)
        {
            InitializeComponent();
            chosenID = chosenID_param;
            memberID = ID_member;
            typeForm = Type;
            idLastMaterial = LastMaterialID;

            if (typeForm == 2) // 2 - режим Enabled = false
            {
                // заполнение списка журналистов, ответственных за материал
                SqlConnection connection = new SqlConnection(connectionString);
                string query = "exec MembersDoMaterial @ID_material =" + chosenID + ", @ID_spec=" + 1;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connectionString);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                listWriters.DataSource = dataSet.Tables[0];
                // сокрытие ID
                listWriters.Columns[0].Visible = false;
                // доступность столбца
                listWriters.Enabled = false;
                connection.Close();

                // заполнение списка верстальщиков, ответственных за материал
                SqlConnection connection1 = new SqlConnection(connectionString);
                string query1 = "exec MembersDoMaterial @ID_material =" + chosenID + ", @ID_spec=" + 2;
                SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(query1, connectionString);
                DataSet dataSet1 = new DataSet();
                sqlDataAdapter1.Fill(dataSet1);
                listDesigners.DataSource = dataSet1.Tables[0];
                // сокрытие ID
                listDesigners.Columns[0].Visible = false;
                // доступность столбца
                listDesigners.Enabled = false;
                connection1.Close();
            }
            else if (typeForm == 1) // 1 - режим вставки только ответственных за материал
            {
                // заполнение списка журналистов, ответственных за материал
                SqlConnection connection = new SqlConnection(connectionString);
                string query = "exec MembersDoMaterial @ID_material =" + chosenID + ", @ID_spec=" + 1;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connectionString);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                listWriters.DataSource = dataSet.Tables[0];
                // сокрытие ID
                listWriters.Columns[0].Visible = false;
                connection.Close();

                // заполнение списка верстальщиков, ответственных за материал
                SqlConnection connection1 = new SqlConnection(connectionString);
                string query1 = "exec MembersDoMaterial @ID_material =" + chosenID + ", @ID_spec=" + 2;
                SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(query1, connectionString);
                DataSet dataSet1 = new DataSet();
                sqlDataAdapter1.Fill(dataSet1);
                listDesigners.DataSource = dataSet1.Tables[0];
                // сокрытие ID
                listDesigners.Columns[0].Visible = false;
                connection1.Close();
            }
            else if (typeForm == 0) // 0 - режим вставки всех участников
            {
                // заполнение списка журналистов
                SqlConnection connection = new SqlConnection(connectionString);
                string query = "select ID_member, Surname, Name, Patronymic from  Member where ID_spec = 1 and ID_position = 5";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connectionString);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                listWriters.DataSource = dataSet.Tables[0];
                // сокрытие ID
                listWriters.Columns[0].Visible = false;
                connection.Close();

                // заполнение списка верстальщиков
                SqlConnection connection1 = new SqlConnection(connectionString);
                string query1 = "select ID_member, Surname, Name, Patronymic from  Member where ID_spec = 2 and ID_position = 5";
                SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(query1, connectionString);
                DataSet dataSet1 = new DataSet();
                sqlDataAdapter1.Fill(dataSet1);
                listDesigners.DataSource = dataSet1.Tables[0];
                // сокрытие ID
                listDesigners.Columns[0].Visible = false;
                connection1.Close();
            }
        }

        private void buttonSaveMaterial_Click(object sender, EventArgs e)
        {
            // добавление/обновление участников у материала
            if (typeForm == 1)
            {
                //по id нахожу материал и ему insert в creates участников, которые выбраны
                // это изменение уже существующего то есть я делаю update где idmaterial = idLastMaterial и перезаписываю номера участников
                string sqlExpression = "update Creates set ID_member = " + chosenWriter + " where ID_material = " + idLastMaterial;
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand(sqlExpression, cnn);
                    int number = cmd.ExecuteNonQuery();
                }
                cnn.Close();

                string sqlExpression1 = "update Creates set ID_member = " + chosenDesigner + " where ID_material = " + idLastMaterial;
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand(sqlExpression1, cnn);
                    int number = cmd.ExecuteNonQuery();
                }
                cnn.Close();
                this.Close();
            }
            else if (typeForm == 0)
            {
                // 0 это создание нового то есть нужно в creates записать idmaterial = idLastMaterial и id участников
                //idLastMaterial
                string sqlExpression = "insert into Creates (ID_member, ID_material) values (" + chosenWriter + "," + idLastMaterial + ")";
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand(sqlExpression, cnn);
                    try
                    {
                        int number = cmd.ExecuteNonQuery();
                        cnn.Close();
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Необходимо выбрать людей из списка!");
                    }
                }
                

                string sqlExpression1 = "insert into Creates (ID_member, ID_material) values (" + chosenDesigner + "," + idLastMaterial + ")";
                using (SqlConnection cnn1 = new SqlConnection(connectionString))
                {
                    cnn1.Open();
                    SqlCommand cmd1 = new SqlCommand(sqlExpression1, cnn1);
                    try
                    {
                        int number = cmd1.ExecuteNonQuery();
                        cnn.Close();
                        this.Close();
                    }
                    catch
                    {
                        Console.WriteLine();
                    }
                }
            }
            
        }

        private void editMaterialMemberForm_Load(object sender, EventArgs e)
        {
            
        }

        private void listWriters_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (listWriters.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DataGridViewRow row = this.listWriters.Rows[e.RowIndex];
                    chosenWriter = Convert.ToInt32(row.Cells[0].Value);

                    //// возврат ссылки
                    //cnn = new SqlConnection(connectionString);
                    //cnn.Open();
                    //cmd.Connection = cnn;
                    //cmd.CommandText = "exec SelectLink @ID_material =" + chosenID;
                    //SqlDataReader reader = cmd.ExecuteReader();
                    //while (reader.Read())
                    //{
                    //    chosenWriter = reader["ID_member"].ToString();
                    //}
                    //reader.Close();
                    //cnn.Close();
                }
            }
            catch
            {
                Console.WriteLine();
            }
        }

        private void listDesigners_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (listDesigners.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DataGridViewRow row = this.listDesigners.Rows[e.RowIndex];
                    chosenDesigner = Convert.ToInt32(row.Cells[0].Value);

                    //// возврат ссылки
                    //cnn = new SqlConnection(connectionString);
                    //cnn.Open();
                    //cmd.Connection = cnn;
                    //cmd.CommandText = "exec SelectLink @ID_material =" + chosenID;
                    //SqlDataReader reader = cmd.ExecuteReader();
                    //while (reader.Read())
                    //{
                    //    chosenWriter = reader["ID_member"].ToString();
                    //}string sqlExpression = "update Resourse set Link = '" + update_link + "' where ID_material = " + chosenID;
                    //reader.Close();
                    //cnn.Close();
                }
            }
            catch
            {
                Console.WriteLine();
            }
        }

        private void editMaterialMemberForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string sqlExpression = "delete from Material where ID_material = " + idLastMaterial;
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sqlExpression, cnn);
                try
                {
                    int number = cmd.ExecuteNonQuery();
                    cnn.Close();
                }
                catch
                {
                    MessageBox.Show("эх");
                } 
            }
        }
    }
}
