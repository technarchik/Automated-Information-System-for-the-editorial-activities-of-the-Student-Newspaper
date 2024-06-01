
namespace RIS_PRIS_Kurs
{
    partial class menuWriterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nameHello = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.buttonAddMaterial = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.deadline = new System.Windows.Forms.DateTimePicker();
            this.buttonEditMaterial = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.longDescription = new System.Windows.Forms.RichTextBox();
            this.buttonChangeStatus = new System.Windows.Forms.Button();
            this.shortDescription = new System.Windows.Forms.TextBox();
            this.buttonDeleteMaterial = new System.Windows.Forms.Button();
            this.listBoxMaterial = new System.Windows.Forms.DataGridView();
            this.buttonChangeBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(46, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Здравствуйте,";
            // 
            // nameHello
            // 
            this.nameHello.AutoSize = true;
            this.nameHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.nameHello.Location = new System.Drawing.Point(201, 41);
            this.nameHello.Name = "nameHello";
            this.nameHello.Size = new System.Drawing.Size(70, 26);
            this.nameHello.TabIndex = 2;
            this.nameHello.Text = "*имя*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(47, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Работа на сегодня:";
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Silver;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.logoutButton.Location = new System.Drawing.Point(777, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(92, 39);
            this.logoutButton.TabIndex = 8;
            this.logoutButton.Text = "Выйти";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // buttonAddMaterial
            // 
            this.buttonAddMaterial.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonAddMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonAddMaterial.Location = new System.Drawing.Point(329, 140);
            this.buttonAddMaterial.Name = "buttonAddMaterial";
            this.buttonAddMaterial.Size = new System.Drawing.Size(133, 43);
            this.buttonAddMaterial.TabIndex = 10;
            this.buttonAddMaterial.Text = "Создать\r\nматериал";
            this.buttonAddMaterial.UseVisualStyleBackColor = false;
            this.buttonAddMaterial.Click += new System.EventHandler(this.buttonAddMaterial_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(521, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Дедлайн:";
            // 
            // deadline
            // 
            this.deadline.Enabled = false;
            this.deadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deadline.Location = new System.Drawing.Point(525, 142);
            this.deadline.Name = "deadline";
            this.deadline.Size = new System.Drawing.Size(211, 26);
            this.deadline.TabIndex = 23;
            // 
            // buttonEditMaterial
            // 
            this.buttonEditMaterial.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonEditMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonEditMaterial.Location = new System.Drawing.Point(329, 189);
            this.buttonEditMaterial.Name = "buttonEditMaterial";
            this.buttonEditMaterial.Size = new System.Drawing.Size(133, 43);
            this.buttonEditMaterial.TabIndex = 24;
            this.buttonEditMaterial.Text = "Редактировать\r\nматериал";
            this.buttonEditMaterial.UseVisualStyleBackColor = false;
            this.buttonEditMaterial.Click += new System.EventHandler(this.buttonEditMaterial_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(49, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Комментарии:";
            // 
            // longDescription
            // 
            this.longDescription.Location = new System.Drawing.Point(51, 378);
            this.longDescription.Name = "longDescription";
            this.longDescription.Size = new System.Drawing.Size(411, 96);
            this.longDescription.TabIndex = 29;
            this.longDescription.Text = "Развернутый комментарий";
            // 
            // buttonChangeStatus
            // 
            this.buttonChangeStatus.BackColor = System.Drawing.Color.LightCoral;
            this.buttonChangeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonChangeStatus.Location = new System.Drawing.Point(651, 418);
            this.buttonChangeStatus.Name = "buttonChangeStatus";
            this.buttonChangeStatus.Size = new System.Drawing.Size(218, 56);
            this.buttonChangeStatus.TabIndex = 31;
            this.buttonChangeStatus.Text = "Передать";
            this.buttonChangeStatus.UseVisualStyleBackColor = false;
            this.buttonChangeStatus.Click += new System.EventHandler(this.buttonChangeStatus_Click);
            // 
            // shortDescription
            // 
            this.shortDescription.Location = new System.Drawing.Point(51, 352);
            this.shortDescription.Name = "shortDescription";
            this.shortDescription.Size = new System.Drawing.Size(411, 20);
            this.shortDescription.TabIndex = 32;
            this.shortDescription.Text = "Короткий комментарий";
            // 
            // buttonDeleteMaterial
            // 
            this.buttonDeleteMaterial.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDeleteMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonDeleteMaterial.Location = new System.Drawing.Point(329, 238);
            this.buttonDeleteMaterial.Name = "buttonDeleteMaterial";
            this.buttonDeleteMaterial.Size = new System.Drawing.Size(133, 43);
            this.buttonDeleteMaterial.TabIndex = 33;
            this.buttonDeleteMaterial.Text = "Удалить\r\nматериал";
            this.buttonDeleteMaterial.UseVisualStyleBackColor = false;
            this.buttonDeleteMaterial.Click += new System.EventHandler(this.buttonDeleteMaterial_Click);
            // 
            // listBoxMaterial
            // 
            this.listBoxMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listBoxMaterial.Location = new System.Drawing.Point(51, 142);
            this.listBoxMaterial.Name = "listBoxMaterial";
            this.listBoxMaterial.ReadOnly = true;
            this.listBoxMaterial.Size = new System.Drawing.Size(243, 136);
            this.listBoxMaterial.TabIndex = 34;
            this.listBoxMaterial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listBoxMaterial_CellContentClick);
            // 
            // buttonChangeBack
            // 
            this.buttonChangeBack.BackColor = System.Drawing.Color.Silver;
            this.buttonChangeBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonChangeBack.Location = new System.Drawing.Point(525, 418);
            this.buttonChangeBack.Name = "buttonChangeBack";
            this.buttonChangeBack.Size = new System.Drawing.Size(111, 56);
            this.buttonChangeBack.TabIndex = 35;
            this.buttonChangeBack.Text = "Вернуть назад";
            this.buttonChangeBack.UseVisualStyleBackColor = false;
            this.buttonChangeBack.Click += new System.EventHandler(this.buttonChangeBack_Click);
            // 
            // menuWriterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(892, 498);
            this.Controls.Add(this.buttonChangeBack);
            this.Controls.Add(this.listBoxMaterial);
            this.Controls.Add(this.buttonDeleteMaterial);
            this.Controls.Add(this.shortDescription);
            this.Controls.Add(this.buttonChangeStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.longDescription);
            this.Controls.Add(this.buttonEditMaterial);
            this.Controls.Add(this.deadline);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAddMaterial);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameHello);
            this.Controls.Add(this.label1);
            this.Name = "menuWriterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню журналиста";
            this.Load += new System.EventHandler(this.menuWriterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxMaterial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameHello;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button buttonAddMaterial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker deadline;
        private System.Windows.Forms.Button buttonEditMaterial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox longDescription;
        private System.Windows.Forms.Button buttonChangeStatus;
        private System.Windows.Forms.TextBox shortDescription;
        private System.Windows.Forms.Button buttonDeleteMaterial;
        private System.Windows.Forms.DataGridView listBoxMaterial;
        private System.Windows.Forms.Button buttonChangeBack;
    }
}