
using System;

using Microsoft.VisualBasic;


using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        private bool islemYapildi = false; // İşlem yapılıp yapılmadığını kontrol

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            using (LinearGradientBrush brush = new LinearGradientBrush(
                new Point(0, 0), new Point(this.Width, this.Height),
                Color.MidnightBlue, Color.Purple)) // Mavi-mor geçiş efekti
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }




        private void YuvarlakButonOlustur(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat; // Kenar çizgilerini kaldır
            btn.FlatAppearance.BorderSize = 0; // Keskin kenarları kaldır
            btn.BackColor = Color.MediumPurple; // Butonun rengini belirgin yap

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, btn.Width, btn.Height); // Tam yuvarlak şekli tanımla
            btn.Region = new Region(path); // Butona yuvarlak bölge uygula
        }


        private void HesaplaTumIslemler()
        {
            try
            {
                int sayi1 = int.Parse(txtSayi1.Text);
                int sayi2 = int.Parse(txtSayi2.Text);

                if (sayi2 == 0)
                {
                    MessageBox.Show("Bir sayı sıfıra bölünemez!");
                    return;
                }

                int toplam = sayi1 + sayi2;
                int cikarma = sayi1 - sayi2;
                int carpma = sayi1 * sayi2;
                double bolme = (double)sayi1 / sayi2;

                lstGecmis.Items.Add($"{sayi1} + {sayi2} = {toplam}");
                lstGecmis.Items.Add($"{sayi1} - {sayi2} = {cikarma}");
                lstGecmis.Items.Add($"{sayi1} × {sayi2} = {carpma}");
                lstGecmis.Items.Add($"{sayi1} ÷ {sayi2} = {bolme}");

                txtSayi1.Clear();
                txtSayi2.Clear();
                txtSayi1.Focus();
            }
            catch
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin!");
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            this.Invalidate(); // 🎯 Form yüklendiğinde tekrar çizimi yenile!
        


        lblSonuc.Visible = true; // Label'i görünür hale getir
            lblSonuc.Font = new Font("Arial", 14, FontStyle.Bold);
            lblSonuc.ForeColor = Color.Black;

            YuvarlakButonOlustur(btnTopla);
            YuvarlakButonOlustur(btnCikar);
            YuvarlakButonOlustur(btnCarp);
            YuvarlakButonOlustur(btnBol);
            this.BackColor = Color.FromArgb(220, 220, 250);

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.DarkGray; // Daha açık koyu ton
                    btn.ForeColor = Color.White; // Yazıyı belirgin yap
                    btn.Font = new Font("Arial", 12, FontStyle.Bold); // Yazıları netleştir
                }
            }




        }


        private void btnTopla_Click(object sender, EventArgs e)
        {
            

            if (rbTumIslemler.Checked)
                HesaplaTumIslemler();
            else
            {

                try
                {
                    int sayi1 = int.Parse(txtSayi1.Text);
                    int sayi2 = int.Parse(txtSayi2.Text);
                    int sonuc = sayi1 + sayi2;
                    lblSonu.Text = "Sonuç: " + sonuc.ToString();
                    lstGecmis.Items.Add($"{sayi1} + {sayi2} = {sonuc}"); // İşlem geçmişi

                    // Hesaplama sonrası TextBox'ları temizleyelim
                    txtSayi1.Clear();
                    txtSayi2.Clear();
                    txtSayi1.Focus();

                }
                catch
                {
                    MessageBox.Show("Lütfen geçerli bir sayı girin!");
                }

                try
                {

                    if (!islemYapildi && (string.IsNullOrEmpty(txtSayi1.Text) || string.IsNullOrEmpty(txtSayi2.Text))) 


                    {
                        MessageBox.Show("Lütfen iki sayı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        FormSalla(); // Formu sallayarak uyarı ver
                        
                    }

                    int sayi1 = int.Parse(txtSayi1.Text);
                    int sayi2 = int.Parse(txtSayi2.Text);
                    int sonuc = sayi1 + sayi2;

                    lblSonu.Text = "Sonuç: " + sonuc.ToString();
                    lstGecmis.Items.Add($"{sayi1} + {sayi2} = {sonuc}");

                    islemYapildi = true; // İşlem tamamlandı

                    // Yeni giriş yapıldığında hata kontrolünü sıfırla
                    islemYapildi = false;




                }
                catch
                {
                    MessageBox.Show("Lütfen geçerli bir sayı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FormSalla(); // Hatalı giriş olursa yine form sallansın
                }


            }
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            if (rbTumIslemler.Checked)
                HesaplaTumIslemler();
            else
            {


                try
                {
                    int sayi1 = int.Parse(txtSayi1.Text);
                    int sayi2 = int.Parse(txtSayi2.Text);
                    int sonuc = sayi1 - sayi2;
                    lblSonu.Text = "Sonuç: " + sonuc.ToString();
                    lstGecmis.Items.Add($"{sayi1} - {sayi2} = {sonuc}");

                    // Hesaplama sonrası TextBox'ları temizleyelim

                    txtSayi1.Clear();
                    txtSayi2.Clear();
                    txtSayi1.Focus();
                }
                catch
                {
                    MessageBox.Show("Lütfen geçerli bir sayı girin!");
                }

                try
                {
                    if (!islemYapildi && (string.IsNullOrEmpty(txtSayi1.Text) || string.IsNullOrEmpty(txtSayi2.Text)))
                    {
                        MessageBox.Show("Lütfen iki sayı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        FormSalla();

                    }

                    int sayi1 = int.Parse(txtSayi1.Text);
                    int sayi2 = int.Parse(txtSayi2.Text);
                    int sonuc = sayi1 - sayi2;

                    lblSonu.Text = "Sonuç: " + sonuc.ToString();
                    lstGecmis.Items.Add($"{sayi1} - {sayi2} = {sonuc}");

                    txtSayi1.Clear();
                    txtSayi2.Clear();
                    txtSayi1.Focus();

                    islemYapildi = true; // İşlem tamamlandı

                    // Yeni giriş yapıldığında hata kontrolünü sıfırla
                    islemYapildi = false;


                }
                catch
                {
                    MessageBox.Show("Lütfen geçerli bir sayı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FormSalla();
                }

            }

        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            if (rbTumIslemler.Checked)
                HesaplaTumIslemler();
            else
            {

                try
                {

                    // Boş girişleri kontrol edelim
                    if (string.IsNullOrEmpty(txtSayi1.Text) || string.IsNullOrEmpty(txtSayi2.Text))
                    {
                        MessageBox.Show("Lütfen iki sayı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    txtSayi1.Clear();
                    txtSayi2.Clear();
                    txtSayi1.Focus();

                    int sayi1 = int.Parse(txtSayi1.Text);
                    int sayi2 = int.Parse(txtSayi2.Text);
                    int sonuc = sayi1 * sayi2;
                    lblSonu.Text = "Sonuç: " + sonuc.ToString();
                    lstGecmis.Items.Add($"{sayi1} × {sayi2} = {sonuc}");
                    // Hesaplama sonrası TextBox'ları temizleyelim
                    
                    
                    

                }
                catch
                {
                    MessageBox.Show("Lütfen geçerli bir sayı girin!");
                }

                try
                {
                    if (!islemYapildi && (string.IsNullOrEmpty(txtSayi1.Text) || string.IsNullOrEmpty(txtSayi2.Text))) 
                    {
                        MessageBox.Show("Lütfen iki sayı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        FormSalla();
                        
                    }

                    int sayi1 = int.Parse(txtSayi1.Text);
                    int sayi2 = int.Parse(txtSayi2.Text);
                    int sonuc = sayi1 * sayi2;

                    lblSonu.Text = "Sonuç: " + sonuc.ToString();
                    lstGecmis.Items.Add($"{sayi1} × {sayi2} = {sonuc}");

                    txtSayi1.Clear();
                    txtSayi2.Clear();
                    txtSayi1.Focus();

                    islemYapildi = true; // İşlem tamamlandı

                    // Yeni giriş yapıldığında hata kontrolünü sıfırla
                    islemYapildi = false;


                }
                catch
                {
                    MessageBox.Show("Lütfen geçerli bir sayı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FormSalla();
                }



            }
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            if (rbTumIslemler.Checked)
                HesaplaTumIslemler();
            else
            {
                try
                {
                    int sayi1 = int.Parse(txtSayi1.Text);
                    int sayi2 = int.Parse(txtSayi2.Text);

                    if (sayi2 == 0)

                    {
                        MessageBox.Show("Bir sayı sıfıra bölünemez!");
                        return;
                    }

                    double sonuc = (double)sayi1 / sayi2;
                    lblSonu.Text = "Sonuç: " + sonuc.ToString();
                    lstGecmis.Items.Add($"{sayi1} ÷ {sayi2} = {sonuc}");
                    // Hesaplama sonrası TextBox'ları temizleyelim
                    txtSayi1.Clear();
                    txtSayi2.Clear();
                    txtSayi1.Focus();

                    
                }
                catch
                {
                    MessageBox.Show("Lütfen geçerli bir sayı girin!");
                }

                try
                {
                    if( !islemYapildi && (string.IsNullOrEmpty(txtSayi1.Text) || string.IsNullOrEmpty(txtSayi2.Text))) 
                    {
                        MessageBox.Show("Lütfen iki sayı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        FormSalla();
                        
                    }

                    int sayi1 = int.Parse(txtSayi1.Text);
                    int sayi2 = int.Parse(txtSayi2.Text);

                    if (sayi2 == 0)
                    {
                        MessageBox.Show("Bir sayı sıfıra bölünemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        FormSalla();
                        
                    }

                    double sonuc = (double)sayi1 / sayi2;
                    lblSonu.Text = "Sonuç: " + sonuc.ToString();
                    lstGecmis.Items.Add($"{sayi1} ÷ {sayi2} = {sonuc}");

                    txtSayi1.Clear();
                    txtSayi2.Clear();
                    txtSayi1.Focus();
                    islemYapildi = true; // İşlem tamamlandı

                    // Yeni giriş yapıldığında hata kontrolünü sıfırla
                    islemYapildi = false;


                }
                catch
                {
                    MessageBox.Show("Lütfen geçerli bir sayı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FormSalla();
                }



            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lstGecmis.Items.Clear(); // Listeyi temizle
        }

        private void txtSayi2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter) // Kullanıcı Enter'a basarsa
            {
                try
                {
                    int sayi1 = int.Parse(txtSayi1.Text);
                    int sayi2 = int.Parse(txtSayi2.Text);

                    if (sayi2 == 0)
                    {
                        MessageBox.Show("Bir sayı sıfıra bölünemez!");
                        return;
                    }

                    // Eğer "Tüm İşlemleri Yap" RadioButton'u seçiliyse, tüm işlemleri yap
                    if (rbTumIslemler.Checked)
                    {
                        int toplam = sayi1 + sayi2;
                        int cikarma = sayi1 - sayi2;
                        int carpma = sayi1 * sayi2;
                        double bolme = (double)sayi1 / sayi2;

                        lstGecmis.Items.Add($"{sayi1} + {sayi2} = {toplam}");
                        lstGecmis.Items.Add($"{sayi1} - {sayi2} = {cikarma}");
                        lstGecmis.Items.Add($"{sayi1} × {sayi2} = {carpma}");
                        lstGecmis.Items.Add($"{sayi1} ÷ {sayi2} = {bolme}");
                    }
                    else // Eğer "Tüm İşlemleri Yap" seçili değilse, sadece seçilen işlem çalışsın
                    {
                        if (rbToplama.Checked) btnTopla.PerformClick();
                        else if (rbCikarma.Checked) btnCikar.PerformClick();
                        else if (rbCarpma.Checked) btnCarp.PerformClick();
                        else if (rbBolme.Checked) btnBol.PerformClick();
                    }
                }
                catch
                {
                    MessageBox.Show("Lütfen geçerli bir sayı girin!");
                }
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Add) // Klavyede + tuşuna basılırsa
            {
                btnTopla.PerformClick();
            }
            else if (e.KeyCode == Keys.Subtract) // Klavyede - tuşuna basılırsa
            {
                btnCikar.PerformClick();
            }
            else if (e.KeyCode == Keys.Multiply) // Klavyede * tuşuna basılırsa
            {
                btnCarp.PerformClick();
            }
            else if (e.KeyCode == Keys.Divide) // Klavyede / tuşuna basılırsa
            {
                btnBol.PerformClick();
            }
        }

        private void btnGeceModu_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black; // Form arka planı siyah olsun
            txtSayi1.BackColor = Color.Gray;
            txtSayi2.BackColor = Color.Gray;
            txtSayi1.ForeColor = Color.White;
            txtSayi2.ForeColor = Color.White;
            lblSonu.ForeColor = Color.White;
            lstGecmis.BackColor = Color.DarkGray;
            lstGecmis.ForeColor = Color.White;

        }

        private void btnNormalMod_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control; // Varsayılan arka plana dön
            txtSayi1.BackColor = Color.White;
            txtSayi2.BackColor = Color.White;
            txtSayi1.ForeColor = Color.Black;
            txtSayi2.ForeColor = Color.Black;
            lblSonu.ForeColor = Color.Black;
            lstGecmis.BackColor = Color.White;
            lstGecmis.ForeColor = Color.Black;


        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblSonu.Text) && lblSonu.Text != "Sonuç: ")
            {
                Clipboard.SetText(lblSonu.Text);
                MessageBox.Show("Sonuç kopyalandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kopyalanacak bir sonuç yok!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void lstGecmis_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lstGecmis_DoubleClick(object sender, EventArgs e)
        {
            if (lstGecmis.SelectedItem != null) // Kullanıcı bir işlem seçtiyse
            {
                string secilenIslem = lstGecmis.SelectedItem.ToString();
                string[] sayilar = secilenIslem.Split(' '); // İşlemi parçalayarak sayıları al

                if (sayilar.Length >= 3) // Hata oluşmaması için en az 3 eleman olmalı
                {
                    txtSayi1.Text = sayilar[0]; // İlk sayıyı al
                    txtSayi2.Text = sayilar[2]; // İkinci sayıyı al
                }
            }

        }

        private void btnTopla_MouseEnter(object sender, EventArgs e)
        {
            btnTopla.FlatStyle = FlatStyle.Standard; // FlatStyle dmasını sağla
            btnTopla.BackColor = Color.DarkRed; // Neon Kırmız



        }

        private void btnTopla_MouseLeave(object sender, EventArgs e)
        {
            btnTopla.BackColor = Color.White;


        }

        private void btnCikar_MouseEnter(object sender, EventArgs e)
        {
            btnCikar.FlatStyle = FlatStyle.Standard;
            btnCikar.BackColor = Color.Blue; // Neon Kırm


        }

        private void btnCikar_MouseLeave(object sender, EventArgs e)
        {
            btnCikar.BackColor = Color.White;
        }

        private void btnCarp_MouseEnter(object sender, EventArgs e)
        {
            btnCarp.FlatStyle = FlatStyle.Standard;
            btnCarp.BackColor = Color.FromArgb(57, 255, 20); // Neon Yeşil



        }

        private void btnCarp_MouseLeave(object sender, EventArgs e)
        {
            btnCarp.BackColor = Color.White;


        }

        private void btnBol_MouseEnter(object sender, EventArgs e)
        {
            btnBol.FlatStyle = FlatStyle.Standard;
            btnBol.BackColor = Color.FromArgb(255, 20, 147); // Neon Pembe



        }

        private void btnBol_MouseLeave(object sender, EventArgs e)
        {
            btnBol.BackColor = Color.White;


        }

        private void FormSalla()
        {
            int x = this.Location.X;
            int y = this.Location.Y;

            for (int i = 0; i < 10; i++)
            {
                this.Location = new Point(x + 5, y);
                System.Threading.Thread.Sleep(50);
                this.Location = new Point(x - 5, y);
                System.Threading.Thread.Sleep(50);
            }
        }

        private void txtSayi1_TextChanged(object sender, EventArgs e)
        {
            islemYapildi = false; // Kullanıcı yeni veri girerse hata kontrolü norma

        }

        private void txtSayi2_TextChanged(object sender, EventArgs e)
        {
            islemYapildi = false;


        }

        private void btnTopla_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Color shadowColor = Color.FromArgb(40, 0, 0, 0); // %40 opak siyah gölge
            SolidBrush shadowBrush = new SolidBrush(shadowColor);

            g.FillEllipse(shadowBrush, -6 , -6, btnBol.Width +10, btnBol.Height +10);
        }



        

        private void btnCikar_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Color shadowColor = Color.FromArgb(40, 0, 0, 0); // %40 opak siyah gölge
            SolidBrush shadowBrush = new SolidBrush(shadowColor);

            g.FillEllipse(shadowBrush, -6, -6, btnBol.Width +10, btnBol.Height +10);

        }

        private void btnCarp_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Color shadowColor = Color.FromArgb(40, 0, 0, 0); // %40 opak siyah gölge
            SolidBrush shadowBrush = new SolidBrush(shadowColor);

            g.FillEllipse(shadowBrush, -6, -6, btnBol.Width +10, btnBol.Height +10);

        }

        private void btnBol_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Color shadowColor = Color.FromArgb(40, 0, 0, 0); // %40 opak siyah gölge
            SolidBrush shadowBrush = new SolidBrush(shadowColor);

            g.FillEllipse(shadowBrush, -6, -6, btnBol.Width+ 10, btnBol.Height+ 10);
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDisplay.Text)) // Eğer boşsa işlem yapma
            {
                MessageBox.Show("Lütfen önce bir sayı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double baseNum;
            if (!double.TryParse(txtDisplay.Text, out baseNum)) // Geçersiz girişleri kontrol et
            {
                MessageBox.Show("Geçerli bir sayı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double exponent = Convert.ToDouble(ShowInputBox("Üs Değerini Gir:", "Üs Hesaplama")); // Kullanıcıdan üs değeri al
            txtDisplay.Text = Math.Pow(baseNum, exponent).ToString();





        }


        public static string ShowInputBox(string prompt, string title)
        {
            Form inputForm = new Form()
            {
                Width = 300,
                Height = 150,
                Text = title,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label lblPrompt = new Label() { Left = 10, Top = 10, Text = prompt, Width = 260 };
            TextBox txtInput = new TextBox() { Left = 10, Top = 40, Width = 260 };
            Button btnOk = new Button() { Text = "Tamam", Left = 200, Top = 70, Width = 70 };

            btnOk.Click += (sender, e) => { inputForm.DialogResult = DialogResult.OK; inputForm.Close(); };

            inputForm.Controls.Add(lblPrompt);
            inputForm.Controls.Add(txtInput);
            inputForm.Controls.Add(btnOk);

            return inputForm.ShowDialog() == DialogResult.OK ? txtInput.Text : "";
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Math.Sqrt(num).ToString();


        }

        private void btnLong_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Math.Log10(num).ToString();


        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Math.Sin(num * Math.PI / 180).ToString();

        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Math.Cos(num * Math.PI / 180).ToString();

        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Math.Tan(num * Math.PI / 180).ToString();

        }
    }
}


    


