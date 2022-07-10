namespace Atolye_Mutfak_Proje_Takip
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.üretimdrm = new System.Windows.Forms.DataGridView();
            this.duzenle = new Sipaa.Framework.SButton();
            this.güncelle = new Sipaa.Framework.SButton();
            this.id = new Sipaa.Framework.STextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.üretimdrm)).BeginInit();
            this.SuspendLayout();
            // 
            // üretimdrm
            // 
            this.üretimdrm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.üretimdrm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.üretimdrm.GridColor = System.Drawing.Color.DarkGray;
            this.üretimdrm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.üretimdrm.Location = new System.Drawing.Point(12, 12);
            this.üretimdrm.Name = "üretimdrm";
            this.üretimdrm.ReadOnly = true;
            this.üretimdrm.RowTemplate.Height = 25;
            this.üretimdrm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.üretimdrm.Size = new System.Drawing.Size(1330, 724);
            this.üretimdrm.TabIndex = 0;
            this.üretimdrm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mevctsevk_CellContentClick);
            // 
            // duzenle
            // 
            this.duzenle.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.duzenle.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.duzenle.BorderRadius = 17;
            this.duzenle.BorderSize = 0;
            this.duzenle.FlatAppearance.BorderSize = 0;
            this.duzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.duzenle.ForeColor = System.Drawing.Color.White;
            this.duzenle.Location = new System.Drawing.Point(290, 751);
            this.duzenle.Name = "duzenle";
            this.duzenle.Size = new System.Drawing.Size(119, 32);
            this.duzenle.TabIndex = 1;
            this.duzenle.Text = "Ara ve Düzenle";
            this.duzenle.UseVisualStyleBackColor = false;
            this.duzenle.Click += new System.EventHandler(this.duzenle_Click);
            // 
            // güncelle
            // 
            this.güncelle.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.güncelle.BorderColor = System.Drawing.Color.HotPink;
            this.güncelle.BorderRadius = 20;
            this.güncelle.BorderSize = 0;
            this.güncelle.FlatAppearance.BorderSize = 0;
            this.güncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.güncelle.ForeColor = System.Drawing.Color.White;
            this.güncelle.Location = new System.Drawing.Point(1192, 742);
            this.güncelle.Name = "güncelle";
            this.güncelle.Size = new System.Drawing.Size(150, 40);
            this.güncelle.TabIndex = 2;
            this.güncelle.Text = "Güncelle";
            this.güncelle.UseVisualStyleBackColor = false;
            this.güncelle.Click += new System.EventHandler(this.güncelle_Click);
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.SystemColors.Window;
            this.id.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.id.BorderFocusColor = System.Drawing.Color.HotPink;
            this.id.BorderRadius = 17;
            this.id.BorderSize = 2;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.id.Location = new System.Drawing.Point(12, 751);
            this.id.Margin = new System.Windows.Forms.Padding(4);
            this.id.Multiline = false;
            this.id.Name = "id";
            this.id.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.id.PasswordChar = false;
            this.id.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.id.PlaceholderText = "";
            this.id.Size = new System.Drawing.Size(261, 31);
            this.id.TabIndex = 7;
            this.id.Texts = "";
            this.id.UnderlinedStyle = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(1352, 792);
            this.Controls.Add(this.id);
            this.Controls.Add(this.güncelle);
            this.Controls.Add(this.duzenle);
            this.Controls.Add(this.üretimdrm);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Atolye Mutfak | Üretim Durumu";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.üretimdrm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView üretimdrm;
        private Sipaa.Framework.SButton duzenle;
        private Sipaa.Framework.SButton güncelle;
        private Sipaa.Framework.STextBox id;
        private System.Windows.Forms.Timer timer1;
    }
}