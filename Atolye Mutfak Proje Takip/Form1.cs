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


    public partial class kullanici_giris : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;


        public kullanici_giris()
        
        {
            InitializeComponent();
            con = new MySqlConnection("Server=185.118.141.56;Database=sevktakip;user=sevktakip;Pwd=Pavk7eptcu3e;SslMode=none");
            MessageBox.Show("Veritabaný Baðlantýsý Saðlandý ve Uygulama Açýlmaya Hazýr.");
            //Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;

        }

        private void kullanici_giris_Load(object sender, EventArgs e)
        {

        }

        private void giris_yap_Click(object sender, EventArgs e)
        {

        }

        private void giris_yap_new_Click(object sender, EventArgs e)
        {
            string user = kul_adi.Texts;
            string pass = kul_sifrea.Texts;

            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM kullanicibilgiler where kullanici_adi='" + user + "' AND kullanici_sifre='" + pass + "'";
            cmd.Parameters.AddWithValue("@deger", pass);
            cmd.CommandText = "SELECT * FROM kullanicibilgiler where kullanici_sifre=@deger";// +pass + "' AND yetki_hesap_sahip_bilgi='" + name + "'"

            dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                MessageBox.Show("Giriþ Baþarýlý.");



                anasayfa form2sec = new anasayfa();
                string name = "";
                string yetki = "";
                string usrid = "";
                pass = dr["kullanici_sifre"].ToString();
                name = dr["kullanici_isim"].ToString();
                usrid = dr["yetki_gurubu"].ToString();
                form2sec.isimsoy.Text = "" + name + "";
                form2sec.yetki.Text = "" + usrid + "";
                form2sec.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalý Kullanýcý Adý veya Þifre Girdiniz.");
                DialogResult sonuc;
                sonuc = MessageBox.Show("Hatalý Kullanýcý Adý veya Þifre Girdiniz. Yeniden Deneyiniz.", "Yanlýþ Kullanýcý Adý Þifre", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (sonuc == DialogResult.No)
                {
                    Application.Exit();
                }
                if (sonuc == DialogResult.Yes)
                {
                    con.Close();
                }
            }

        }
    }
}