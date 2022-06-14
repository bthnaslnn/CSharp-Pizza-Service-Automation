namespace Pizza_Otomasyonu
{
    partial class Form6
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
            this.btn19 = new System.Windows.Forms.Button();
            this.btnMenudon = new System.Windows.Forms.Button();
            this.dgwürün = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwürün)).BeginInit();
            this.SuspendLayout();
            // 
            // btn19
            // 
            this.btn19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn19.Location = new System.Drawing.Point(121, 12);
            this.btn19.Name = "btn19";
            this.btn19.Size = new System.Drawing.Size(224, 64);
            this.btn19.TabIndex = 0;
            this.btn19.Text = "RAPOR";
            this.btn19.UseVisualStyleBackColor = true;
            this.btn19.Click += new System.EventHandler(this.btn19_Click);
            // 
            // btnMenudon
            // 
            this.btnMenudon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenudon.Location = new System.Drawing.Point(446, 12);
            this.btnMenudon.Name = "btnMenudon";
            this.btnMenudon.Size = new System.Drawing.Size(224, 64);
            this.btnMenudon.TabIndex = 4;
            this.btnMenudon.Text = "ANA MENÜYE DÖN";
            this.btnMenudon.UseVisualStyleBackColor = true;
            this.btnMenudon.Click += new System.EventHandler(this.btnMenudon_Click);
            // 
            // dgwürün
            // 
            this.dgwürün.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwürün.Location = new System.Drawing.Point(12, 82);
            this.dgwürün.Name = "dgwürün";
            this.dgwürün.Size = new System.Drawing.Size(776, 356);
            this.dgwürün.TabIndex = 5;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgwürün);
            this.Controls.Add(this.btnMenudon);
            this.Controls.Add(this.btn19);
            this.Name = "Form6";
            this.Text = "Ürün Bilgileri";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwürün)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn19;
        private System.Windows.Forms.Button btnMenudon;
        private System.Windows.Forms.DataGridView dgwürün;
    }
}