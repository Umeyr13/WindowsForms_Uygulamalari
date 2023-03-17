namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bbtn_Ekle = new System.Windows.Forms.Button();
            this.Txt_Telefon = new System.Windows.Forms.TextBox();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Txt_SoyAd = new System.Windows.Forms.TextBox();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSoyAd = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstMüsteriler = new System.Windows.Forms.ListBox();
            this.bildirim1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.bbtn_Ekle);
            this.groupBox1.Controls.Add(this.Txt_Telefon);
            this.groupBox1.Controls.Add(this.Txt_Email);
            this.groupBox1.Controls.Add(this.Txt_SoyAd);
            this.groupBox1.Controls.Add(this.txt_Ad);
            this.groupBox1.Controls.Add(this.lblTelefon);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblSoyAd);
            this.groupBox1.Controls.Add(this.lblAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Müşteri Ekleme Formu";
            // 
            // bbtn_Ekle
            // 
            this.bbtn_Ekle.Location = new System.Drawing.Point(81, 145);
            this.bbtn_Ekle.Name = "bbtn_Ekle";
            this.bbtn_Ekle.Size = new System.Drawing.Size(202, 36);
            this.bbtn_Ekle.TabIndex = 4;
            this.bbtn_Ekle.Text = "Yeni Müşteri Ekle";
            this.bbtn_Ekle.UseVisualStyleBackColor = true;
            this.bbtn_Ekle.Click += new System.EventHandler(this.bbtn_Ekle_Click);
            // 
            // Txt_Telefon
            // 
            this.Txt_Telefon.Location = new System.Drawing.Point(81, 117);
            this.Txt_Telefon.Name = "Txt_Telefon";
            this.Txt_Telefon.Size = new System.Drawing.Size(202, 22);
            this.Txt_Telefon.TabIndex = 3;
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(81, 89);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(202, 22);
            this.Txt_Email.TabIndex = 2;
            // 
            // Txt_SoyAd
            // 
            this.Txt_SoyAd.Location = new System.Drawing.Point(81, 61);
            this.Txt_SoyAd.Name = "Txt_SoyAd";
            this.Txt_SoyAd.Size = new System.Drawing.Size(202, 22);
            this.Txt_SoyAd.TabIndex = 1;
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(81, 33);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(202, 22);
            this.txt_Ad.TabIndex = 0;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(6, 125);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(53, 16);
            this.lblTelefon.TabIndex = 14;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 97);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Şifre";
            // 
            // lblSoyAd
            // 
            this.lblSoyAd.AutoSize = true;
            this.lblSoyAd.Location = new System.Drawing.Point(6, 69);
            this.lblSoyAd.Name = "lblSoyAd";
            this.lblSoyAd.Size = new System.Drawing.Size(51, 16);
            this.lblSoyAd.TabIndex = 10;
            this.lblSoyAd.Text = "Soy Ad";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(6, 41);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(24, 16);
            this.lblAd.TabIndex = 8;
            this.lblAd.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Soy Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ad";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstMüsteriler);
            this.groupBox2.Location = new System.Drawing.Point(418, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 244);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Kayıtları";
            // 
            // lstMüsteriler
            // 
            this.lstMüsteriler.FormattingEnabled = true;
            this.lstMüsteriler.ItemHeight = 16;
            this.lstMüsteriler.Location = new System.Drawing.Point(6, 21);
            this.lstMüsteriler.Name = "lstMüsteriler";
            this.lstMüsteriler.Size = new System.Drawing.Size(311, 212);
            this.lstMüsteriler.TabIndex = 0;
            // 
            // bildirim1
            // 
            this.bildirim1.Text = "notifyIcon1";
            this.bildirim1.Visible = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kayıt Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 268);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bbtn_Ekle;
        private System.Windows.Forms.TextBox Txt_Telefon;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.TextBox Txt_SoyAd;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSoyAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstMüsteriler;
        private System.Windows.Forms.NotifyIcon bildirim1;
        private System.Windows.Forms.Button button1;
    }
}

