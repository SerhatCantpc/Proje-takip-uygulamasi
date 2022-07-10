using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using QRCoder;

namespace Atolye_Mutfak_Proje_Takip
{
    public partial class proje_ekle : Form
    {


        MySqlConnection cnn;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public proje_ekle()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

  

        private void label1_Click(object sender, EventArgs e)
        {

        }

       


        private void ekle_new_Click(object sender, EventArgs e)
        {
            MySqlConnection baglan = new MySqlConnection("Server=185.118.141.56;Database=sevktakip;user=sevktakip;Pwd=Pavk7eptcu3e;SslMode=none");

            try
            {
                // bağlantıyı açalım
                baglan.Open();
                // ekleme komutunu tanımladım ve insert sorgusunu yazdım.
                MySqlCommand ekle = new MySqlCommand("insert into üretime_giren_projeler (Proje_Kodu,Müşteri_İsmi,Sevk_Tarihi,Sevkiyat_Bölgesi,Satış_Fiyatı) values ('" + pk.Texts + "','" + mi.Texts + "','" + st.Texts + "','" + sb.Texts + "','" + sf.Texts + "')", baglan);
                // sorguyu çalıştırıyorum.
                object sonuc = null;
                sonuc = ekle.ExecuteNonQuery(); // sorgu çalıştı ve dönen değer objec türünden değişkene geçti eğer değişken boş değilse eklendi boşşsa eklenmedi.
                if (sonuc != null)
                    MessageBox.Show("Sisteme başarıyla eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Sisteme eklenemedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // bağlantıyı kapatalım
                baglan.Close();




            }


            catch (Exception HataYakala)
            {
                MessageBox.Show("Hata: " + HataYakala.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            System.Threading.Thread.Sleep(10);

            MySqlConnection baglanti = new
MySqlConnection("Server=185.118.141.56;Database=sevktakip;user=sevktakip;Pwd=Pavk7eptcu3e;SslMode=none");
            baglanti.Open();
            MySqlCommand cmd = new MySqlCommand("select ID from üretime_giren_projeler  WHERE Proje_Kodu = @pk ", baglanti); //ID = '" + qrID.Texts + "'"
            cmd.Parameters.AddWithValue("@pk", pk.Texts);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                string ıd = "";
                ıd = dr["ID"].ToString();

                qrID.Texts = ıd;

            }

            dr.Close();
            baglanti.Close();
            qrolustur_new_Click(sender, e);
        }

        private void qrolustur_new_Click(object sender, EventArgs e)
        {

        }

        private void proje_ekle_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void qrolustur_new_Click_1(object sender, EventArgs e)
        {
            string str = qrID.Texts;
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(str, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(7);
            pictureBox1.Image = qrCodeImage;

            SaveFileDialog sfd = new SaveFileDialog();//yeni bir kaydetme diyaloğu oluşturuyoruz.

            sfd.Filter = "jpeg dosyası(*.jpg)|*.jpg|Bitmap(*.bmp)|*.bmp";//.bmp veya .jpg olarak kayıt imkanı sağlıyoruz.

            sfd.Title = "QR KODUNU KAYDET";//diğaloğumuzun başlığını belirliyoruz.

            sfd.FileName = "QR ID. '" + qrID.Texts + "' + Proje adı. '" + pk.Texts + "'";//kaydedilen resmimizin adını 'resim' olarak belirliyoruz.

            DialogResult sonuç = sfd.ShowDialog();

            if (sonuç == DialogResult.OK)
            {
                pictureBox1.Image.Save(sfd.FileName);//Böylelikle resmi istediğimiz yere kaydediyoruz.


            }
        }
    }

}
