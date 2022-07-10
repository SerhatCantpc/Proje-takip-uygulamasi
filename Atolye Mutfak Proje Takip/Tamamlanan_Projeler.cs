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
using ZXing;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using MySql.Data.MySqlClient;

namespace Atolye_Mutfak_Proje_Takip
{
    public partial class Tamamlanan_Projeler : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public Tamamlanan_Projeler()
        {
            InitializeComponent();
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;

            MySqlConnection baglanti = new
            MySqlConnection("Server=185.118.141.56;Database=sevktakip;user=sevktakip;Pwd=Pavk7eptcu3e;SslMode=none");
            baglanti.Open();
            string komut = "SELECT * FROM üretime_giren_projeler";
            MySqlDataAdapter da = new MySqlDataAdapter(komut, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            tamamlanan_sevk.DataSource = dt;

            string komut1 = "SELECT * FROM tamamlanan_projeler";
            MySqlDataAdapter da1 = new MySqlDataAdapter(komut1, baglanti);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            to_tamamlanan_prj.DataSource = dt1;
            baglanti.Close();
        }

        private void listele()
        {
            tamamlanan_sevk.ClearSelection();
            to_tamamlanan_prj.ClearSelection();
            MySqlConnection baglanti = new
            MySqlConnection("Server=185.118.141.56;Database=sevktakip;user=sevktakip;Pwd=Pavk7eptcu3e;SslMode=none");
            baglanti.Open();
            string komut = "SELECT * FROM üretime_giren_projeler";
            MySqlDataAdapter da = new MySqlDataAdapter(komut, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            tamamlanan_sevk.DataSource = dt;

            string komut1 = "SELECT * FROM tamamlanan_projeler";
            MySqlDataAdapter da1 = new MySqlDataAdapter(komut1, baglanti);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            to_tamamlanan_prj.DataSource = dt1;
            baglanti.Close();

        }

        private void Tamamlanan_Projeler_Load(object sender, EventArgs e)
        {

        }

        private void aktar_Click(object sender, EventArgs e)
        {

            MySqlConnection baglanti = new
MySqlConnection("Server=185.118.141.56;Database=sevktakip;user=sevktakip;Pwd=Pavk7eptcu3e;SslMode=none");
            baglanti.Open();
            cmd = new MySqlCommand();

            cmd.Connection = baglanti;

            cmd.CommandText = "SELECT * FROM üretime_giren_projeler WHERE ID='" + to_id.Texts + "'"; //ARAMA VE VERİYİ GİZLİ TEXTBOX LARA YAZMA
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                textBox1.Text = dr["ID"].ToString();
                textBox2.Text = dr["Proje_Kodu"].ToString();
                textBox3.Text = dr["Müşteri_İsmi"].ToString();
                textBox5.Text = dr["Sevk_Tarihi"].ToString();
                textBox6.Text = dr["Sevkiyat_Bölgesi"].ToString();
                textBox7.Text = dr["Satış_Fiyatı"].ToString();


                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.Parameters.AddWithValue("@pk", textBox2.Text);
                cmd.Parameters.AddWithValue("@mi", textBox3.Text);
                cmd.Parameters.AddWithValue("@st", textBox5.Text);
                cmd.Parameters.AddWithValue("@sb", textBox6.Text);
                cmd.Parameters.AddWithValue("@sf", textBox7.Text);

            }

            baglanti.Close();
            baglanti.Open();

            MySqlCommand ekle = new MySqlCommand("insert into tamamlanan_projeler (ID,Proje_Kodu,Müşteri_İsmi,Sevk_Tarihi,Sevkiyat_Bölgesi,Satış_Fiyatı) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')", baglanti);

            object sonuc = null; //TEXTBOXLARDAKİ VERİLERİ ALARAK DİĞER DATABASE YE KAYDETME

            sonuc = ekle.ExecuteNonQuery(); // sorgu çalıştı ve dönen değer objec türünden değişkene geçti eğer değişken boş değilse eklendi boşşsa eklenmedi.

            if (sonuc != null)

                MessageBox.Show("Sisteme başarıyla eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            else

                MessageBox.Show("Sisteme eklenemedi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            // MessageBox.Show("Başarı ile aktarıldı.");
            baglanti.Close();

            baglanti.Open();

            MySqlCommand cmd2 = new MySqlCommand("DELETE FROM üretime_giren_projeler WHERE ID=('" + to_id.Texts + "')", baglanti);
       
            if (cmd2.ExecuteNonQuery() == 1)
            {
                //MessageBox.Show(“Silindi… Ekran Kapatılıyor..”);

              //  this.Close();
            }
            else
            {
                MessageBox.Show("Bilinmeyen bir hata oluşu");
            }
            baglanti.Close();


            baglanti.Close();

            listele();
            System.Threading.Thread.Sleep(10);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();

        }
        

        private void güncelle_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new
MySqlConnection("Server=185.118.141.56;Database=sevktakip;user=sevktakip;Pwd=Pavk7eptcu3e;SslMode=none");

            baglanti.Open();

            MySqlCommand cmd2 = new MySqlCommand("DELETE FROM tamamlanan_projeler WHERE ID=('" + to_id.Texts + "')", baglanti);

            if (cmd2.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                //  this.Close();
            }
            else
            {
                MessageBox.Show("Bilinmeyen bir hata oluşu");
            }
            baglanti.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
