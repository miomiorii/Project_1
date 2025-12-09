using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class Form2 : Form
    {

        private string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= C:\\Users\\nyashka_kripper\\Desktop\\Project_1 — копия\\Project_1\\zakaz.mdb";

        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }



        private bool AddAppointmentToDatabase(string fio_master, string fio_client, string phone_number, string email, DateTime dates, string times)
        {
            using (OleDbConnection myConnection = new OleDbConnection(connectString))
            {
                try
                {
                    myConnection.Open();

                    string insertQuery = @"INSERT INTO zakazy (fio_master, fio_client, phone_number, email, dates, times) VALUES (?, ?, ?, ?, ?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand(insertQuery, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@fio_master", fio_master);
                        cmd.Parameters.AddWithValue("@fio_client", fio_client);
                        cmd.Parameters.AddWithValue("@phone_number", phone_number);
                        cmd.Parameters.AddWithValue("@email", email ?? string.Empty); // если email пустой
                        cmd.Parameters.AddWithValue("@dates", dates);
                        cmd.Parameters.AddWithValue("@times", times);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при добавлении записи: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private bool CheckAppointmentAvailability()
        {
            string fio_master = fio_master_text.Text;
            string fio_client = fio_client_text.Text;
            string phone_number = phone_number_text.Text;
            string email = email_text.Text;
            DateTime dates = dates_text.Value;
            string times = times_text.Text;

            // Проверка заполнения обязательных полей
            if (string.IsNullOrEmpty(fio_master) || string.IsNullOrEmpty(fio_client) ||
                string.IsNullOrEmpty(phone_number) || string.IsNullOrEmpty(times))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля!", "Внимание",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            using (OleDbConnection myConnection = new OleDbConnection(connectString))
            {
                try
                {
                    myConnection.Open();

                    // Проверяем, занят ли мастер на это время
                    string checkQuery = "SELECT COUNT(*) FROM zakazy WHERE fio_master = ? AND dates = ? AND times = ?";

                    using (OleDbCommand cmd = new OleDbCommand(checkQuery, myConnection))
                    {
                        cmd.Parameters.AddWithValue("@fio_master", fio_master);
                        cmd.Parameters.AddWithValue("@dates", dates);
                        cmd.Parameters.AddWithValue("@times", times);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Мастер уже занят на это время! Выберите другое время или дату.","Запись занята",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                        else
                        {
                            // Если время свободно, предлагаем записать клиента
                            DialogResult result = MessageBox.Show("Запись свободна! Хотите записать клиента?","Подтверждение записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (result == DialogResult.Yes)
                            {
                                // Добавляем запись в БД
                                if (AddAppointmentToDatabase(fio_master, fio_client, phone_number, email, dates, times))
                                {
                                    MessageBox.Show("Клиент успешно записан!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Form3 newForm = new Form3();
                                    newForm.Show();
                                    return true;
                                }
                                
                            }
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при проверке записи: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Проверка занятости записи
            CheckAppointmentAvailability();
        }

    }
}
