using System;

namespace Pizza_Otomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.lbl3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnkayıt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("MS Reference Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1.Location = new System.Drawing.Point(197, 113);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(170, 28);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Kullanıcı Adı :";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBox1
            // 
            this.txtBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtBox1.Location = new System.Drawing.Point(406, 114);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(129, 29);
            this.txtBox1.TabIndex = 1;
            this.txtBox1.TextChanged += new System.EventHandler(this.txtBox1_TextChanged);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("MS Reference Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl2.Location = new System.Drawing.Point(197, 168);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(84, 28);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Şifre :";
            this.lbl2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtBox2
            // 
            this.txtBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtBox2.Location = new System.Drawing.Point(406, 178);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(129, 29);
            this.txtBox2.TabIndex = 3;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(202, 252);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(144, 73);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "GİRİŞ";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl3.Location = new System.Drawing.Point(173, 38);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(449, 33);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "Pizza Otomasyonu Giriş Paneli";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(406, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 73);
            this.button1.TabIndex = 6;
            this.button1.Text = "ÇIKIŞ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnkayıt
            // 
            this.btnkayıt.Location = new System.Drawing.Point(321, 350);
            this.btnkayıt.Name = "btnkayıt";
            this.btnkayıt.Size = new System.Drawing.Size(144, 73);
            this.btnkayıt.TabIndex = 7;
            this.btnkayıt.Text = "KAYIT OL";
            this.btnkayıt.UseVisualStyleBackColor = true;
            this.btnkayıt.Click += new System.EventHandler(this.btnkayıt_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnkayıt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Pizza Çalışan Paneli";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnkayıt;
        private EventHandler btnkayıt_Click;
    }
}

