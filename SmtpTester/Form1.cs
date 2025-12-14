using System.Net;
using System.Net.Mail;

namespace SmtpTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Log(string message)
        {
            txtLog.AppendText($"{DateTime.Now:HH:mm:ss} - {message}\r\n");
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                Log("Проверка соединения...");
                var client = new SmtpClient(txtSmtpHost.Text, int.Parse(txtPort.Text))
                {
                    EnableSsl = cbUseSsl.Checked,
                    Credentials = new NetworkCredential(txtLogin.Text, txtPassword.Text),
                    Timeout = 5000
                };
                client.Send(new MailMessage(txtLogin.Text, txtRecipient.Text, "Тестовое соединение", "Тестовое письмо"));
                Log("Соединение успешно и письмо отправлено!");
                MessageBox.Show("Соединение успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Log($"{ex.Message}");
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                Log("Отправка тестового письма...");
                var client = new SmtpClient(txtSmtpHost.Text, int.Parse(txtPort.Text))
                {
                    EnableSsl = cbUseSsl.Checked,
                    Credentials = new NetworkCredential(txtLogin.Text, txtPassword.Text),
                    Timeout = 5000
                };
                client.Send(new MailMessage(txtLogin.Text, txtRecipient.Text, txtSubject.Text, txtBody.Text));
                Log("Письмо успешно отправлено!");
                MessageBox.Show("Письмо отправлено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Log($"{ex.Message}");
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
