namespace HesapMakinesi
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
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnTopla = new System.Windows.Forms.Button();
            this.btnCikar = new System.Windows.Forms.Button();
            this.btnCarp = new System.Windows.Forms.Button();
            this.btnBol = new System.Windows.Forms.Button();
            this.lblSonu = new System.Windows.Forms.Label();
            this.lstGecmis = new System.Windows.Forms.ListBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.rbToplama = new System.Windows.Forms.RadioButton();
            this.rbCikarma = new System.Windows.Forms.RadioButton();
            this.rbCarpma = new System.Windows.Forms.RadioButton();
            this.rbBolme = new System.Windows.Forms.RadioButton();
            this.rbTumIslemler = new System.Windows.Forms.RadioButton();
            this.btnGeceModu = new System.Windows.Forms.Button();
            this.btnNormalMod = new System.Windows.Forms.Button();
            this.btnKopyala = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnLong = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(205, 133);
            this.txtSayi1.Multiline = true;
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(250, 37);
            this.txtSayi1.TabIndex = 0;
            this.txtSayi1.TextChanged += new System.EventHandler(this.txtSayi1_TextChanged);
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(205, 196);
            this.txtSayi2.Multiline = true;
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(250, 43);
            this.txtSayi2.TabIndex = 1;
            this.txtSayi2.TextChanged += new System.EventHandler(this.txtSayi2_TextChanged);
            this.txtSayi2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSayi2_KeyPress);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(172, 300);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 16);
            this.lblSonuc.TabIndex = 2;
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(50, 392);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(139, 78);
            this.btnTopla.TabIndex = 3;
            this.btnTopla.Text = "TOPLA";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            this.btnTopla.Paint += new System.Windows.Forms.PaintEventHandler(this.btnTopla_Paint);
            this.btnTopla.MouseEnter += new System.EventHandler(this.btnTopla_MouseEnter);
            this.btnTopla.MouseLeave += new System.EventHandler(this.btnTopla_MouseLeave);
            // 
            // btnCikar
            // 
            this.btnCikar.Location = new System.Drawing.Point(231, 392);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(132, 78);
            this.btnCikar.TabIndex = 4;
            this.btnCikar.Text = "ÇIKAR";
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            this.btnCikar.Paint += new System.Windows.Forms.PaintEventHandler(this.btnCikar_Paint);
            this.btnCikar.MouseEnter += new System.EventHandler(this.btnCikar_MouseEnter);
            this.btnCikar.MouseLeave += new System.EventHandler(this.btnCikar_MouseLeave);
            // 
            // btnCarp
            // 
            this.btnCarp.Location = new System.Drawing.Point(397, 392);
            this.btnCarp.Name = "btnCarp";
            this.btnCarp.Size = new System.Drawing.Size(106, 78);
            this.btnCarp.TabIndex = 5;
            this.btnCarp.Text = "ÇARP";
            this.btnCarp.UseVisualStyleBackColor = true;
            this.btnCarp.Click += new System.EventHandler(this.btnCarp_Click);
            this.btnCarp.Paint += new System.Windows.Forms.PaintEventHandler(this.btnCarp_Paint);
            this.btnCarp.MouseEnter += new System.EventHandler(this.btnCarp_MouseEnter);
            this.btnCarp.MouseLeave += new System.EventHandler(this.btnCarp_MouseLeave);
            // 
            // btnBol
            // 
            this.btnBol.Location = new System.Drawing.Point(529, 392);
            this.btnBol.Name = "btnBol";
            this.btnBol.Size = new System.Drawing.Size(135, 78);
            this.btnBol.TabIndex = 6;
            this.btnBol.Text = "BÖL";
            this.btnBol.UseVisualStyleBackColor = true;
            this.btnBol.Click += new System.EventHandler(this.btnBol_Click);
            this.btnBol.Paint += new System.Windows.Forms.PaintEventHandler(this.btnBol_Paint);
            this.btnBol.MouseEnter += new System.EventHandler(this.btnBol_MouseEnter);
            this.btnBol.MouseLeave += new System.EventHandler(this.btnBol_MouseLeave);
            // 
            // lblSonu
            // 
            this.lblSonu.AutoSize = true;
            this.lblSonu.BackColor = System.Drawing.Color.GhostWhite;
            this.lblSonu.Location = new System.Drawing.Point(247, 300);
            this.lblSonu.Name = "lblSonu";
            this.lblSonu.Size = new System.Drawing.Size(79, 16);
            this.lblSonu.TabIndex = 7;
            this.lblSonu.Text = "lblSonuc=\"\";";
            // 
            // lstGecmis
            // 
            this.lstGecmis.BackColor = System.Drawing.Color.GhostWhite;
            this.lstGecmis.FormattingEnabled = true;
            this.lstGecmis.ItemHeight = 16;
            this.lstGecmis.Location = new System.Drawing.Point(643, 109);
            this.lstGecmis.Name = "lstGecmis";
            this.lstGecmis.Size = new System.Drawing.Size(225, 260);
            this.lstGecmis.TabIndex = 8;
            this.lstGecmis.SelectedIndexChanged += new System.EventHandler(this.lstGecmis_SelectedIndexChanged);
            this.lstGecmis.DoubleClick += new System.EventHandler(this.lstGecmis_DoubleClick);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.GhostWhite;
            this.btnTemizle.Location = new System.Drawing.Point(384, 491);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(212, 74);
            this.btnTemizle.TabIndex = 9;
            this.btnTemizle.Text = "Geçmişi Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // rbToplama
            // 
            this.rbToplama.AutoSize = true;
            this.rbToplama.Checked = true;
            this.rbToplama.Location = new System.Drawing.Point(494, 110);
            this.rbToplama.Name = "rbToplama";
            this.rbToplama.Size = new System.Drawing.Size(83, 20);
            this.rbToplama.TabIndex = 10;
            this.rbToplama.TabStop = true;
            this.rbToplama.Text = "Toplama";
            this.rbToplama.UseVisualStyleBackColor = true;
            // 
            // rbCikarma
            // 
            this.rbCikarma.AutoSize = true;
            this.rbCikarma.Location = new System.Drawing.Point(494, 150);
            this.rbCikarma.Name = "rbCikarma";
            this.rbCikarma.Size = new System.Drawing.Size(78, 20);
            this.rbCikarma.TabIndex = 11;
            this.rbCikarma.Text = "Çıkarma";
            this.rbCikarma.UseVisualStyleBackColor = true;
            // 
            // rbCarpma
            // 
            this.rbCarpma.AutoSize = true;
            this.rbCarpma.Location = new System.Drawing.Point(494, 196);
            this.rbCarpma.Name = "rbCarpma";
            this.rbCarpma.Size = new System.Drawing.Size(76, 20);
            this.rbCarpma.TabIndex = 12;
            this.rbCarpma.Text = "Çarpma";
            this.rbCarpma.UseVisualStyleBackColor = true;
            // 
            // rbBolme
            // 
            this.rbBolme.AutoSize = true;
            this.rbBolme.Location = new System.Drawing.Point(494, 241);
            this.rbBolme.Name = "rbBolme";
            this.rbBolme.Size = new System.Drawing.Size(67, 20);
            this.rbBolme.TabIndex = 13;
            this.rbBolme.Text = "Bölme";
            this.rbBolme.UseVisualStyleBackColor = true;
            // 
            // rbTumIslemler
            // 
            this.rbTumIslemler.AutoSize = true;
            this.rbTumIslemler.Location = new System.Drawing.Point(494, 285);
            this.rbTumIslemler.Name = "rbTumIslemler";
            this.rbTumIslemler.Size = new System.Drawing.Size(136, 20);
            this.rbTumIslemler.TabIndex = 14;
            this.rbTumIslemler.TabStop = true;
            this.rbTumIslemler.Text = "Tüm İşlemleri Yap";
            this.rbTumIslemler.UseVisualStyleBackColor = true;
            // 
            // btnGeceModu
            // 
            this.btnGeceModu.BackColor = System.Drawing.Color.GhostWhite;
            this.btnGeceModu.Location = new System.Drawing.Point(12, 33);
            this.btnGeceModu.Name = "btnGeceModu";
            this.btnGeceModu.Size = new System.Drawing.Size(132, 137);
            this.btnGeceModu.TabIndex = 15;
            this.btnGeceModu.Text = "Gece Modu";
            this.btnGeceModu.UseVisualStyleBackColor = false;
            this.btnGeceModu.Click += new System.EventHandler(this.btnGeceModu_Click);
            // 
            // btnNormalMod
            // 
            this.btnNormalMod.BackColor = System.Drawing.Color.GhostWhite;
            this.btnNormalMod.Location = new System.Drawing.Point(12, 184);
            this.btnNormalMod.Name = "btnNormalMod";
            this.btnNormalMod.Size = new System.Drawing.Size(132, 132);
            this.btnNormalMod.TabIndex = 16;
            this.btnNormalMod.Text = "Normal Mod";
            this.btnNormalMod.UseVisualStyleBackColor = false;
            this.btnNormalMod.Click += new System.EventHandler(this.btnNormalMod_Click);
            // 
            // btnKopyala
            // 
            this.btnKopyala.BackColor = System.Drawing.Color.GhostWhite;
            this.btnKopyala.Location = new System.Drawing.Point(697, 392);
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(185, 78);
            this.btnKopyala.TabIndex = 17;
            this.btnKopyala.Text = "Sonucu Kopyala";
            this.btnKopyala.UseVisualStyleBackColor = false;
            this.btnKopyala.Click += new System.EventHandler(this.btnKopyala_Click);
            // 
            // btnPower
            // 
            this.btnPower.Location = new System.Drawing.Point(911, 82);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(163, 48);
            this.btnPower.TabIndex = 18;
            this.btnPower.Text = "Üs Alma ";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Location = new System.Drawing.Point(911, 138);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(163, 45);
            this.btnSqrt.TabIndex = 19;
            this.btnSqrt.Text = "Karekök";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnSin
            // 
            this.btnSin.Location = new System.Drawing.Point(911, 193);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(163, 36);
            this.btnSin.TabIndex = 20;
            this.btnSin.Text = "Sinüs ";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnCos
            // 
            this.btnCos.Location = new System.Drawing.Point(911, 241);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(163, 45);
            this.btnCos.TabIndex = 21;
            this.btnCos.Text = "Kosinüs ";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnTan
            // 
            this.btnTan.Location = new System.Drawing.Point(911, 292);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(163, 47);
            this.btnTan.TabIndex = 22;
            this.btnTan.Text = "Tanjant";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnLong
            // 
            this.btnLong.Location = new System.Drawing.Point(911, 345);
            this.btnLong.Name = "btnLong";
            this.btnLong.Size = new System.Drawing.Size(163, 41);
            this.btnLong.TabIndex = 23;
            this.btnLong.Text = "Logaritma";
            this.btnLong.UseVisualStyleBackColor = true;
            this.btnLong.Click += new System.EventHandler(this.btnLong_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(911, 392);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(251, 159);
            this.txtDisplay.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1175, 672);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnLong);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.btnKopyala);
            this.Controls.Add(this.btnNormalMod);
            this.Controls.Add(this.btnGeceModu);
            this.Controls.Add(this.rbTumIslemler);
            this.Controls.Add(this.rbBolme);
            this.Controls.Add(this.rbCarpma);
            this.Controls.Add(this.rbCikarma);
            this.Controls.Add(this.rbToplama);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.lstGecmis);
            this.Controls.Add(this.lblSonu);
            this.Controls.Add(this.btnBol);
            this.Controls.Add(this.btnCarp);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.Button btnCarp;
        private System.Windows.Forms.Button btnBol;
        private System.Windows.Forms.Label lblSonu;
        private System.Windows.Forms.ListBox lstGecmis;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.RadioButton rbToplama;
        private System.Windows.Forms.RadioButton rbCikarma;
        private System.Windows.Forms.RadioButton rbCarpma;
        private System.Windows.Forms.RadioButton rbBolme;
        private System.Windows.Forms.RadioButton rbTumIslemler;
        private System.Windows.Forms.Button btnGeceModu;
        private System.Windows.Forms.Button btnNormalMod;
        private System.Windows.Forms.Button btnKopyala;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnLong;
        private System.Windows.Forms.TextBox txtDisplay;
    }
}

