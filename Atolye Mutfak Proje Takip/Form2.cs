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
using MySql.Data.MySqlClient;

namespace Atolye_Mutfak_Proje_Takip
{
    public partial class Form2 : Form
    {

        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public Form2()
        {


            InitializeComponent();
            MySqlConnection baglanti = new
            MySqlConnection("Server=185.118.141.56;Database=sevktakip;user=sevktakip;Pwd=Pavk7eptcu3e;SslMode=none");
            baglanti.Open();
            string komut = "SELECT * FROM üretime_giren_projeler";
            MySqlDataAdapter da = new MySqlDataAdapter(komut, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            üretimdrm.DataSource = dt;
            baglanti.Close();



        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }




        private void listele()
        {
            üretimdrm.ClearSelection();
            MySqlConnection baglanti = new
            MySqlConnection("Server=185.118.141.56;Database=sevktakip;user=sevktakip;Pwd=Pavk7eptcu3e;SslMode=none");
            baglanti.Open();
            string komut = "SELECT * FROM üretime_giren_projeler";
            MySqlDataAdapter da = new MySqlDataAdapter(komut, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            üretimdrm.DataSource = dt;
            baglanti.Close();

        }

        private void mevctsevk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void duzenle_Click(object sender, EventArgs e)
        {

            int ID = 0;
            if (int.TryParse(id.Texts, out ID))
            {
                MySqlConnection baglanti = new
MySqlConnection("Server=185.118.141.56;Database=sevktakip;user=sevktakip;Pwd=Pavk7eptcu3e;SslMode=none");
                baglanti.Open();
                MySqlCommand cmd = new MySqlCommand("select * from üretime_giren_projeler ms where ID = @id", baglanti);
                cmd.Parameters.AddWithValue("@id", ID);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    sevkiyatduzenle sd = new sevkiyatduzenle();
                    sd.textboxıd.Text += dr["ID"].ToString();
                    sd.pk.Texts += dr["Proje_Kodu"].ToString();
                    sd.mi.Texts += dr["Müşteri_İsmi"].ToString();
                    sd.st.Texts += dr["Sevk_Tarihi"].ToString();
                    sd.n.Texts += dr["Notlar"].ToString();
                    sd.sshb.Texts += dr["SSH_Bilgisi"].ToString();
                    sd.ei.Texts += dr["Eksik_İçerik"].ToString();
                    sd.sb.Texts += dr["Sevkiyat_Bölgesi"].ToString();
                    sd.sf.Texts += dr["Satış_Fiyatı"].ToString();
                    sd.ebatlama.Texts += dr["Ebatlama_Kesim"].ToString();
                    sd.bantlama.Texts += dr["Bantlama"].ToString();
                    sd.cnc.Texts += dr["CNC"].ToString();
                    sd.toplama.Texts += dr["Toplama"].ToString();
                    sd.çekmece.Texts += dr["Çekmece"].ToString();
                    sd.temizleme.Texts += dr["Temizleme"].ToString();
                    sd.paketleme.Texts += dr["Paketleme"].ToString();
                    sd.sevkiyat.Texts += dr["Sevkiyat"].ToString();


                    sd.Show();
                    //Burada istediğiniz işlemi yapabilirsiniz
                }
                baglanti.Close();
            }



        }

        private void güncelle_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
