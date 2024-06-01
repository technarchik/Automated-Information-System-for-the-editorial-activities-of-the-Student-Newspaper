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
    public partial class editMaterialForm : Form
    {
        //string connectionString = @"Data Source=VIKTORIA\SQLEXPRESS;Initial Catalog=RIS_PRIS_test;Integrated Security=True";
        string connectionString = @"Data Source=VIKTORIA\SQLEXPRESS;Initial Catalog=RIS_PRIS_Kurs;Integrated Security=True";
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        int chosenID;
        int memberID;
        int typeForm;

        public editMaterialForm(int chosenID_param, int ID_member, int Type)
        {
            InitializeComponent();
            chosenID = chosenID_param;
            memberID = ID_member;
            typeForm = Type;

            // для ограничения целостности не даем выбрать дату, меньше сегодня + еще пару дней
            DateTime dateToday = DateTime.Today;
            deadlineWrite.MinDate = dateToday.AddDays(2);
            deadlineDesign.MinDate = dateToday.AddDays(2);
        }

        private void editMaterialForm_Load(object sender, EventArgs e)
        {
            if (typeForm == 2) //2 - режим неполного редактирования у формы
            {
                // возврат значений полей для выбранного материала
                cnn = new SqlConnection(connectionString);
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandText = "exec EditFormAdding @ID_material =" + chosenID;
                SqlDataReader reader = cmd.ExecuteReader();
                string Header = "";
                int N_page = 1;
                string deadline_write = "";
                string deadline_design = "";
                string link_resourse = "";
                while (reader.Read())
                {
                    Header = reader["Header"].ToString();
                    N_page = Convert.ToInt32(reader["N_page"]);
                    deadline_write = reader["Deadline_write"].ToString();
                    deadline_design = reader["Deadline_design"].ToString();
                    link_resourse = reader["Link"].ToString();
                }
                reader.Close();
                cnn.Close();

                // заполнение полей формы
                textBoxHeader.Text = Header;
                numericUpDownNpage.Value = N_page;
                try
                {
                    deadlineWrite.Value = DateTime.Parse(deadline_write);
                    deadlineDesign.Value = DateTime.Parse(deadline_design);
                }
                catch
                {
                    MessageBox.Show("Чтобы изменить материал, выберите его из списка материалов.");
                    this.Close();
                }
                textBoxLink.Text = link_resourse;
                // блокировка полей
                textBoxHeader.Enabled = false;
                numericUpDownNpage.Enabled = false;
                deadlineWrite.Enabled = false;
                deadlineDesign.Enabled = false;
            }
            else if (typeForm == 1) //1 - режим полного редактирования у формы
            {
                // возврат значений полей для выбранного материала
                cnn = new SqlConnection(connectionString);
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandText = "exec EditFormAdding @ID_material =" + chosenID;
                SqlDataReader reader = cmd.ExecuteReader();
                string Header = "";
                int N_page = 1;
                string deadline_write = "";
                string deadline_design = "";
                string link_resourse = "";
                while (reader.Read())
                {
                    Header = reader["Header"].ToString();
                    N_page = Convert.ToInt32(reader["N_page"]);
                    deadline_write = reader["Deadline_write"].ToString();
                    deadline_design = reader["Deadline_design"].ToString();
                    link_resourse = reader["Link"].ToString();
                }
                reader.Close();
                cnn.Close();

                // заполнение полей формы
                textBoxHeader.Text = Header;
                numericUpDownNpage.Value = N_page;
                // потому что ругается из-за пустого списка
                try
                {
                    deadlineWrite.Value = DateTime.Parse(deadline_write);
                    deadlineDesign.Value = DateTime.Parse(deadline_design);
                }
                catch
                {
                    MessageBox.Show("Чтобы изменить материал, выберите его из списка материалов.");
                    this.Close();
                }
                textBoxLink.Text = link_resourse;
            }
            else if (typeForm == 0) //0 - режим создания у формы
            {
                // просто пустые поля
            }
        }

        private void buttonLoadMaterial_Click(object sender, EventArgs e)
        {
            if (textBoxHeader.Text == "" || textBoxLink.Text == "")
            {
                MessageBox.Show("Поля не заполнены!");
            }
            else
            {
                if (typeForm == 2) //2 - режим неполного редактирования у формы
                {
                    string update_link = textBoxLink.Text;

                    string sqlExpression = "update Resourse set Link = '" + update_link + "' where ID_material = " + chosenID;
                    using (SqlConnection cnn = new SqlConnection(connectionString))
                    {
                        cnn.Open();
                        SqlCommand cmd = new SqlCommand(sqlExpression, cnn);
                        int number = cmd.ExecuteNonQuery();
                    }
                    cnn.Close();
                    editMaterialMemberForm editMaterialMemberForm = new editMaterialMemberForm(chosenID, memberID, 2, 0); // 0 просто чтоб не пусто
                    editMaterialMemberForm.Show();
                    this.Close();
                }
                else if (typeForm == 1) //1 - режим полного редактирования у формы
                {
                    string update_Header = textBoxHeader.Text;
                    int update_N_page = Convert.ToInt32(numericUpDownNpage.Value);
                    DateTime update_deadline_write = deadlineWrite.Value;
                    DateTime update_deadline_design = deadlineDesign.Value;
                    string update_link = textBoxLink.Text;

                    string sqlExpression = "exec UpdateMaterial @ID_material=" + chosenID + ", @Link='" + update_link +
                        "', @Header='" + update_Header + "', @N_page=" + update_N_page + ", @Deadline_write='" + update_deadline_write +
                        "', @Deadline_design='" + update_deadline_design + "'";
                    using (SqlConnection cnn = new SqlConnection(connectionString))
                    {
                        cnn.Open();
                        SqlCommand cmd = new SqlCommand(sqlExpression, cnn);
                        int number = cmd.ExecuteNonQuery();
                    }
                    cnn.Close();
                    editMaterialMemberForm editMaterialMemberForm = new editMaterialMemberForm(chosenID, memberID, 1, 0); // 0 просто чтоб не пусто
                    editMaterialMemberForm.Show();
                    this.Close();
                }
                else if (typeForm == 0) //0 - режим создания у формы
                {
                    string add_Header = textBoxHeader.Text;
                    int add_N_page = Convert.ToInt32(numericUpDownNpage.Value);
                    DateTime add_deadline_write = deadlineWrite.Value;
                    DateTime add_deadline_design = deadlineDesign.Value;

                    string sqlExpression = "exec AddMaterial @Header='" + add_Header + "', @N_page=" + add_N_page + ", @Deadline_write='" + add_deadline_write +
                        "', @Deadline_design='" + add_deadline_design + "'";
                    using (SqlConnection cnn = new SqlConnection(connectionString))
                    {
                        cnn.Open();
                        SqlCommand cmd = new SqlCommand(sqlExpression, cnn);
                        int number = cmd.ExecuteNonQuery();
                        cnn.Close();

                        // возврат id только что созданного материала
                        //cnn = new SqlConnection(connectionString);
                        cnn.Open();
                        cmd.Connection = cnn;
                        cmd.CommandText = "exec LastMaterial";
                        SqlDataReader reader = cmd.ExecuteReader();
                        int idLastMaterial = 0;
                        while (reader.Read())
                        {
                            idLastMaterial = Convert.ToInt32(reader[0]);
                        }
                        reader.Close();
                        cnn.Close();

                        editMaterialMemberForm editMaterialMemberForm = new editMaterialMemberForm(chosenID, memberID, 0, idLastMaterial);
                        editMaterialMemberForm.Show();

                        this.Close();
                    }
                }
            }
        }
    }
}
