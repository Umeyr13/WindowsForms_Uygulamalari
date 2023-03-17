namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Kullaniciadi = new System.Windows.Forms.TextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(34, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // txt_Kullaniciadi
            // 
            this.txt_Kullaniciadi.BackColor = System.Drawing.Color.White;
            this.txt_Kullaniciadi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Kullaniciadi.Location = new System.Drawing.Point(150, 8);
            this.txt_Kullaniciadi.Name = "txt_Kullaniciadi";
            this.txt_Kullaniciadi.Size = new System.Drawing.Size(140, 22);
            this.txt_Kullaniciadi.TabIndex = 0;
            this.txt_Kullaniciadi.Enter += new System.EventHandler(this.txt_Kullaniciadi_Enter);
            this.txt_Kullaniciadi.Leave += new System.EventHandler(this.txt_Kullaniciadi_Leave);
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.BackColor = System.Drawing.Color.White;
            this.txt_Sifre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Sifre.Location = new System.Drawing.Point(150, 44);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.PasswordChar = '₺';
            this.txt_Sifre.Size = new System.Drawing.Size(140, 22);
            this.txt_Sifre.TabIndex = 1;
            this.txt_Sifre.Enter += new System.EventHandler(this.txt_Kullaniciadi_Enter);
            this.txt_Sifre.Leave += new System.EventHandler(this.txt_Kullaniciadi_Leave);
            // 
            // btn_giris
            // 
            this.btn_giris.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_giris.Location = new System.Drawing.Point(150, 86);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(140, 36);
            this.btn_giris.TabIndex = 2;
            this.btn_giris.Text = "GİRİŞ";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(314, 146);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_Kullaniciadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Kullaniciadi;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Button btn_giris;
    }
}

