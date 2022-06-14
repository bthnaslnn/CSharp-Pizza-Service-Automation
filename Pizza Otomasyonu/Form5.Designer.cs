namespace Pizza_Otomasyonu
{
    partial class Form5
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
            this.btn15 = new System.Windows.Forms.Button();
            this.btn16 = new System.Windows.Forms.Button();
            this.btn17 = new System.Windows.Forms.Button();
            this.btn18 = new System.Windows.Forms.Button();
            this.btnMenudon = new System.Windows.Forms.Button();
            this.dgwmusteri = new System.Windows.Forms.DataGridView();
            this.labelad = new System.Windows.Forms.Label();
            this.labelsoyad = new System.Windows.Forms.Label();
            this.labeltel = new System.Windows.Forms.Label();
            this.labelpt = new System.Windows.Forms.Label();
            this.textBoxad = new System.Windows.Forms.TextBox();
            this.textBoxsoyad = new System.Windows.Forms.TextBox();
            this.textBoxtel = new System.Windows.Forms.TextBox();
            this.labelid = new System.Windows.Forms.Label();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.comboBoxpt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwmusteri)).BeginInit();
            this.SuspendLayout();
            // 
            // btn15
            // 
            this.btn15.Location = new System.Drawing.Point(64, 6);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(159, 50);
            this.btn15.TabIndex = 0;
            this.btn15.Text = "EKLE";
            this.btn15.UseVisualStyleBackColor = true;
            this.btn15.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn16
            // 
            this.btn16.Location = new System.Drawing.Point(64, 73);
            this.btn16.Name = "btn16";
            this.btn16.Size = new System.Drawing.Size(159, 50);
            this.btn16.TabIndex = 1;
            this.btn16.Text = "SİL";
            this.btn16.UseVisualStyleBackColor = true;
            this.btn16.Click += new System.EventHandler(this.btn16_Click);
            // 
            // btn17
            // 
            this.btn17.Location = new System.Drawing.Point(64, 137);
            this.btn17.Name = "btn17";
            this.btn17.Size = new System.Drawing.Size(159, 50);
            this.btn17.TabIndex = 2;
            this.btn17.Text = "GÜNCELLEME";
            this.btn17.UseVisualStyleBackColor = true;
            this.btn17.Click += new System.EventHandler(this.btn17_Click);
            // 
            // btn18
            // 
            this.btn18.Location = new System.Drawing.Point(645, 12);
            this.btn18.Name = "btn18";
            this.btn18.Size = new System.Drawing.Size(115, 39);
            this.btn18.TabIndex = 3;
            this.btn18.Text = "VERİ LİSTELEME";
            this.btn18.UseVisualStyleBackColor = true;
            this.btn18.Click += new System.EventHandler(this.btn18_Click);
            // 
            // btnMenudon
            // 
            this.btnMenudon.Location = new System.Drawing.Point(645, 79);
            this.btnMenudon.Name = "btnMenudon";
            this.btnMenudon.Size = new System.Drawing.Size(115, 39);
            this.btnMenudon.TabIndex = 4;
            this.btnMenudon.Text = "Ana Menüye Dön";
            this.btnMenudon.UseVisualStyleBackColor = true;
            this.btnMenudon.Click += new System.EventHandler(this.btnMenudon_Click);
            // 
            // dgwmusteri
            // 
            this.dgwmusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwmusteri.Location = new System.Drawing.Point(12, 193);
            this.dgwmusteri.Name = "dgwmusteri";
            this.dgwmusteri.Size = new System.Drawing.Size(776, 245);
            this.dgwmusteri.TabIndex = 5;
            this.dgwmusteri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwmusteri_CellClick);
            // 
            // labelad
            // 
            this.labelad.AutoSize = true;
            this.labelad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelad.Location = new System.Drawing.Point(328, 20);
            this.labelad.Name = "labelad";
            this.labelad.Size = new System.Drawing.Size(40, 20);
            this.labelad.TabIndex = 6;
            this.labelad.Text = "AD :";
            this.labelad.Click += new System.EventHandler(this.labelad_Click);
            // 
            // labelsoyad
            // 
            this.labelsoyad.AutoSize = true;
            this.labelsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelsoyad.Location = new System.Drawing.Point(294, 65);
            this.labelsoyad.Name = "labelsoyad";
            this.labelsoyad.Size = new System.Drawing.Size(74, 20);
            this.labelsoyad.TabIndex = 7;
            this.labelsoyad.Text = "SOYAD :";
            // 
            // labeltel
            // 
            this.labeltel.AutoSize = true;
            this.labeltel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeltel.Location = new System.Drawing.Point(278, 109);
            this.labeltel.Name = "labeltel";
            this.labeltel.Size = new System.Drawing.Size(90, 20);
            this.labeltel.TabIndex = 8;
            this.labeltel.Text = "TELEFON :";
            // 
            // labelpt
            // 
            this.labelpt.AutoSize = true;
            this.labelpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelpt.Location = new System.Drawing.Point(242, 151);
            this.labelpt.Name = "labelpt";
            this.labelpt.Size = new System.Drawing.Size(126, 20);
            this.labelpt.TabIndex = 9;
            this.labelpt.Text = "ÖDEME ŞEKLİ :";
            this.labelpt.Click += new System.EventHandler(this.labelpt_Click);
            // 
            // textBoxad
            // 
            this.textBoxad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxad.Location = new System.Drawing.Point(402, 20);
            this.textBoxad.Name = "textBoxad";
            this.textBoxad.Size = new System.Drawing.Size(125, 22);
            this.textBoxad.TabIndex = 10;
            // 
            // textBoxsoyad
            // 
            this.textBoxsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxsoyad.Location = new System.Drawing.Point(402, 65);
            this.textBoxsoyad.Name = "textBoxsoyad";
            this.textBoxsoyad.Size = new System.Drawing.Size(125, 22);
            this.textBoxsoyad.TabIndex = 11;
            // 
            // textBoxtel
            // 
            this.textBoxtel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxtel.Location = new System.Drawing.Point(402, 109);
            this.textBoxtel.Name = "textBoxtel";
            this.textBoxtel.Size = new System.Drawing.Size(125, 22);
            this.textBoxtel.TabIndex = 12;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelid.Location = new System.Drawing.Point(586, 153);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(34, 20);
            this.labelid.TabIndex = 14;
            this.labelid.Text = "ID :";
            // 
            // textBoxid
            // 
            this.textBoxid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxid.Location = new System.Drawing.Point(635, 151);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(125, 22);
            this.textBoxid.TabIndex = 15;
            // 
            // comboBoxpt
            // 
            this.comboBoxpt.FormattingEnabled = true;
            this.comboBoxpt.Items.AddRange(new object[] {
            "Kapıda Kredi Kartı",
            "Kapıda Nakit",
            "Online"});
            this.comboBoxpt.Location = new System.Drawing.Point(402, 152);
            this.comboBoxpt.Name = "comboBoxpt";
            this.comboBoxpt.Size = new System.Drawing.Size(121, 21);
            this.comboBoxpt.TabIndex = 16;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxpt);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.textBoxtel);
            this.Controls.Add(this.textBoxsoyad);
            this.Controls.Add(this.textBoxad);
            this.Controls.Add(this.labelpt);
            this.Controls.Add(this.labeltel);
            this.Controls.Add(this.labelsoyad);
            this.Controls.Add(this.labelad);
            this.Controls.Add(this.dgwmusteri);
            this.Controls.Add(this.btnMenudon);
            this.Controls.Add(this.btn18);
            this.Controls.Add(this.btn17);
            this.Controls.Add(this.btn16);
            this.Controls.Add(this.btn15);
            this.Name = "Form5";
            this.Text = "Müşteri Kayıtları";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwmusteri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn15;
        private System.Windows.Forms.Button btn16;
        private System.Windows.Forms.Button btn17;
        private System.Windows.Forms.Button btn18;
        private System.Windows.Forms.Button btnMenudon;
        private System.Windows.Forms.DataGridView dgwmusteri;
        private System.Windows.Forms.Label labelad;
        private System.Windows.Forms.Label labelsoyad;
        private System.Windows.Forms.Label labeltel;
        private System.Windows.Forms.Label labelpt;
        private System.Windows.Forms.TextBox textBoxad;
        private System.Windows.Forms.TextBox textBoxsoyad;
        private System.Windows.Forms.TextBox textBoxtel;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.ComboBox comboBoxpt;
    }
}