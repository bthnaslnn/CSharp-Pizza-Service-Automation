namespace Pizza_Otomasyonu
{
    partial class Form9
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
            this.textBox1k = new System.Windows.Forms.TextBox();
            this.textBox2k = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnkayıtol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(176, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(250, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // textBox1k
            // 
            this.textBox1k.Location = new System.Drawing.Point(343, 160);
            this.textBox1k.Name = "textBox1k";
            this.textBox1k.Size = new System.Drawing.Size(125, 20);
            this.textBox1k.TabIndex = 2;
            // 
            // textBox2k
            // 
            this.textBox2k.Location = new System.Drawing.Point(343, 235);
            this.textBox2k.Name = "textBox2k";
            this.textBox2k.Size = new System.Drawing.Size(125, 20);
            this.textBox2k.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label3.Location = new System.Drawing.Point(229, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "KAYIT OLMA EKRANI";
            // 
            // btnkayıtol
            // 
            this.btnkayıtol.Location = new System.Drawing.Point(343, 301);
            this.btnkayıtol.Name = "btnkayıtol";
            this.btnkayıtol.Size = new System.Drawing.Size(125, 48);
            this.btnkayıtol.TabIndex = 5;
            this.btnkayıtol.Text = "KAYIT OL";
            this.btnkayıtol.UseVisualStyleBackColor = true;
            this.btnkayıtol.Click += new System.EventHandler(this.btnkayıtol_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnkayıtol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2k);
            this.Controls.Add(this.textBox1k);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1k;
        private System.Windows.Forms.TextBox textBox2k;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnkayıtol;
    }
}