using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace MPT_PC_DB
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        public static int RandomCode;
        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                RandomCode = rnd.Next(100000, 1000000);
                // отправитель - устанавливаем адрес и отображаемое в письме имя
                MailAddress from = new MailAddress("nikitafreezo@yandex.ru", "Nikita");
                // кому отправляем
                MailAddress to = new MailAddress(emailTextBox.Text);
                // создаем объект сообщения
                MailMessage m = new MailMessage(from, to);
                // тема письма
                m.Subject = "<h2>Код для регистрации</h2>";
                // текст письма
                m.Body = "Ваш код: " + RandomCode.ToString();
                // письмо представляет код html
                m.IsBodyHtml = true;
                // адрес smtp-сервера и порт, с которого будем отправлять письмо
                SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 25);
                // логин и пароль
                smtp.Credentials = new NetworkCredential("nikitafreezo@yandex.ru", "POROL111");
                smtp.EnableSsl = true;
                smtp.Send(m);

                EmailCodeCheck emailCheck = new EmailCodeCheck();
                emailCheck.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
