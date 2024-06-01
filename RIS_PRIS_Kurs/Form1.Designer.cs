
namespace RIS_PRIS_Kurs
{
    partial class authorizationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.registrationLink = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(206, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(98, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(98, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пароль:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(181, 201);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(216, 20);
            this.textBoxLogin.TabIndex = 4;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(181, 263);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(216, 20);
            this.textBoxPass.TabIndex = 5;
            // 
            // registrationLink
            // 
            this.registrationLink.AutoSize = true;
            this.registrationLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.registrationLink.Location = new System.Drawing.Point(433, 414);
            this.registrationLink.Name = "registrationLink";
            this.registrationLink.Size = new System.Drawing.Size(106, 20);
            this.registrationLink.TabIndex = 6;
            this.registrationLink.Text = "Регистрация";
            this.registrationLink.Click += new System.EventHandler(this.registrationLink_Click);
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.YellowGreen;
            this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.enterButton.Location = new System.Drawing.Point(211, 323);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(140, 53);
            this.enterButton.TabIndex = 7;
            this.enterButton.Text = "Войти";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(116, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 62);
            this.label4.TabIndex = 8;
            this.label4.Text = "Система автоматизации \r\nработы RIS PRIS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // authorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(557, 452);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.registrationLink);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "authorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.authorizationForm_FormClosing);
            this.Load += new System.EventHandler(this.authorizationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label registrationLink;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label label4;
    }
}

