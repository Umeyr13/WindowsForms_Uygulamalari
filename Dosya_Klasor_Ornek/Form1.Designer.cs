namespace Dosya_Klasor_Ornek
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Prsl_Kaydet = new System.Windows.Forms.Button();
            this.button_Liste = new System.Windows.Forms.Button();
            this.list_Personel = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Prsl_Kaydet);
            this.groupBox1.Controls.Add(this.button_Liste);
            this.groupBox1.Controls.Add(this.list_Personel);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(392, 365);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Listesi";
            // 
            // button_Prsl_Kaydet
            // 
            this.button_Prsl_Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Prsl_Kaydet.Location = new System.Drawing.Point(303, 94);
            this.button_Prsl_Kaydet.Name = "button_Prsl_Kaydet";
            this.button_Prsl_Kaydet.Size = new System.Drawing.Size(89, 58);
            this.button_Prsl_Kaydet.TabIndex = 1;
            this.button_Prsl_Kaydet.Text = "Personel Kaydet";
            this.button_Prsl_Kaydet.UseVisualStyleBackColor = true;
            this.button_Prsl_Kaydet.Click += new System.EventHandler(this.button_Prsl_Kaydet_Click);
            // 
            // button_Liste
            // 
            this.button_Liste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Liste.Location = new System.Drawing.Point(303, 30);
            this.button_Liste.Name = "button_Liste";
            this.button_Liste.Size = new System.Drawing.Size(89, 58);
            this.button_Liste.TabIndex = 2;
            this.button_Liste.Text = "Personel Getir";
            this.button_Liste.UseVisualStyleBackColor = true;
            this.button_Liste.Click += new System.EventHandler(this.button_Liste_Click);
            // 
            // list_Personel
            // 
            this.list_Personel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.list_Personel.FormattingEnabled = true;
            this.list_Personel.ItemHeight = 20;
            this.list_Personel.Location = new System.Drawing.Point(8, 33);
            this.list_Personel.Name = "list_Personel";
            this.list_Personel.Size = new System.Drawing.Size(289, 304);
            this.list_Personel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 395);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Prsl_Kaydet;
        private System.Windows.Forms.Button button_Liste;
        private System.Windows.Forms.ListBox list_Personel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

