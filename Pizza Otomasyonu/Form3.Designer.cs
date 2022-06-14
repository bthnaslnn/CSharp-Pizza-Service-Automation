namespace Pizza_Otomasyonu
{
    partial class Form3
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
            this.btn9 = new System.Windows.Forms.Button();
            this.btnMenudon = new System.Windows.Forms.Button();
            this.dgwsatış = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwsatış)).BeginInit();
            this.SuspendLayout();
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn9.Location = new System.Drawing.Point(39, 12);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(216, 63);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "Satışları Listele";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnMenudon
            // 
            this.btnMenudon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenudon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMenudon.Location = new System.Drawing.Point(546, 12);
            this.btnMenudon.Name = "btnMenudon";
            this.btnMenudon.Size = new System.Drawing.Size(216, 63);
            this.btnMenudon.TabIndex = 4;
            this.btnMenudon.Text = "ANA MENÜYE DÖN";
            this.btnMenudon.UseVisualStyleBackColor = true;
            this.btnMenudon.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgwsatış
            // 
            this.dgwsatış.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwsatış.Location = new System.Drawing.Point(-1, 101);
            this.dgwsatış.Name = "dgwsatış";
            this.dgwsatış.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwsatış.Size = new System.Drawing.Size(806, 356);
            this.dgwsatış.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(290, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 63);
            this.button1.TabIndex = 6;
            this.button1.Text = "Raporlama";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgwsatış);
            this.Controls.Add(this.btnMenudon);
            this.Controls.Add(this.btn9);
            this.Name = "Form3";
            this.Text = "Satış Kayıtları";
            ((System.ComponentModel.ISupportInitialize)(this.dgwsatış)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnMenudon;
        private System.Windows.Forms.DataGridView dgwsatış;
        private System.Windows.Forms.Button button1;
    }
}