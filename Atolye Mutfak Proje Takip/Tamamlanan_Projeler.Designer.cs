namespace Atolye_Mutfak_Proje_Takip
{
    partial class Tamamlanan_Projeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tamamlanan_Projeler));
            this.tamamlanan_sevk = new System.Windows.Forms.DataGridView();
            this.to_tamamlanan_prj = new System.Windows.Forms.DataGridView();
            this.to_id = new Sipaa.Framework.STextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.aktar = new Sipaa.Framework.SButton();
            this.güncelle = new Sipaa.Framework.SButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.sil = new Sipaa.Framework.SButton();
            ((System.ComponentModel.ISupportInitialize)(this.tamamlanan_sevk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.to_tamamlanan_prj)).BeginInit();
            this.SuspendLayout();
            // 
            // tamamlanan_sevk
            // 
            this.tamamlanan_sevk.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.tamamlanan_sevk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tamamlanan_sevk.GridColor = System.Drawing.Color.DarkGray;
            this.tamamlanan_sevk.Location = new System.Drawing.Point(12, 65);
            this.tamamlanan_sevk.Name = "tamamlanan_sevk";
            this.tamamlanan_sevk.RowTemplate.Height = 25;
            this.tamamlanan_sevk.Size = new System.Drawing.Size(640, 540);
            this.tamamlanan_sevk.TabIndex = 0;
            // 
            // to_tamamlanan_prj
            // 
            this.to_tamamlanan_prj.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.to_tamamlanan_prj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.to_tamamlanan_prj.GridColor = System.Drawing.Color.DarkGray;
            this.to_tamamlanan_prj.Location = new System.Drawing.Point(860, 65);
            this.to_tamamlanan_prj.Name = "to_tamamlanan_prj";
            this.to_tamamlanan_prj.RowTemplate.Height = 25;
            this.to_tamamlanan_prj.Size = new System.Drawing.Size(640, 540);
            this.to_tamamlanan_prj.TabIndex = 1;
            // 
            // to_id
            // 
            this.to_id.BackColor = System.Drawing.SystemColors.Window;
            this.to_id.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.to_id.BorderFocusColor = System.Drawing.Color.HotPink;
            this.to_id.BorderRadius = 15;
            this.to_id.BorderSize = 2;
            this.to_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.to_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.to_id.Location = new System.Drawing.Point(661, 252);
            this.to_id.Margin = new System.Windows.Forms.Padding(4);
            this.to_id.Multiline = false;
            this.to_id.Name = "to_id";
            this.to_id.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.to_id.PasswordChar = false;
            this.to_id.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.to_id.PlaceholderText = "";
            this.to_id.Size = new System.Drawing.Size(190, 31);
            this.to_id.TabIndex = 2;
            this.to_id.Texts = "";
            this.to_id.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(683, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Proje ID\'si Girin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(546, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Proje ID\'sini Etiketlerdeki veya projelerdeki qr kodu okutarak öğrenebilirsiniz.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(236, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Üretim Tablosu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1088, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tamamen Bitmiş Projeler";
            // 
            // aktar
            // 
            this.aktar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.aktar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.aktar.BorderRadius = 20;
            this.aktar.BorderSize = 0;
            this.aktar.FlatAppearance.BorderSize = 0;
            this.aktar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aktar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aktar.ForeColor = System.Drawing.Color.White;
            this.aktar.Location = new System.Drawing.Point(683, 290);
            this.aktar.Name = "aktar";
            this.aktar.Size = new System.Drawing.Size(150, 40);
            this.aktar.TabIndex = 7;
            this.aktar.Text = "Aktar";
            this.aktar.UseVisualStyleBackColor = false;
            this.aktar.Click += new System.EventHandler(this.aktar_Click);
            // 
            // güncelle
            // 
            this.güncelle.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.güncelle.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.güncelle.BorderRadius = 20;
            this.güncelle.BorderSize = 0;
            this.güncelle.FlatAppearance.BorderSize = 0;
            this.güncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.güncelle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.güncelle.ForeColor = System.Drawing.Color.White;
            this.güncelle.Location = new System.Drawing.Point(683, 336);
            this.güncelle.Name = "güncelle";
            this.güncelle.Size = new System.Drawing.Size(150, 40);
            this.güncelle.TabIndex = 8;
            this.güncelle.Text = "Güncelle";
            this.güncelle.UseVisualStyleBackColor = false;
            this.güncelle.Click += new System.EventHandler(this.güncelle_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(153, 23);
            this.textBox1.TabIndex = 9;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(185, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ShortcutsEnabled = false;
            this.textBox2.Size = new System.Drawing.Size(153, 23);
            this.textBox2.TabIndex = 10;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(344, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ShortcutsEnabled = false;
            this.textBox3.Size = new System.Drawing.Size(153, 23);
            this.textBox3.TabIndex = 12;
            this.textBox3.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(503, 12);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.ShortcutsEnabled = false;
            this.textBox5.Size = new System.Drawing.Size(153, 23);
            this.textBox5.TabIndex = 14;
            this.textBox5.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(661, 12);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.ShortcutsEnabled = false;
            this.textBox6.Size = new System.Drawing.Size(153, 23);
            this.textBox6.TabIndex = 13;
            this.textBox6.Visible = false;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(820, 12);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.ShortcutsEnabled = false;
            this.textBox7.Size = new System.Drawing.Size(153, 23);
            this.textBox7.TabIndex = 15;
            this.textBox7.Visible = false;
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.sil.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sil.BorderRadius = 20;
            this.sil.BorderSize = 0;
            this.sil.FlatAppearance.BorderSize = 0;
            this.sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sil.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sil.ForeColor = System.Drawing.Color.White;
            this.sil.Location = new System.Drawing.Point(683, 382);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(150, 40);
            this.sil.TabIndex = 16;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // Tamamlanan_Projeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1526, 625);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.güncelle);
            this.Controls.Add(this.aktar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.to_id);
            this.Controls.Add(this.to_tamamlanan_prj);
            this.Controls.Add(this.tamamlanan_sevk);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Tamamlanan_Projeler";
            this.Text = "Atolye Mutfak | Tamamlanan Projeler";
            this.Load += new System.EventHandler(this.Tamamlanan_Projeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tamamlanan_sevk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.to_tamamlanan_prj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView tamamlanan_sevk;
        private DataGridView to_tamamlanan_prj;
        private Sipaa.Framework.STextBox to_id;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Sipaa.Framework.SButton aktar;
        private Sipaa.Framework.SButton güncelle;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Sipaa.Framework.SButton sil;
    }
}