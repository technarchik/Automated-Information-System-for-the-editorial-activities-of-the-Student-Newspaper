
namespace RIS_PRIS_Kurs
{
    partial class editMaterialMemberForm
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
            this.buttonSaveMaterial = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listWriters = new System.Windows.Forms.DataGridView();
            this.listDesigners = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listWriters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listDesigners)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSaveMaterial
            // 
            this.buttonSaveMaterial.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonSaveMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSaveMaterial.Location = new System.Drawing.Point(358, 260);
            this.buttonSaveMaterial.Name = "buttonSaveMaterial";
            this.buttonSaveMaterial.Size = new System.Drawing.Size(168, 50);
            this.buttonSaveMaterial.TabIndex = 30;
            this.buttonSaveMaterial.Text = "Сохранить";
            this.buttonSaveMaterial.UseVisualStyleBackColor = false;
            this.buttonSaveMaterial.Click += new System.EventHandler(this.buttonSaveMaterial_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label6.Location = new System.Drawing.Point(58, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 26);
            this.label6.TabIndex = 34;
            this.label6.Text = "Добавить участников";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(59, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Журналист:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(463, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Верстальщик:";
            // 
            // listWriters
            // 
            this.listWriters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listWriters.Location = new System.Drawing.Point(63, 135);
            this.listWriters.Name = "listWriters";
            this.listWriters.Size = new System.Drawing.Size(348, 95);
            this.listWriters.TabIndex = 36;
            this.listWriters.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listWriters_CellContentClick);
            // 
            // listDesigners
            // 
            this.listDesigners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listDesigners.Location = new System.Drawing.Point(467, 135);
            this.listDesigners.Name = "listDesigners";
            this.listDesigners.Size = new System.Drawing.Size(348, 95);
            this.listDesigners.TabIndex = 37;
            this.listDesigners.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listDesigners_CellContentClick);
            // 
            // editMaterialMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(876, 350);
            this.Controls.Add(this.listDesigners);
            this.Controls.Add(this.listWriters);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSaveMaterial);
            this.Name = "editMaterialMemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Окно редактирования материала - Добавить участников";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.editMaterialMemberForm_FormClosing);
            this.Load += new System.EventHandler(this.editMaterialMemberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listWriters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listDesigners)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveMaterial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listWriters;
        private System.Windows.Forms.DataGridView listDesigners;
    }
}