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

namespace Atolye_Mutfak_Proje_Takip
{
    public partial class sevkiyatduzenle : Form
    {

        MySqlConnection baglanti = new MySqlConnection("Server=185.118.141.56;Database=sevktakip;user=sevktakip;Pwd=Pavk7eptcu3e;SslMode=none");
        MySqlConnection cnn;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public sevkiyatduzenle()
        {
            InitializeComponent();

        }


        public void sevkiyatduzenle_Load(object sender, EventArgs e)
        {


        }

        private void sdkaydet_Click(object sender, EventArgs e)
        {

            int ID = 0;
            if (int.TryParse(textboxıd.Text, out ID))
            {
                baglanti.Open();

                string kayit = "update üretime_giren_projeler set Proje_Kodu = @pk,Müşteri_İsmi = @mi,Sevk_Tarihi = @st,Notlar = @n ,SSH_Bilgisi = @sshb ,Eksik_İçerik = @ei ,Sevkiyat_Bölgesi = @sb, Satış_Fiyatı = @sf,Ebatlama_Kesim = @ebatlama, Bantlama = @bantlama, CNC = @cnc, Toplama = @toplama, Çekmece = @çekmece, Temizleme = @temizleme, Paketleme = @paketleme, Sevkiyat = @sevkiyat WHERE ID = @id ";
                // müşteriler tablomuzun ilgili alanlarını değiştirecek olan güncelleme sorgusu.
                MySqlCommand komut = new MySqlCommand(kayit, baglanti);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                komut.Parameters.AddWithValue("@id", textboxıd.Text);
                komut.Parameters.AddWithValue("@pk", pk.Texts);
                komut.Parameters.AddWithValue("@mi", mi.Texts);
                komut.Parameters.AddWithValue("@st", st.Texts);
                komut.Parameters.AddWithValue("@n", n.Texts);
                komut.Parameters.AddWithValue("@sshb", sshb.Texts);
                komut.Parameters.AddWithValue("@ei", ei.Texts);
                komut.Parameters.AddWithValue("@sb", sb.Texts);
                komut.Parameters.AddWithValue("@sf", sf.Texts);

                komut.Parameters.AddWithValue("@ebatlama", ebatlama.Texts);
                komut.Parameters.AddWithValue("@bantlama", bantlama.Texts);
                komut.Parameters.AddWithValue("@cnc", cnc.Texts);
                komut.Parameters.AddWithValue("@toplama", toplama.Texts);
                komut.Parameters.AddWithValue("@çekmece", çekmece.Texts);
                komut.Parameters.AddWithValue("@temizleme", temizleme.Texts);
                komut.Parameters.AddWithValue("@paketleme", paketleme.Texts);
                komut.Parameters.AddWithValue("@sevkiyat", sevkiyat.Texts);


                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                komut.ExecuteNonQuery();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                baglanti.Close();
                MessageBox.Show("Başarı ile güncellendi.");


            }


        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void pk__TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void st__TextChanged(object sender, EventArgs e)
        {

        }

        private void sb__TextChanged(object sender, EventArgs e)
        {

        }

        private void d__TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void ei__TextChanged(object sender, EventArgs e)
        {

        }

        private void mi__TextChanged(object sender, EventArgs e)
        {

        }

        private void n__TextChanged(object sender, EventArgs e)
        {

        }

        private void sshb__TextChanged(object sender, EventArgs e)
        {

        }

        private void sf__TextChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
