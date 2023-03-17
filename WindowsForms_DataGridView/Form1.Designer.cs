namespace WindowsForms_DataGridView
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
            this.dGV_Musteriler = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Musteriler)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_Musteriler
            // 
            this.dGV_Musteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Musteriler.Location = new System.Drawing.Point(0, 0);
            this.dGV_Musteriler.Name = "dGV_Musteriler";
            this.dGV_Musteriler.RowHeadersWidth = 51;
            this.dGV_Musteriler.RowTemplate.Height = 24;
            this.dGV_Musteriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Musteriler.Size = new System.Drawing.Size(1229, 187);
            this.dGV_Musteriler.TabIndex = 0;
            this.dGV_Musteriler.DoubleClick += new System.EventHandler(this.dGV_Musteriler_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(365, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 332);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dGV_Musteriler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Musteriler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_Musteriler;
        private System.Windows.Forms.Button button1;
    }
}

