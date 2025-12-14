namespace SmtpTester
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblSmtpHost;
        private System.Windows.Forms.TextBox txtSmtpHost;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.CheckBox cbUseSsl;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRecipient;
        private System.Windows.Forms.TextBox txtRecipient;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtLog;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblSmtpHost = new System.Windows.Forms.Label();
            this.txtSmtpHost = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.cbUseSsl = new System.Windows.Forms.CheckBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRecipient = new System.Windows.Forms.Label();
            this.txtRecipient = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblBody = new System.Windows.Forms.Label();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            // 
            // Form
            // 
            this.Text = "Тестировщик Email/SMTP";
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            // 
            // lblSmtpHost
            // 
            this.lblSmtpHost.Text = "SMTP Сервер:";
            this.lblSmtpHost.Location = new System.Drawing.Point(20, 20);
            this.lblSmtpHost.AutoSize = true;
            // 
            // txtSmtpHost
            // 
            this.txtSmtpHost.Location = new System.Drawing.Point(120, 18);
            this.txtSmtpHost.Size = new System.Drawing.Size(200, 22);
            // 
            // lblPort
            // 
            this.lblPort.Text = "Порт:";
            this.lblPort.Location = new System.Drawing.Point(340, 20);
            this.lblPort.AutoSize = true;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(380, 18);
            this.txtPort.Size = new System.Drawing.Size(60, 22);
            // 
            // cbUseSsl
            // 
            this.cbUseSsl.Text = "Использовать SSL";
            this.cbUseSsl.Location = new System.Drawing.Point(460, 18);
            this.cbUseSsl.AutoSize = true;
            // 
            // lblLogin
            // 
            this.lblLogin.Text = "Логин:";
            this.lblLogin.Location = new System.Drawing.Point(20, 60);
            this.lblLogin.AutoSize = true;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(120, 58);
            this.txtLogin.Size = new System.Drawing.Size(200, 22);
            // 
            // lblPassword
            // 
            this.lblPassword.Text = "Пароль:";
            this.lblPassword.Location = new System.Drawing.Point(340, 60);
            this.lblPassword.AutoSize = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(400, 58);
            this.txtPassword.Size = new System.Drawing.Size(120, 22);
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblRecipient
            // 
            this.lblRecipient.Text = "Получатель:";
            this.lblRecipient.Location = new System.Drawing.Point(20, 100);
            this.lblRecipient.AutoSize = true;
            // 
            // txtRecipient
            // 
            this.txtRecipient.Location = new System.Drawing.Point(120, 98);
            this.txtRecipient.Size = new System.Drawing.Size(400, 22);
            // 
            // lblSubject
            // 
            this.lblSubject.Text = "Тема:";
            this.lblSubject.Location = new System.Drawing.Point(20, 140);
            this.lblSubject.AutoSize = true;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(120, 138);
            this.txtSubject.Size = new System.Drawing.Size(400, 22);
            // 
            // lblBody
            // 
            this.lblBody.Text = "Сообщение:";
            this.lblBody.Location = new System.Drawing.Point(20, 180);
            this.lblBody.AutoSize = true;
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(20, 200);
            this.txtBody.Size = new System.Drawing.Size(520, 100);
            this.txtBody.Multiline = true;
            // 
            // btnTest
            // 
            this.btnTest.Text = "Проверить соединение";
            this.btnTest.Location = new System.Drawing.Point(20, 320);
            this.btnTest.Size = new System.Drawing.Size(180, 30);
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnSend
            // 
            this.btnSend.Text = "Отправить тестовое письмо";
            this.btnSend.Location = new System.Drawing.Point(220, 320);
            this.btnSend.Size = new System.Drawing.Size(180, 30);
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(20, 370);
            this.txtLog.Size = new System.Drawing.Size(520, 100);
            this.txtLog.Multiline = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.ReadOnly = true;
            this.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                lblSmtpHost, txtSmtpHost,
                lblPort, txtPort,
                cbUseSsl,
                lblLogin, txtLogin,
                lblPassword, txtPassword,
                lblRecipient, txtRecipient,
                lblSubject, txtSubject,
                lblBody, txtBody,
                btnTest, btnSend,
                txtLog
            });
        }
    }
}
