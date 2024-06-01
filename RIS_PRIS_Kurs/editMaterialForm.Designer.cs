
namespace RIS_PRIS_Kurs
{
    partial class editMaterialForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deadlineWrite = new System.Windows.Forms.DateTimePicker();
            this.deadlineDesign = new System.Windows.Forms.DateTimePicker();
            this.textBoxHeader = new System.Windows.Forms.TextBox();
            this.numericUpDownNpage = new System.Windows.Forms.NumericUpDown();
            this.textBoxLink = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonLoadMaterial = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNpage)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(61, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Заголовок:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(61, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Номер полосы:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(61, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дедлайн\r\nжурналиста:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(324, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 40);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дедлайн\r\nверстальщика:";
            // 
            // deadlineWrite
            // 
            this.deadlineWrite.Location = new System.Drawing.Point(65, 224);
            this.deadlineWrite.MinDate = new System.DateTime(2022, 12, 21, 0, 0, 0, 0);
            this.deadlineWrite.Name = "deadlineWrite";
            this.deadlineWrite.Size = new System.Drawing.Size(172, 20);
            this.deadlineWrite.TabIndex = 23;
            // 
            // deadlineDesign
            // 
            this.deadlineDesign.Location = new System.Drawing.Point(328, 224);
            this.deadlineDesign.Name = "deadlineDesign";
            this.deadlineDesign.Size = new System.Drawing.Size(172, 20);
            this.deadlineDesign.TabIndex = 24;
            // 
            // textBoxHeader
            // 
            this.textBoxHeader.Location = new System.Drawing.Point(202, 79);
            this.textBoxHeader.Name = "textBoxHeader";
            this.textBoxHeader.Size = new System.Drawing.Size(298, 20);
            this.textBoxHeader.TabIndex = 25;
            // 
            // numericUpDownNpage
            // 
            this.numericUpDownNpage.Location = new System.Drawing.Point(202, 123);
            this.numericUpDownNpage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNpage.Name = "numericUpDownNpage";
            this.numericUpDownNpage.Size = new System.Drawing.Size(104, 20);
            this.numericUpDownNpage.TabIndex = 26;
            this.numericUpDownNpage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxLink
            // 
            this.textBoxLink.Location = new System.Drawing.Point(172, 287);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(328, 40);
            this.textBoxLink.TabIndex = 27;
            this.textBoxLink.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(61, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 40);
            this.label5.TabIndex = 28;
            this.label5.Text = "Ссылка\r\nна ресурсы:";
            // 
            // buttonLoadMaterial
            // 
            this.buttonLoadMaterial.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonLoadMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonLoadMaterial.Location = new System.Drawing.Point(428, 357);
            this.buttonLoadMaterial.Name = "buttonLoadMaterial";
            this.buttonLoadMaterial.Size = new System.Drawing.Size(133, 35);
            this.buttonLoadMaterial.TabIndex = 29;
            this.buttonLoadMaterial.Text = "Далее";
            this.buttonLoadMaterial.UseVisualStyleBackColor = false;
            this.buttonLoadMaterial.Click += new System.EventHandler(this.buttonLoadMaterial_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label6.Location = new System.Drawing.Point(60, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(353, 26);
            this.label6.TabIndex = 30;
            this.label6.Text = "Окно редактирования материала";
            // 
            // editMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(583, 414);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonLoadMaterial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxLink);
            this.Controls.Add(this.numericUpDownNpage);
            this.Controls.Add(this.textBoxHeader);
            this.Controls.Add(this.deadlineDesign);
            this.Controls.Add(this.deadlineWrite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "editMaterialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно редактирования материала";
            this.Load += new System.EventHandler(this.editMaterialForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNpage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker deadlineWrite;
        private System.Windows.Forms.DateTimePicker deadlineDesign;
        private System.Windows.Forms.TextBox textBoxHeader;
        private System.Windows.Forms.NumericUpDown numericUpDownNpage;
        private System.Windows.Forms.RichTextBox textBoxLink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonLoadMaterial;
        private System.Windows.Forms.Label label6;
    }
}