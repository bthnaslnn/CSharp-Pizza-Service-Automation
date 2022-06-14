namespace Pizza_Otomasyonu
{
    partial class Form4
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
            this.btn14 = new System.Windows.Forms.Button();
            this.btnMenudon = new System.Windows.Forms.Button();
            this.dgwsiparis = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwsiparis)).BeginInit();
            this.SuspendLayout();
            // 
            // btn14
            // 
            this.btn14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn14.Location = new System.Drawing.Point(126, 12);
            this.btn14.Name = "btn14";
            this.btn14.Size = new System.Drawing.Size(227, 62);
            this.btn14.TabIndex = 3;
            this.btn14.Text = "RAPOR";
            this.btn14.UseVisualStyleBackColor = true;
            this.btn14.Click += new System.EventHandler(this.btn14_Click);
            // 
            // btnMenudon
            // 
            this.btnMenudon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenudon.Location = new System.Drawing.Point(429, 12);
            this.btnMenudon.Name = "btnMenudon";
            this.btnMenudon.Size = new System.Drawing.Size(237, 62);
            this.btnMenudon.TabIndex = 4;
            this.btnMenudon.Text = "ANA MENÜYE DÖN";
            this.btnMenudon.UseVisualStyleBackColor = true;
            this.btnMenudon.Click += new System.EventHandler(this.btnMenudon_Click);
            // 
            // dgwsiparis
            // 
            this.dgwsiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwsiparis.Location = new System.Drawing.Point(12, 80);
            this.dgwsiparis.Name = "dgwsiparis";
            this.dgwsiparis.Size = new System.Drawing.Size(776, 358);
            this.dgwsiparis.TabIndex = 5;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgwsiparis);
            this.Controls.Add(this.btnMenudon);
            this.Controls.Add(this.btn14);
            this.Name = "Form4";
            this.Text = "Siparişler";
            ((System.ComponentModel.ISupportInitialize)(this.dgwsiparis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn14;
        private System.Windows.Forms.Button btnMenudon;
        private System.Windows.Forms.DataGridView dgwsiparis;
    }
}