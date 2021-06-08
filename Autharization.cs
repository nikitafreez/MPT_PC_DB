using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Data.SQLite;
using System.IO;

namespace MPT_PC_DB
{
    public partial class Autharization : Form
    {
        public static int Role;
        public Autharization()
        {
            InitializeComponent();

            string connectionString = $"Data Source={dbFileName};Version=3";
            connection = new SQLiteConnection(connectionString);

            CreateDB();
        }

        private void Autharization_Load(object sender, EventArgs e)
        {

        }

        private void guestButton_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
            Role = 0;
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Hide();
        }

        private void sendMailButton_Click(object sender, EventArgs e)
        {
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("nikitafreezo@yandex.ru", "Nikita");
            // кому отправляем
            MailAddress to = new MailAddress("NikitaFreez@yandex.ru");
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "123456";
            // текст письма
            m.Body = "<h2>Письмо-тест работы smtp-клиента</h2>";
            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 25);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("nikitafreezo@yandex.ru", "POROL111");
            smtp.EnableSsl = true;
            smtp.Send(m);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private SQLiteConnection connection;
        private SQLiteCommand command;
        private SQLiteDataReader reader;
        private string dbFileName = "MoneyStat.db";
        private void CreateDB()
        {
            if (!File.Exists(dbFileName)) //Если БД не существует
            {
                try
                {
                    connection.Open();

                    command = new SQLiteCommand();
                    command.Connection = connection;
                    command.CommandText = "CREATE TABLE IF NOT EXISTS PC(" +
                        "ID_PC INTEGER PRIMARY KEY AUTOINCREMENT," +
                        "GraphicCard_Name VARCHAR," +
                        "Processor_Name VARCHAR," +
                        "OZU_Amount INTEGER," +
                        "HDD_Amount INTEGER," +
                        "OS_Name VARCHAR," +
                        "Building_Name VARCHAR," +
                        "Cabinet_Num INTEGER," +
                        "Programm_List VARCHAR);";
                    command.ExecuteNonQuery();

                    command = new SQLiteCommand();
                    command.Connection = connection;
                    command.CommandText = "CREATE TABLE IF NOT EXISTS Users(" +
                        "ID_User INTEGER PRIMARY KEY AUTOINCREMENT," +
                        "Login VARCHAR," +
                        "Password VARCHAR)";
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
